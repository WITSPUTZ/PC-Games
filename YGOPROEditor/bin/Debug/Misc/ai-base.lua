--[[
ai-base.lua

Author: Francot514
Version: 1.0
AI-NAME: BASE

--]]

--- OnStartOfDuel ---
-- Called at start of duel. 
-- You can put stuff like gl hf, taunts, copyright messages in here.
-- 
-- Parameters:
-- (none)
--
-- Return: 
-- (none)
function OnStartOfDuel()	
	AI.Chat("This AI script is for developer purpose only.")
	AI.Chat("Please choose another script if you want to play against a more decent AI")
	
	--print my entire extra deck
	local mydeck = AI.GetAIExtraDeck()
	print("My extra deck consists of the following cards")
	for i=1,#mydeck do
		print(i .. ": " .. mydeck[i].id)
	end
	SaveState()
end

--- OnSelectOption() ---
--
-- Called when AI has to choose an option
-- Example card(s): Elemental HERO Stratos
-- 
-- Parameters:
-- options = table of available options, this is one of the strings from the card database (str1, str2, str3, ..)
--
-- Return: index of the selected option
function OnSelectOption(options)
	print("OnSelectOption available options:")
	for i=1,#options do
		print(i, options[i])
	end
	
	-- Example implementation: pick one of the available options randomly
	return math.random(#options)
end


--- OnSelectEffectYesNo() ---
--
-- Called when AI has to decide whether to activate a card effect
-- 
-- Parameters:
-- id = card id of the effect
--
-- Return: 
-- 1 = yes
-- 0 = no
function OnSelectEffectYesNo(id)
	-- Example implementation: always return yes
	return 1
end


--- OnSelectYesNo() ---
--
-- Called when AI has to decide something
-- 
-- Parameters:
-- description_id = id of the text dialog that is normally shown to the player
--
-- The descriptions can be found in strings.conf
-- For example, description id 30 = 'Replay, do you want to continue the Battle?'
--
-- Return: 
-- 1 = yes
-- 0 = no
-- -1 = let the ai decide
function OnSelectYesNo(description_id)
	-- Example implementation: continue attacking, let the ai decide otherwise
	if description_id == 30 then
		return 1
	else
		return -1
	end
end


--- OnSelectPosition ---
--
-- Called when AI has to select the monster position.
-- 
-- Parameters (2):
-- id = card id
-- available = available positions
--
-- Return: the position
--[[
From constants.lua
POS_FACEUP_ATTACK		=0x1
POS_FACEDOWN_ATTACK		=0x2
POS_FACEUP_DEFENCE		=0x4
POS_FACEDOWN_DEFENCE	=0x8
--]]
function OnSelectPosition(id, available)
	local result = 0
	local band = bit32.band --assign bit32.band() to a local variable
	
	print("OnSelectPosition",id,available)
	
	--Example
	if id == 19665973 then --is this card battle fader?
		--always put battle fader in def position
		result = POS_FACEUP_DEFENCE
	else
		-- default is attack position
		result = POS_FACEUP_ATTACK
	end
	
	-- check if the selected position is valid
	print("is the position valid?", band(result,available))
	if band(result,available) == 0 then
		--invalid position! find a valid value
		print("invalid position! find a valid value")
		if band(POS_FACEUP_ATTACK,available) > 0 then
			result = POS_FACEUP_ATTACK
		elseif band(POS_FACEUP_DEFENCE,available) > 0 then
			result = POS_FACEUP_DEFENCE
		elseif band(POS_FACEDOWN_DEFENCE,available) > 0 then
			result = POS_FACEDOWN_DEFENCE
		else
			result = POS_FACEDOWN_ATTACK
		end
	end
	
	return result
end


--- OnSelectTribute ---
--
-- Called when AI has to tribute monster(s). 
-- Example card(s): Caius the Shadow Monarch, Beast King Barbaros, Hieratic
-- 
-- Parameters (3):
-- cards = available tributes
-- minTributes = minimum number of tributes
-- maxTributes = maximum number of tributes
--
-- Return:
-- result = table containing tribute indices
function OnSelectTribute(cards,minTributes, maxTributes)
	local result = {}
	
	print("OnSelectTribute",minTributes,maxTributes)
	
	-- Example implementation: always choose the mimimum amount of tributes and select the tributes with lowest attack
	
	--copy tributes to a temp table
	local tributes = {}
	for i=1,#cards do
		tributes[i] = {attack=cards[i].attack, index=i}
	end
	--sort table by attack (ascending)
	table.sort(tributes, function(a,b) return a.attack<b.attack end)
	
	for i=1,minTributes do
		result[i]=tributes[i].index
	end
	
	return result
end


--- OnDeclareMonsterType ---
--
-- Called when AI has to declare a monster type. 
-- Example card(s): DNA Surgery, Rivalry of Warlords
-- 
--[[
Check out the Races section in constants.lua

RACE_WARRIOR		=0x1		--
RACE_SPELLCASTER	=0x2		--
RACE_FAIRY			=0x4		--
RACE_FIEND			=0x8		--
RACE_ZOMBIE			=0x10		--
RACE_MACHINE		=0x20		--
RACE_AQUA			=0x40		--
RACE_PYRO			=0x80		--
RACE_ROCK			=0x100		--
RACE_WINDBEAST		=0x200		--
RACE_PLANT			=0x400		--
RACE_INSECT			=0x800		--
RACE_THUNDER		=0x1000		--
RACE_DRAGON			=0x2000		--
RACE_BEAST			=0x4000		--
RACE_BEASTWARRIOR	=0x8000		--
RACE_DINOSAUR		=0x10000	--
RACE_FISH			=0x20000	--
RACE_SEASERPENT		=0x40000	--
RACE_REPTILE		=0x80000	--
RACE_PSYCHO			=0x100000	--
RACE_DEVINE			=0x200000	--
RACE_CREATORGOD		=0x400000	--
--]]
--
-- Parameters (2):
-- count = number of types to return
-- choices = table of valid types
--
-- Return: a number containing the selected types
function OnDeclareMonsterType(count, choices)
	local result = 0
	local returnCount = 0
	
	print("OnDeclareType count: "..count)
	for i=1,#choices do
		print(i, choices[i])
	end
	
	-- Example implementation: Just return the first valid type(s) you come across
	while returnCount < count do
		result = result + choices[returnCount+1] --add type
		returnCount = returnCount + 1
	end
	
	return result
	
	--[[
	--You can return a specific type like this:
	return RACE_WARRIOR --returns the warrior type
	
	--If more types are required then return the sum:
	return RACE_SPELLCASTER+RACE_BEAST --returns spellcaster and beast
	--]]
end


--- OnDeclareAttribute ---
--
-- Called when AI has to declare an attribute. 
-- Example card(s): DNA Transplant, Gozen Match, Earthshaker
-- 
--[[
Check out the Attributes section in constants.lua

ATTRIBUTE_EARTH		=0x01
ATTRIBUTE_WATER		=0x02
ATTRIBUTE_FIRE		=0x04
ATTRIBUTE_WIND		=0x08
ATTRIBUTE_LIGHT		=0x10
ATTRIBUTE_DARK		=0x20
ATTRIBUTE_DEVINE	=0x40
--]]
--
-- Parameters (2):
-- count = number of attributes to return
-- choices = table of valid attributes
--
-- Return: a number containing the selected attributes
function OnDeclareAttribute(count, choices)
	local result = 0
	local returnCount = 0
	
	print("OnDeclareAttribute count: "..count)	
	for i=1,#choices do
		print(i, choices[i])
	end
	
	-- Example implementation: Just return the first valid attribute(s) you come across
	while returnCount < count do
		result = result + choices[returnCount+1] --add attribute
		returnCount = returnCount + 1
	end
	
	return result
	
	--[[
	--You can return a specific attribute like this:
	return ATTRIBUTE_LIGHT --returns the light attribute
	
	--If more attributes are required then return the sum:
	return ATTRIBUTE_WATER+ATTRIBUTE_FIRE --returns water and fire
	--]]
end


--- OnDeclareCard ---
--
-- Called when AI has to declare a card. 
-- Example card(s): Prohibition, Mind Crush
-- 
-- Parameters:
-- none
--
-- Return: id of the selected card
function OnDeclareCard()	
	-- Example implementation: Return the card id of rescue rabbit
	return 85138716 
end


--- OnSelectNumber ---
--
-- Called when AI has to declare a number. 
-- Example card(s): Reasoning
-- 
-- Parameters:
-- choices = table containing the valid choices
--
-- Return: index of the selected choice
function OnSelectNumber(choices)
	for i=1,#choices do
		print(i, choices[i])
	end
	
	-- Example implementation: pick one of the available choices randomly
	return math.random(#choices)
end


--- OnSelectChain --
--
-- Called when AI can chain a card.
-- This function is not completely implemented yet. The parameters will very likely change in the next version.
-- 
-- Parameters (2):
-- cards = table of cards to chain
-- only_chains_by_player = in the current chain links are all of them activated by the (human) player?
--
-- Return: 
-- result
--		1 = yes, chain a card
--		0 = no, don't chain
-- index = index of the chain
function OnSelectChain(cards, only_chains_by_player)
	--By default, do not chain
	local result = 0
	local index = 1
	
	for i=1,#cards do
		print("Should I chain this card? id: "..cards[i].id)
		if cards[i].id == 93717133 then --galaxy eyes photon dragon
			if (cards[i]:is_affected_by(EFFECT_DISABLE) > 0 or cards[i]:is_affected_by(EFFECT_DISABLE_EFFECT) > 0) == false then
				--only try to activate the banish effect if effect has not been negated
				return 1,i
			end
		elseif cards[i].id == 84749824 then --solemn warning
			--is the opponent trying to summon?
			local c = AI.GetOppMonsterZones()
			for j=1,#c do
				if c[j] ~= false then
					if bit32.band(c[j].status,STATUS_SUMMONING) > 0 then
						--yes, activate solemn warning
						return 1,i
					end
				end
			end
			--is the AI trying to summon?
			c = AI.GetAIMonsterZones()
			for j=1,#c do
				if c[j] ~= false then
					if bit32.band(c[j].status,STATUS_SUMMONING) > 0 then
						--yes, do not activate solemn warning on your own cards
						return 0,0
					end
				end
			end
			--we should not negate cards from the AI
			--are we going to negate a card from the player?
			if only_chains_by_player then
				return 1,i
			end
		else
			--we should not chain to cards from the AI
			--are we going to chain to a card from the player?
			if only_chains_by_player then
				return 1,i
			end
		end
	end
	
	-- Example: always chain the first available card
	return result,index
end


--- OnSelectCard ---
--
-- Called when AI has to select a card. Like effect target or attack target.
-- Note: Always check if your return value has the correct amount of targets as specified by minTargets, maxTargets
-- Example card(s): Caius the Shadow Monarch, Chaos Sorcerer, Elemental HERO The Shining
-- 
-- Parameters:
-- cards = table of cards to select
-- minTargets = how many you must select min
-- maxTargets = how many you can select max
-- triggeringID = (deprecated) id of the card that is responsible for the card selection. This parameter is deprecated. Please use triggeringCard instead.
-- triggeringCard = card object of the card that is responsible for the card selection. If card is unknown, triggerCard will be false
--
-- Return: 
-- result = table containing target indices
function OnSelectCard(cards, minTargets, maxTargets, triggeringID, triggeringCard)
	local result = {}
	
	print("OnSelectCard",minTargets,maxTargets)
	if triggeringCard ~= false then
		print("OnSelectCard triggered by: " .. triggeringCard.id)
	else
		print("triggeringCard is unknown!")
	end
	
	-- Example implementation: always choose the mimimum amount of targets and select the index of the first available targets
	for i=1,minTargets do
		result[i]=i
	end
	
	return result
end

--- OnSelectBattleCommand() ---
--
-- Called when AI can battle
-- 
-- Parameters:
-- cards = table of cards that can attack
--
-- Return (2): 
-- execute_attack = should AI attack or not
--		1 = yes
--		0 = no
-- index = index of the card to attack with
function OnSelectBattleCommand(cards)
	print("OnSelectBattleCommand")
	local execute_attack = 1
	local index = 1
	
	local function getWeakestAttackerIndex()
		local lowestIndex = 1
		local lowestAttack = cards[1].attack
		for i=2,#cards do
			if cards[i].attack < cards[lowestIndex].attack then
				lowestIndex = i
				lowestAttack = cards[i].attack
			end
		end
		
		return lowestIndex
	end
	
	-- Example implementation: always attack if possible, always lowest attack first
	if #cards > 0 then
		execute_attack = 1
		index = getWeakestAttackerIndex()
	else
		execute_attack = 0
		--index does not matter in this case
		index = 0
	end
	
	return execute_attack,index
end


--- OnSelectInitCommand() ---
--
-- Called when the system is waiting for the AI to play a card.
-- This is usually in Main Phase or Main Phase 2
--
-- Parameters (3):
-- cards = a table containing all the cards that the ai can use
-- 		cards.summonable_cards = for normal summon
-- 		cards.spsummonable_cards = for special special summon
-- 		cards.repositionable_cards = for changing position
-- 		cards.monster_setable_cards = monster cards for setting
-- 		cards.st_setable_cards = spells/traps for setting
-- 		cards.activatable_cards = for activating
-- to_bp_allowed = is entering battle phase allowed?
-- to_ep_allowed = is entering end phase allowed?
--
--[[
Each "card" object has the following fields:
card.id
card.original_id --original printed card id. Example: Elemental HERO Prisma can change id, but the original_id will always be 89312388
card.type --Refer to /script/constant.lua for a list of card types
card.attack
card.defense
card.base_attack
card.base_defense
card.level
card.base_level
card.rank
card.race --monster type
card.attribute
card.position
card.setcode --indicates the archetype
card.location --Refer to /script/constant.lua for a list of locations
card.xyz_material_count --number of material attached
card.xyz_materials --table of cards that are xyz material
card.owner --1 = AI, 2 = player
card.status --Refer to /script/constant.lua for a list of statuses
card:is_affected_by(effect_type) --Refer to /script/constant.lua for a list of effects
card:get_counter(counter_type) --Checks how many of counter_type this card has. Refer to /strings.conf for a list of counters

Sample usage

if card:is_affected_by(EFFECT_CANNOT_CHANGE_POSITION) then
	--this card cannot change position
end
if card:is_affected_by(EFFECT_CANNOT_RELEASE) then
	--this card cannot be tributed
end
if card:is_affected_by(EFFECT_DISABLE) or card:is_affected_by(EFFECT_DISABLE_EFFECT) then
	--this card's effect is currently negated
end

if card:get_counter(0x3003) > 0 then
	--this card has bushido counters
end

if(cards.activatable_cards[i].xyz_material_count > 0) then
local xyzmat = cards.activatable_cards[i].xyz_materials
	for j=1,#xyzmat do
		print("material " .. j .. " = " .. xyzmat[j].id)
	end
end


-- Return:
-- command = the command to execute
-- index = index of the card to use
-- 
-- Here are the available commands
]]
COMMAND_LET_AI_DECIDE		= -1
COMMAND_SUMMON 				= 0
COMMAND_SPECIAL_SUMMON 		= 1
COMMAND_CHANGE_POS 			= 2
COMMAND_SET_MONSTER 		= 3
COMMAND_SET_ST 				= 4
COMMAND_ACTIVATE 			= 5
COMMAND_TO_NEXT_PHASE 		= 6
COMMAND_TO_END_PHASE 		= 7
function OnSelectInitCommand(cards, to_bp_allowed, to_ep_allowed)	
	--[[
	print("OnSelectInitCommand")
	print("#cards.summonable_cards = " .. #cards.summonable_cards)
	print("#cards.spsummonable_cards = " .. #cards.spsummonable_cards)
	print("#cards.repositionable_cards = " .. #cards.repositionable_cards)
	print("#cards.monster_setable_cards = " .. #cards.monster_setable_cards)
	print("#cards.st_setable_cards = " .. #cards.st_setable_cards)
	print("#cards.activatable_cards = " .. #cards.activatable_cards)
	--]]
	
	-- activate all cards
	if #cards.activatable_cards > 0 then
		print("DECISION: activate card effect")
		local act = cards.activatable_cards
		for i=1,#act do
			if act[i].id == 22624373 or act[i].id == 37742478 then --Lyla or Honest
				if (act[i]:is_affected_by(EFFECT_DISABLE) > 0 or act[i]:is_affected_by(EFFECT_DISABLE_EFFECT) > 0) == false then
					--only try to activate the effect if effect has not been negated
					return COMMAND_ACTIVATE,i
				end
			end
		end
	end
	-- special summon all cards
	if #cards.spsummonable_cards > 0 then
		print("DECISION: special summon card")
		return COMMAND_SPECIAL_SUMMON,1
	end	
	-- normal summon cards
	if #cards.summonable_cards > 0 then
		print("DECISION: normal summon card")
		return COMMAND_SUMMON,1
	end
	-- set monster cards
	if #cards.monster_setable_cards > 0 then
		print("DECISION: set monster card")
		return COMMAND_SET_MONSTER,1
	end
	-- set all trap cards in Main Phase 2
	if #cards.st_setable_cards > 0 and AI.GetCurrentPhase() == PHASE_MAIN2 then
		local setCards = cards.st_setable_cards
		for i=1,#setCards do
			if bit32.band(setCards[i].type,TYPE_TRAP) > 0 then
				print("DECISION: set trap card")
				return COMMAND_SET_ST,i
			end
		end
	end
		
	print("DECISION: go to next phase")
	-- there should be check here to see if the next phase is disallowed (like Karakuri having to attack)
	-- Go to end phase if battle phase is not allowed
	if AI.GetCurrentPhase() == PHASE_MAIN1 and to_bp_allowed then
		--go to bp
		return COMMAND_TO_NEXT_PHASE,1
	else
		--go to end phase
		return COMMAND_TO_END_PHASE,1
	end
end