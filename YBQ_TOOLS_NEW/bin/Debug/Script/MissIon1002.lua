--LUA Generator by YULGANG - 13 20170320 
function MissIon1002(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<15 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==2 then
              local  bool900000424 = GetQuestItme(UserWorldId, 900000424, 1)
              if bool900000424 then
                  AddQuestItme(UserWorldId,900000424,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=3
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==3 then
              local  bool900000425 = GetQuestItme(UserWorldId, 900000425, 5)
              if bool900000425 then
                  AddQuestItme(UserWorldId,900000425,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=4
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==4 then
              local  bool900000426 = GetQuestItme(UserWorldId, 900000426, 5)
              if bool900000426 then
                  AddQuestItme(UserWorldId,900000426,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=5
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==5 then
              local  bool900000425 = GetQuestItme(UserWorldId, 900000425, 5)
              if bool900000425 then
                  AddQuestItme(UserWorldId,900000425,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool900000426 = GetQuestItme(UserWorldId, 900000426, 5)
              if bool900000426 then
                  AddQuestItme(UserWorldId,900000426,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=6
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==6 then
              local  bool900000427 = GetQuestItme(UserWorldId, 900000427, 1)
              if bool900000427 then
                  AddQuestItme(UserWorldId,900000427,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=7
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
      if QuestLevel==7 then
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
