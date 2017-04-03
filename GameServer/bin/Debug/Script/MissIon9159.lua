--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (食人族特殊的骨头加工法) --- So buoc: (1)
function MissIon9159(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<103 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 103 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              local controng=GetPackages(UserWorldId,3)  --vi tri con trong
              if controng.Count < 3 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 3 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000550 = GetQuestItme(UserWorldId, 900000550, 20)  --kiem tra vat pham nhiem vu
              local  bool900000551 = GetQuestItme(UserWorldId, 900000551, 20)  --kiem tra vat pham nhiem vu
              if bool900000550 then --du yeu cau
              if bool900000551 then --du yeu cau
                  AddQuestItme(UserWorldId,900000550,0) --xoa item nhiem vu
                  AddQuestItme(UserWorldId,900000551,0) --xoa item nhiem vu
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
      if Player.Player_FLD_LEVEL<103 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 103 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==2 then 
            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) 
         else
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000550 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 6001 ) -- X: ( 215 ) -- Y: ( 48 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000551 ) -- SO LUONG: ( 20 ) -- BUOC: ( 1 ) --
-- BAN DO: ( 6001 ) -- X: ( 216 ) -- Y: ( 49 ) --
 
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
      local controng=GetPackages(UserWorldId,3)  --vi tri con trong
        if controng.Count < 3 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 3 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
              --tang thuong
              local weiz1000000841=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1000000841,weiz1000000841,50) 
                  AddExpToCharacter(UserWorldId,90000000) 
              --tang thuong
              local weiz800000023=GetPackages(UserWorldId,4)  --vi tri con trong
                  local chiso=math.random(700015,700025) 
                  AddItmeProp(UserWorldId,800000023,weiz800000023[0],1,chiso,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000023,weiz800000023[1],1,chiso,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000023,weiz800000023[2],1,chiso,0,0,0,0,0,0,0,0)
                  AddItmeProp(UserWorldId,800000023,weiz800000023[3],1,chiso,0,0,0,0,0,0,0,0)
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
