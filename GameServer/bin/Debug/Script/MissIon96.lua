--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (???? ?? 3/3) --- So buoc: (2)
function MissIon96(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<74 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 74 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000276 = GetQuestItme(UserWorldId, 900000276, 5)  --kiem tra vat pham nhiem vu
              local  bool900000277 = GetQuestItme(UserWorldId, 900000277, 5)  --kiem tra vat pham nhiem vu
              local  bool900000278 = GetQuestItme(UserWorldId, 900000278, 10)  --kiem tra vat pham nhiem vu
              if bool900000276 then --du yeu cau
              if bool900000277 then --du yeu cau
              if bool900000278 then --du yeu cau
              AddQuestItme(UserWorldId,900000276,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000277,0) --xoa vat pham nhiem vu
              AddQuestItme(UserWorldId,900000278,0) --xoa vat pham nhiem vu
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
              local controng=GetPackages(UserWorldId,4)  --vi tri con trong
              if controng.Count < 4 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
              end
           else
           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) 
           end
      end
  elseif StepQuest==2 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if Player.Player_FLD_LEVEL<74 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 74 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==3 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000276 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 488 ) -- Y: ( 430 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000277 ) -- SO LUONG: ( 5 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 1001 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000278 ) -- SO LUONG: ( 10 ) -- BUOC: ( 1 ) --
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
      if QuestLevel==3 then
      local controng=GetPackages(UserWorldId,4)  --vi tri con trong
        if controng.Count < 4 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                  AddExpToCharacter(UserWorldId,7400000) 
              --tang thuong
              local weiz1008000003=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1008000003,weiz1008000003,1) 
              --tang thuong
              local weiz800000029=GetPackages(UserWorldId,1)  --vi tri con trong
                  AddItmeProp(UserWorldId,800000029,weiz800000029[0],1,0,0,0,0,0,0,0,0,0)
              --tang thuong
              local weiz1008000348=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1008000348,weiz1008000348,1) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
