	for i=1,#activate do
		cardid = activate[i].id
		if cardid == (card) then
			return COMMAND_ACTIVATE,i
		end
	end