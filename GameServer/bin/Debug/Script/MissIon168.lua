--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (??? ? ?? ?? 2) --- So buoc: (5)
function MissIon168(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<101 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 101 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000490 ) -- SO LUONG: ( 40 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 5001 ) -- X: ( 236 ) -- Y: ( 42 ) --
 
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
              local  bool900000490 = GetQuestItme(UserWorldId, 900000490, 40)  --kiem tra vat pham nhiem vu
              if bool900000490 then --du yeu cau
                  AddQuestItme(UserWorldId,900000490,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000509,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==3 then
              local  bool900000509 = GetQuestItme(UserWorldId, 900000509, 1)  --kiem tra vat pham nhiem vu
              if bool900000509 then --du yeu cau
                  AddQuestItme(UserWorldId,900000509,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000508 ) -- SO LUONG: ( 60 ) -- BUOC: ( 4 ) --
-- BAN DO: ( 5001 ) -- X: ( 238 ) -- Y: ( 42 ) --
 
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==4 then
              local  bool900000508 = GetQuestItme(UserWorldId, 900000508, 60)  --kiem tra vat pham nhiem vu
              if bool900000508 then --du yeu cau
                  AddQuestItme(UserWorldId,900000508,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000510,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==5 then
              local controng=GetPackages(UserWorldId,3)  --vi tri con trong
              if controng.Count < 3 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 3 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000510 = GetQuestItme(UserWorldId, 900000510, 1)  --kiem tra vat pham nhiem vu
              if bool900000510 then --du yeu cau
                  AddQuestItme(UserWorldId,900000510,0) --xoa vat pham nhiem vu
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
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
      if Player.Player_FLD_LEVEL<101 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 101 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==6 then 
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
      if QuestLevel==6 then
      local controng=GetPackages(UserWorldId,3)  --vi tri con trong
        if controng.Count < 3 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 3 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                 Addexporll(UserWorldId,9001214,10800000) 
                  AddExpToCharacter(UserWorldId,72000000) 
              --tang thuong
              local weiz1008000264=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1008000264,weiz1008000264,1) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
