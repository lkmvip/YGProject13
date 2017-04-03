function DestroyMonster(UserWorldId, MonsterId)	
	local Msg=string.format("MonsterID %s  ",MonsterId)
	SendSysMsg(UserWorldId,Msg, 9, "KillMonster ID: ")
	if MonsterId==15551 then
		Monster15551(UserWorldId)
	elseif MonsterId==15626 then
		Monster15626(UserWorldId)
	end
end

function Monster15551(UserWorldId)
	local Player = GetPlayer(UserWorldId)
        local QuestLevel=GetQuestLevel(UserWorldId,18)
	if QuestLevel == 2 then
		if Player.Player_FLD_LEVEL>=10 then
			if Player.Player_FLD_LEVEL<=40 then
				local ran=math.random(1,100)
				if ran<=40 then
					AddQuestItme(UserWorldId,900000655,1)
				end
			end
		end
	end
end

--한비광 2차퀘스트 황량한협곡

function Monster15626(UserWorldId)
	local  bool900000765 = GetQuestItme(UserWorldId, 900000765, 1) --해당아이템이 1개이상 있는지 검사
	if bool900000765 then --아이템을 1개이상 먹었으면 더이상 드랍안함
		return
	else	
		--아이템이 없음 확율드랍
		local ran=math.random(1,100)
		if ran<=40 then
			AddQuestItme(UserWorldId,900000765,1)
		end
	end
---------------------------두번째 아이템
	local  bool두번째코드 = GetQuestItme(UserWorldId, 두번째코드, 1) --해당아이템이 1개이상 있는지 검사
	if bool두번째코드 then --아이템을 1개이상 먹었으면 더이상 드랍안함
		return
	else	
		--아이템이 없음 확율드랍
		local ran=math.random(1,100)
		if ran<=40 then
			AddQuestItme(UserWorldId,두번째코드,1)
		end
	end
end