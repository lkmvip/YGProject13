--LUA Generator by YULGANG - 13 20170320 
function MissIon54(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<60 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==2 then
              RwJdId=3
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==3 then
              local  bool900000221 = GetQuestItme(UserWorldId, 900000221, 1)
              if bool900000221 then
                  AddQuestItme(UserWorldId,900000221,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool900000222 = GetQuestItme(UserWorldId, 900000222, 1)
              if bool900000222 then
                  AddQuestItme(UserWorldId,900000222,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool900000223 = GetQuestItme(UserWorldId, 900000223, 2)
              if bool900000223 then
                  AddQuestItme(UserWorldId,900000223,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=4
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==4 then
              RwJdId=5
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==5 then
              local  bool900000220 = GetQuestItme(UserWorldId, 900000220, 10)
              if bool900000220 then
                  AddQuestItme(UserWorldId,900000220,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=6
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==6 then
              RwJdId=7
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==7 then
              local  bool900000224 = GetQuestItme(UserWorldId, 900000224, 10)
              if bool900000224 then
                  AddQuestItme(UserWorldId,900000224,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=8
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==8 then
              RwJdId=9
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==9 then
              RwJdId=10
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==10 then
              local  bool900000225 = GetQuestItme(UserWorldId, 900000225, 1)
              if bool900000225 then
                  AddQuestItme(UserWorldId,900000225,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=11
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==11 then
              RwJdId=12
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          else
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          end
      end
  elseif CzId==2 then
      RwJdId=1
      AddQuest(UserWorldId,QuestId,RwJdId)
      SendMissionMsg(UserWorldId,QuestId, 21, RwJdId)
  elseif CzId==3 then
      SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
  elseif CzId==5 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if QuestLevel==12 then
              local weiz909000004=GetPackage(UserWorldId)
              if weiz909000004==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000004,weiz909000004,1000000)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
