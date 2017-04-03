--LUA Generator by YULGANG - 13 20170320 
function MissIon1103(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<45 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
              local  bool900000752 = GetQuestItme(UserWorldId, 900000752, 10)
              if bool900000752 then
                  AddQuestItme(UserWorldId,900000752,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool900000753 = GetQuestItme(UserWorldId, 900000753, 10)
              if bool900000753 then
                  AddQuestItme(UserWorldId,900000753,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
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
      if QuestLevel==2 then
              local weiz900000451=GetPackage(UserWorldId)
              if weiz900000451==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,900000451,weiz900000451,1)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
