--LUA Generator by YULGANG - 13 20170320 
function MissIon622(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<140 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
              local  bool100204009 = GetQuestItme(UserWorldId, 100204009, 1)
              if bool100204009 then
                  AddQuestItme(UserWorldId,100204009,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool900000762 = GetQuestItme(UserWorldId, 900000762, 5)
              if bool900000762 then
                  AddQuestItme(UserWorldId,900000762,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool100204010 = GetQuestItme(UserWorldId, 100204010, 1)
              if bool100204010 then
                  AddQuestItme(UserWorldId,100204010,0)
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
              local weiz100204026=GetPackage(UserWorldId)
              if weiz100204026==-1 then
                  SendSysMsg(UserWorldId,"There is no space in the equipment column", 9, "SystemMessage")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,100204026,weiz100204026,1)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
