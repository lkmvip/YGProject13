--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: ([4? ??] ??? ???!) --- So buoc: (1)
function MissIon425(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<80 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 80 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local controng=GetPackages(UserWorldId,2)  --vi tri con trong
              if controng.Count < 2 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000767 = GetQuestItme(UserWorldId, 900000767, 1)  --kiem tra vat pham nhiem vu
              if bool900000767 then --du yeu cau
                  AddQuestItme(UserWorldId,900000767,0) --xoa item nhiem vu
                  StatusQuest=2  --dat buoc tiep theo la 2
                  AddQuest(UserWorldId,QuestId, StatusQuest)  --cho lam buoc tiep theo la: 2
                  SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 2
              else
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          end
           else
           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) 
           end
      end
  elseif StepQuest==2 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if Player.Player_FLD_LEVEL<80 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 80 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==2 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
                  AddQuestItme(UserWorldId,900000767,1) --them vat pham nhiem vu cho buoc tiep theo
            StatusQuest=1
            AddQuest(UserWorldId,QuestId, StatusQuest)
            SendMissionMsg(UserWorldId,QuestId, 21, StatusQuest)
            SendSysMsg(UserWorldId,"Nhan nhiem vu thanh cong !", 9, "He thong")
         end
      end
  elseif StepQuest==3 then
      SendMissionMsg(UserWorldId,QuestId, 31, StatusQuest)
      SendSysMsg(UserWorldId,"Ban vua tu choi nhiem vu !", 9, "He thong")
  elseif StepQuest==4 then
      SendSysMsg(UserWorldId,"Huy bo nhiem vu thanh cong !", 9, "He thong")
  elseif StepQuest==5 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if QuestLevel==2 then
      local controng=GetPackages(UserWorldId,2)  --vi tri con trong
        if controng.Count < 2 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                  AddExpToCharacter(UserWorldId,10000000) 
                  AddMoneyToCharacter(UserWorldId,5000000) 
                  SendSysMsg(UserWorldId,"Nhan duoc 5000000 tien vang!", 9, "He thong")
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
