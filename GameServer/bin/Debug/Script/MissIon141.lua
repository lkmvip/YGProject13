--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: (????) --- So buoc: (3)
function MissIon141(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<92 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 92 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local  bool900000360 = GetQuestItme(UserWorldId, 900000360, 30)  --kiem tra vat pham nhiem vu
              if bool900000360 then --du yeu cau
              AddQuestItme(UserWorldId,900000360,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000361,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
              else 
              SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2
              end 
          elseif QuestLevel==2 then
              local  bool900000361 = GetQuestItme(UserWorldId, 900000361, 1)  --kiem tra vat pham nhiem vu
              if bool900000361 then --du yeu cau
                  AddQuestItme(UserWorldId,900000361,0) --xoa vat pham nhiem vu
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
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
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
              end
           else
           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) 
           end
      end
  elseif StepQuest==2 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if Player.Player_FLD_LEVEL<92 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 92 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==4 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000360 ) -- SO LUONG: ( 30 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 2101 ) -- X: ( 441 ) -- Y: ( 445 ) --
 
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
              local weiz800000004=GetPackages(UserWorldId,5)  --vi tri con trong
                  AddItmeProp(UserWorldId,800000004,weiz800000004[0],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[1],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[2],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[3],1,0,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000004,weiz800000004[4],1,0,0,0,0,0,0,0,0,0)
                  AddExpToCharacter(UserWorldId,36500000) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
