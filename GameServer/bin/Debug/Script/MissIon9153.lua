--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (使用毒药的注意事项) --- So buoc: (3)
function MissIon9153(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<108 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 108 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000537 = GetQuestItme(UserWorldId, 900000537, 5)  --kiem tra vat pham nhiem vu
              local  bool900000538 = GetQuestItme(UserWorldId, 900000538, 5)  --kiem tra vat pham nhiem vu
              local  bool900000539 = GetQuestItme(UserWorldId, 900000539, 5)  --kiem tra vat pham nhiem vu
              if bool900000537 then --du yeu cau
              if bool900000538 then --du yeu cau
              if bool900000539 then --du yeu cau
              AddQuestItme(UserWorldId,900000537,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000538,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000539,0) --xoa vat pham nhiem vu
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
          elseif QuestLevel==2 then
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000540 ) -- SO LUONG: ( 5 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 6001 ) -- X: ( 387 ) -- Y: ( 416 ) --
 
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
          elseif QuestLevel==3 then
              local controng=GetPackages(UserWorldId,4)  --vi tri con trong
              if controng.Count < 4 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000540 = GetQuestItme(UserWorldId, 900000540, 5)  --kiem tra vat pham nhiem vu
              if bool900000540 then --du yeu cau
                  AddQuestItme(UserWorldId,900000540,0) --xoa vat pham nhiem vu
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
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
      if Player.Player_FLD_LEVEL<108 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 108 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==4 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000537 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1101 ) -- X: ( 128 ) -- Y: ( 288 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000538 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1101 ) -- X: ( 131 ) -- Y: ( 290 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000539 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1101 ) -- X: ( 126 ) -- Y: ( 288 ) --
 
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
      if QuestLevel==4 then
      local controng=GetPackages(UserWorldId,4)  --vi tri con trong
        if controng.Count < 4 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                  AddExpToCharacter(UserWorldId,140000000) 
              --tang thuong
              local weiz1000000805=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1000000805,weiz1000000805,50) 
              --tang thuong
              local weiz1000000030=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1000000030,weiz1000000030,2) 
              --tang thuong
              local weiz800000004=GetPackages(UserWorldId,4)  --vi tri con trong
                  AddItmeProp(UserWorldId,800000004,weiz800000004[0],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[1],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[2],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[3],1,0,0,0,0,0,0,0,0,0)
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
