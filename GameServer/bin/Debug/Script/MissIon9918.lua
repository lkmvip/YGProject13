--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (����֮��) --- So buoc: (3)
function MissIon9918(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<200 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 200 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 999000022 ) -- SO LUONG: ( 20 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 999000020 ) -- SO LUONG: ( 20 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
              local  bool999000022 = GetQuestItme(UserWorldId, 999000022, 20)  --kiem tra vat pham nhiem vu
              local  bool999000020 = GetQuestItme(UserWorldId, 999000020, 20)  --kiem tra vat pham nhiem vu
              if bool999000022 then --du yeu cau
              if bool999000020 then --du yeu cau
                  AddQuestItme(UserWorldId,999000022,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,999000020,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 999000020 ) -- SO LUONG: ( 21 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 999000022 ) -- SO LUONG: ( 20 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
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
          elseif QuestLevel==3 then
              local controng=GetPackages(UserWorldId,2)  --vi tri con trong
              if controng.Count < 2 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool999000020 = GetQuestItme(UserWorldId, 999000020, 21)  --kiem tra vat pham nhiem vu
              local  bool999000022 = GetQuestItme(UserWorldId, 999000022, 20)  --kiem tra vat pham nhiem vu
              if bool999000020 then --du yeu cau
              if bool999000022 then --du yeu cau
                  AddQuestItme(UserWorldId,999000020,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,999000022,0) --xoa vat pham nhiem vu
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
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
      if Player.Player_FLD_LEVEL<200 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 200 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==4 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
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
      local controng=GetPackages(UserWorldId,2)  --vi tri con trong
        if controng.Count < 2 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 2 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
              --tang thuong
              local weiz1008000073=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1008000073,weiz1008000073,1) 
                  AddKiToCharacter(UserWorldId,50000) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
