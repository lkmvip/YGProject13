--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (Tim bi kip vo cong 2 (TC5 - B2) (vat pham)) --- So buoc: (1)
function MissIon180(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<100 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 100 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local controng=GetPackages(UserWorldId,1)  --vi tri con trong
              if controng.Count < 1 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 1 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000516 = GetQuestItme(UserWorldId, 900000516, 200)  --kiem tra vat pham nhiem vu
              local  bool900000517 = GetQuestItme(UserWorldId, 900000517, 200)  --kiem tra vat pham nhiem vu
              if bool900000516 then --du yeu cau
              if bool900000517 then --du yeu cau
                  AddQuestItme(UserWorldId,900000516,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,900000517,0) --xoa item nhiem vu
                  StatusQuest=2  --dat buoc tiep theo la 2
                  AddQuest(UserWorldId,QuestId, StatusQuest)  --cho lam buoc tiep theo la: 2
                  SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 2
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
      if Player.Player_FLD_LEVEL<100 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 100 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==2 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000516 ) -- SO LUONG: ( 200 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 5001 ) -- X: ( 206 ) -- Y: ( 142 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000517 ) -- SO LUONG: ( 200 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 5001 ) -- X: ( 196 ) -- Y: ( 158 ) --
 
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
      local controng=GetPackages(UserWorldId,1)  --vi tri con trong
        if controng.Count < 1 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 1 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
              AddQuestItme(UserWorldId,900000522,1) --them vat pham cho nhiem vu khac
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
