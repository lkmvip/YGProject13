--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (? ?? ?? ?? 1/5) --- So buoc: (7)
function MissIon73(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<80 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 80 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000226 = GetQuestItme(UserWorldId, 900000226, 1)  --kiem tra vat pham nhiem vu
              if bool900000226 then --du yeu cau
              AddQuestItme(UserWorldId,900000226,0) --xoa vat pham nhiem vu
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
          elseif QuestLevel==2 then
                  AddQuestItme(UserWorldId,900000227,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
          elseif QuestLevel==3 then
              local  bool900000227 = GetQuestItme(UserWorldId, 900000227, 1)  --kiem tra vat pham nhiem vu
              if bool900000227 then --du yeu cau
                  AddQuestItme(UserWorldId,900000227,0) --xoa vat pham nhiem vu
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==4 then
                  AddQuestItme(UserWorldId,900000228,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
          elseif QuestLevel==5 then
              local  bool900000228 = GetQuestItme(UserWorldId, 900000228, 1)  --kiem tra vat pham nhiem vu
              if bool900000228 then --du yeu cau
                  AddQuestItme(UserWorldId,900000228,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000229,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==6 then
              local  bool900000229 = GetQuestItme(UserWorldId, 900000229, 1)  --kiem tra vat pham nhiem vu
              if bool900000229 then --du yeu cau
                  AddQuestItme(UserWorldId,900000229,0) --xoa vat pham nhiem vu
              StatusQuest=7  --dat buoc tiep theo la: 7
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 7
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 7
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==7 then
              local controng=GetPackages(UserWorldId,2)  --vi tri con trong
              if controng.Count < 2 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              StatusQuest=8  --dat buoc tiep theo la: 8
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 8
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 8
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
         if QuestLevel==8 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
                  AddQuestItme(UserWorldId,900000226,1) --them vat pham nhiem vu cho buoc tiep theo
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
      if QuestLevel==8 then
      local controng=GetPackages(UserWorldId,2)  --vi tri con trong
        if controng.Count < 2 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
              AddQuestItme(UserWorldId,900000230,1) --them vat pham cho nhiem vu khac
                  AddExpToCharacter(UserWorldId,1000000) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
