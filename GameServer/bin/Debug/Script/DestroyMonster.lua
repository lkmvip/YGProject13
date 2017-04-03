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

--�Ѻ� 2������Ʈ Ȳ��������

function Monster15626(UserWorldId)
	local  bool900000765 = GetQuestItme(UserWorldId, 900000765, 1) --�ش�������� 1���̻� �ִ��� �˻�
	if bool900000765 then --�������� 1���̻� �Ծ����� ���̻� �������
		return
	else	
		--�������� ���� Ȯ�����
		local ran=math.random(1,100)
		if ran<=40 then
			AddQuestItme(UserWorldId,900000765,1)
		end
	end
---------------------------�ι�° ������
	local  bool�ι�°�ڵ� = GetQuestItme(UserWorldId, �ι�°�ڵ�, 1) --�ش�������� 1���̻� �ִ��� �˻�
	if bool�ι�°�ڵ� then --�������� 1���̻� �Ծ����� ���̻� �������
		return
	else	
		--�������� ���� Ȯ�����
		local ran=math.random(1,100)
		if ran<=40 then
			AddQuestItme(UserWorldId,�ι�°�ڵ�,1)
		end
	end
end