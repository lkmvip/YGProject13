--LUA Generator by YULGANG - 13 20170320 
function MissIon431(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<121 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
              local  bool900000774 = GetQuestItme(UserWorldId, 900000774, 1)
              if bool900000774 then
                  AddQuestItme(UserWorldId,900000774,0)
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
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
