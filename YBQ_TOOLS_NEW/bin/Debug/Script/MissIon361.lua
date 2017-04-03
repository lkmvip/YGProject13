--LUA Generator by YULGANG - 13 20170320 
function MissIon361(UserWorldId,QuestId, CzId, RwJdId)
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
              local  bool900000634 = GetQuestItme(UserWorldId, 900000634, 1)
              if bool900000634 then
                  AddQuestItme(UserWorldId,900000634,0)
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
              local weiz909000013=GetPackage(UserWorldId)
              if weiz909000013==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000013,weiz909000013,1)
              end
              local weiz909000018=GetPackage(UserWorldId)
              if weiz909000018==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000018,weiz909000018,1)
              end
              local weiz909000020=GetPackage(UserWorldId)
              if weiz909000020==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000020,weiz909000020,1)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
