--LUA Generator by YULGANG - 13 20170320 
function MissIon470(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<129 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==2 then
              local  bool909000050 = GetQuestItme(UserWorldId, 909000050, 3)
              if bool909000050 then
                  AddQuestItme(UserWorldId,909000050,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool1000000714 = GetQuestItme(UserWorldId, 1000000714, 2)
              if bool1000000714 then
                  AddQuestItme(UserWorldId,1000000714,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=3
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
      if QuestLevel==3 then
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
