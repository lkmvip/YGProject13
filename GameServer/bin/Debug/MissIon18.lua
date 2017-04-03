--LUA Generator by YULGANG 
--[[??] ? ??] Stage Count:[1]
function MissIon18(UserWorldId,QuestId, CzId, RwJdId)
if CzId==1 then
if Player.Player_FLD_LEVEL<10 then
else
if QuestLevel==1 then
if bool900000655 then
                  AddQuestItme(UserWorldId,900000655,0)
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
              local weiz909000004=GetPackage(UserWorldId)
              if weiz909000004==-1 then
                  SendSysMsg(UserWorldId,"装备栏没有空位了，请清理!", 9, "GOI_Y_HE_THONG")
                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
                  return 
              else
                  AddItme(UserWorldId,909000004,weiz909000004,10000)
              end
      end
      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
  end
end
