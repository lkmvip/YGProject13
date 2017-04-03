--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (? ?? ?? ?? об) --- So buoc: (11)
function MissIon54(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<60 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 60 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
                  AddQuestItme(UserWorldId,900000221,1) --them vat pham nhiem vu cho buoc tiep theo
                  AddQuestItme(UserWorldId,900000222,1) --them vat pham nhiem vu cho buoc tiep theo
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000223 ) -- SO LUONG: ( 2 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 1001 ) -- X: ( 84 ) -- Y: ( 465 ) --
 
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
          elseif QuestLevel==3 then
              local  bool900000221 = GetQuestItme(UserWorldId, 900000221, 1)  --kiem tra vat pham nhiem vu
              local  bool900000222 = GetQuestItme(UserWorldId, 900000222, 1)  --kiem tra vat pham nhiem vu
              local  bool900000223 = GetQuestItme(UserWorldId, 900000223, 2)  --kiem tra vat pham nhiem vu
              if bool900000221 then --du yeu cau
              if bool900000222 then --du yeu cau
              if bool900000223 then --du yeu cau
                  AddQuestItme(UserWorldId,900000221,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000222,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000223,0) --xoa vat pham nhiem vu
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
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==4 then
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000220 ) -- SO LUONG: ( 10 ) -- BUOC: ( 5 ) --
-- BAN DO: ( 1101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
          elseif QuestLevel==5 then
              local  bool900000220 = GetQuestItme(UserWorldId, 900000220, 10)  --kiem tra vat pham nhiem vu
              if bool900000220 then --du yeu cau
                  AddQuestItme(UserWorldId,900000220,0) --xoa vat pham nhiem vu
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==6 then
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000224 ) -- SO LUONG: ( 10 ) -- BUOC: ( 7 ) --
-- BAN DO: ( 1101 ) -- X: ( 151 ) -- Y: ( 195 ) --
 
              StatusQuest=7  --dat buoc tiep theo la: 7
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 7
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 7
          elseif QuestLevel==7 then
              local  bool900000224 = GetQuestItme(UserWorldId, 900000224, 10)  --kiem tra vat pham nhiem vu
              if bool900000224 then --du yeu cau
                  AddQuestItme(UserWorldId,900000224,0) --xoa vat pham nhiem vu
              StatusQuest=8  --dat buoc tiep theo la: 8
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 8
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 8
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==8 then
              StatusQuest=9  --dat buoc tiep theo la: 9
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 9
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 9
          elseif QuestLevel==9 then
                  AddQuestItme(UserWorldId,900000225,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=10  --dat buoc tiep theo la: 10
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 10
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 10
          elseif QuestLevel==10 then
              local  bool900000225 = GetQuestItme(UserWorldId, 900000225, 1)  --kiem tra vat pham nhiem vu
              if bool900000225 then --du yeu cau
                  AddQuestItme(UserWorldId,900000225,0) --xoa vat pham nhiem vu
              StatusQuest=11  --dat buoc tiep theo la: 11
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 11
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 11
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==11 then
              local controng=GetPackages(UserWorldId,1)  --vi tri con trong
              if controng.Count < 1 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 1 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              StatusQuest=12  --dat buoc tiep theo la: 12
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 12
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 12
              end
           else
           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) 
           end
      end
  elseif StepQuest==2 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if Player.Player_FLD_LEVEL<60 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 60 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==12 then 
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
      if QuestLevel==12 then
      local controng=GetPackages(UserWorldId,1)  --vi tri con trong
        if controng.Count < 1 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 1 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
                  AddMoneyToCharacter(UserWorldId,1000000) 
                  SendSysMsg(UserWorldId,"Nhan duoc 1000000 tien vang!", 9, "He thong")
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
