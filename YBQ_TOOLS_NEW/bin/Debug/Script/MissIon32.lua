--LUA Generator by YULGANG - 13 20170320 
function MissIon32(UserWorldId,QuestId, CzId, RwJdId)
  local Player = GetPlayer(UserWorldId)
  if CzId==1 then
      if Player.Player_FLD_LEVEL<0 then
          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
          if QuestLevel==1 then
              RwJdId=2
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==2 then
              local  bool1 = GetQuestItme(UserWorldId, 1, 0)
              if bool1 then
                  AddQuestItme(UserWorldId,1,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool29 = GetQuestItme(UserWorldId, 29, 0)
              if bool29 then
                  AddQuestItme(UserWorldId,29,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 1)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool7 = GetQuestItme(UserWorldId, 7, 0)
              if bool7 then
                  AddQuestItme(UserWorldId,7,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool3 = GetQuestItme(UserWorldId, 3, 1000000623)
              if bool3 then
                  AddQuestItme(UserWorldId,3,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 1000000771)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 1000000772)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 344)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool100 = GetQuestItme(UserWorldId, 100, 0)
              if bool100 then
                  AddQuestItme(UserWorldId,100,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool101 = GetQuestItme(UserWorldId, 101, 0)
              if bool101 then
                  AddQuestItme(UserWorldId,101,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool127 = GetQuestItme(UserWorldId, 127, 0)
              if bool127 then
                  AddQuestItme(UserWorldId,127,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool81 = GetQuestItme(UserWorldId, 81, 0)
              if bool81 then
                  AddQuestItme(UserWorldId,81,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 101)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool226 = GetQuestItme(UserWorldId, 226, 0)
              if bool226 then
                  AddQuestItme(UserWorldId,226,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 101)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 61)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool102 = GetQuestItme(UserWorldId, 102, 0)
              if bool102 then
                  AddQuestItme(UserWorldId,102,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 199)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=3
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==3 then
              local  bool8 = GetQuestItme(UserWorldId, 8, 0)
              if bool8 then
                  AddQuestItme(UserWorldId,8,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool3 = GetQuestItme(UserWorldId, 3, 1000000624)
              if bool3 then
                  AddQuestItme(UserWorldId,3,0)
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
              RwJdId=6
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==6 then
              RwJdId=7
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==7 then
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
              RwJdId=11
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==11 then
              RwJdId=12
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==12 then
              RwJdId=13
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==13 then
              RwJdId=14
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==14 then
              RwJdId=15
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==15 then
              RwJdId=16
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==16 then
              RwJdId=17
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==17 then
              RwJdId=18
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==18 then
              RwJdId=19
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==19 then
              local  bool170 = GetQuestItme(UserWorldId, 170, 0)
              if bool170 then
                  AddQuestItme(UserWorldId,170,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              local  bool0 = GetQuestItme(UserWorldId, 0, 77)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
              else
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
              end
              RwJdId=20
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==20 then
              RwJdId=21
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==21 then
              RwJdId=22
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==22 then
              RwJdId=23
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==23 then
              RwJdId=24
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==24 then
              RwJdId=25
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==25 then
              RwJdId=26
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==26 then
              RwJdId=27
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==27 then
              RwJdId=28
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==28 then
              RwJdId=29
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
          elseif QuestLevel==29 then
              RwJdId=30
              AddQuest(UserWorldId,QuestId,RwJdId)
              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)
              if bool0 then
                  AddQuestItme(UserWorldId,0,0)
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
      if QuestLevel==30 then
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
