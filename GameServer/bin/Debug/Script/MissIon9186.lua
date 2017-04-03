--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (我的急速激情(女)) --- So buoc: (1)
function MissIon9186(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<1 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 1 moi co the nhan nhiem vu !", 9, "He thong")
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
              local  bool26900118 = GetQuestItme(UserWorldId, 26900118, 1)  --kiem tra vat pham nhiem vu
              local  bool1000000161 = GetQuestItme(UserWorldId, 1000000161, 20)  --kiem tra vat pham nhiem vu
              local  bool1000000162 = GetQuestItme(UserWorldId, 1000000162, 20)  --kiem tra vat pham nhiem vu
              local  bool1000000163 = GetQuestItme(UserWorldId, 1000000163, 20)  --kiem tra vat pham nhiem vu
              local  bool1000000164 = GetQuestItme(UserWorldId, 1000000164, 20)  --kiem tra vat pham nhiem vu
              local  bool1000000199 = GetQuestItme(UserWorldId, 1000000199, 20)  --kiem tra vat pham nhiem vu
              if bool26900118 then --du yeu cau
              if bool1000000161 then --du yeu cau
              if bool1000000162 then --du yeu cau
              if bool1000000163 then --du yeu cau
              if bool1000000164 then --du yeu cau
              if bool1000000199 then --du yeu cau
                  AddQuestItme(UserWorldId,26900118,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,1000000161,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,1000000162,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,1000000163,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,1000000164,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,1000000199,0) --xoa item nhiem vu
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
      if Player.Player_FLD_LEVEL<1 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 1 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==2 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
                  AddQuestItme(UserWorldId,26900118,1) --them vat pham nhiem vu cho buoc tiep theo
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1000000161 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1000000162 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1000000163 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1000000164 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1000000199 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 101 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
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
              --tang thuong
              local weiz26900295=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,26900295,weiz26900295,1) 
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
