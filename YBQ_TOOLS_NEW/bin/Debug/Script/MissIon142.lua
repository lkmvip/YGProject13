--LUA Generator by YULGANG - 13 20170320 
function MissIon142(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<94 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==2 then
              local  bool900000352 = GetQuestItme(UserWorldId, 900000352, 20)
              if bool900000352 then
                  AddQuestItme(UserWorldId,900000352,0)
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
              local weiz909000001=GetPackage(UserWorldId)
              if weiz909000001==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000001,weiz909000001,44000000)
              end
              local weiz800000023=GetPackage(UserWorldId)
              if weiz800000023==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,800000023,weiz800000023,2)
              end
              local weiz1000000030=GetPackage(UserWorldId)
              if weiz1000000030==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,1000000030,weiz1000000030,2)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
