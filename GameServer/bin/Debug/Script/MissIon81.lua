--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (? ?? ?? ?? 5/5) --- So buoc: (7)
function MissIon81(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<80 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 80 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000250 = GetQuestItme(UserWorldId, 900000250, 5)  --kiem tra vat pham nhiem vu
              local  bool900000251 = GetQuestItme(UserWorldId, 900000251, 5)  --kiem tra vat pham nhiem vu
              local  bool900000252 = GetQuestItme(UserWorldId, 900000252, 5)  --kiem tra vat pham nhiem vu
              local  bool900000253 = GetQuestItme(UserWorldId, 900000253, 5)  --kiem tra vat pham nhiem vu
              if bool900000250 then --du yeu cau
              if bool900000251 then --du yeu cau
              if bool900000252 then --du yeu cau
              if bool900000253 then --du yeu cau
              AddQuestItme(UserWorldId,900000250,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000251,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000252,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000253,0) --xoa vat pham nhiem vu
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
          elseif QuestLevel==2 then
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
          elseif QuestLevel==3 then
                  AddQuestItme(UserWorldId,900000254,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
          elseif QuestLevel==4 then
              local  bool900000254 = GetQuestItme(UserWorldId, 900000254, 1)  --kiem tra vat pham nhiem vu
              if bool900000254 then --du yeu cau
                  AddQuestItme(UserWorldId,900000254,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000255,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==5 then
              local  bool900000255 = GetQuestItme(UserWorldId, 900000255, 1)  --kiem tra vat pham nhiem vu
              if bool900000255 then --du yeu cau
                  AddQuestItme(UserWorldId,900000255,0) --xoa vat pham nhiem vu
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==6 then
              StatusQuest=7  --dat buoc tiep theo la: 7
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 7
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 7
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
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000250 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 488 ) -- Y: ( 431 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000251 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000252 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000253 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
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
                  AddMoneyToCharacter(UserWorldId,5000000) 
                  SendSysMsg(UserWorldId,"Nhan duoc 5000000 tien vang!", 9, "He thong")
                  AddExpToCharacter(UserWorldId,8500000) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
