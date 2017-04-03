--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (????? ???? 5) --- So buoc: (2)
function MissIon281(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<126 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 126 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000587 = GetQuestItme(UserWorldId, 900000587, 20)  --kiem tra vat pham nhiem vu
              local  bool900000589 = GetQuestItme(UserWorldId, 900000589, 20)  --kiem tra vat pham nhiem vu
              if bool900000587 then --du yeu cau
              if bool900000589 then --du yeu cau
              AddQuestItme(UserWorldId,900000587,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000589,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000587 ) -- SO LUONG: ( 10 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000589 ) -- SO LUONG: ( 10 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
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
          elseif QuestLevel==2 then
              local controng=GetPackages(UserWorldId,4)  --vi tri con trong
              if controng.Count < 4 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000587 = GetQuestItme(UserWorldId, 900000587, 10)  --kiem tra vat pham nhiem vu
              local  bool900000589 = GetQuestItme(UserWorldId, 900000589, 10)  --kiem tra vat pham nhiem vu
              if bool900000587 then --du yeu cau
              if bool900000589 then --du yeu cau
                  AddQuestItme(UserWorldId,900000587,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000589,0) --xoa vat pham nhiem vu
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
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
      if Player.Player_FLD_LEVEL<126 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 126 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==3 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000587 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 25100 ) -- X: ( 96 ) -- Y: ( 313 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000589 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 25100 ) -- X: ( 89 ) -- Y: ( 445 ) --
 
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
      if QuestLevel==3 then
      local controng=GetPackages(UserWorldId,4)  --vi tri con trong
        if controng.Count < 4 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                  AddExpToCharacter(UserWorldId,200000000) 
              --tang thuong
              local weiz800000023=GetPackages(UserWorldId,2)  --vi tri con trong
                  local chiso=math.random(700015,700025) 
                  AddItmeProp(UserWorldId,800000023,weiz800000023[0],1,chiso,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000023,weiz800000023[1],1,chiso,0,0,0,0,0,0,0,0)
              --tang thuong
              local weiz800000024=GetPackages(UserWorldId,2)  --vi tri con trong
                  local chiso=math.random(200005,2000015) 
                  AddItmeProp(UserWorldId,800000024,weiz800000024[0],1,chiso,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000024,weiz800000024[1],1,chiso,0,0,0,0,0,0,0,0)
              --tang thuong
              local weiz1000000644=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1000000644,weiz1000000644,5) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
