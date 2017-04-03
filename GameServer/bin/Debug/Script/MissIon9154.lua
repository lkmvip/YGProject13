--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (帅气的南林服装) --- So buoc: (8)
function MissIon9154(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<110 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 110 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000543 ) -- SO LUONG: ( 20 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 6001 ) -- X: ( 74 ) -- Y: ( 142 ) --
 
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
              local  bool900000543 = GetQuestItme(UserWorldId, 900000543, 20)  --kiem tra vat pham nhiem vu
              if bool900000543 then --du yeu cau
                  AddQuestItme(UserWorldId,900000543,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000542 ) -- SO LUONG: ( 20 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 6001 ) -- X: ( 451 ) -- Y: ( 203 ) --
 
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==3 then
              local  bool900000542 = GetQuestItme(UserWorldId, 900000542, 20)  --kiem tra vat pham nhiem vu
              if bool900000542 then --du yeu cau
                  AddQuestItme(UserWorldId,900000542,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000541 ) -- SO LUONG: ( 20 ) -- BUOC: ( 4 ) --
-- BAN DO: ( 6001 ) -- X: ( 466 ) -- Y: ( 135 ) --
 
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==4 then
              local  bool900000541 = GetQuestItme(UserWorldId, 900000541, 20)  --kiem tra vat pham nhiem vu
              if bool900000541 then --du yeu cau
                  AddQuestItme(UserWorldId,900000541,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000544,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==5 then
              local  bool900000544 = GetQuestItme(UserWorldId, 900000544, 1)  --kiem tra vat pham nhiem vu
              if bool900000544 then --du yeu cau
                  AddQuestItme(UserWorldId,900000544,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000544,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==6 then
              local  bool900000544 = GetQuestItme(UserWorldId, 900000544, 1)  --kiem tra vat pham nhiem vu
              if bool900000544 then --du yeu cau
                  AddQuestItme(UserWorldId,900000544,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 900000546 ) -- SO LUONG: ( 10 ) -- BUOC: ( 7 ) --
-- BAN DO: ( 5001 ) -- X: ( 238 ) -- Y: ( 41 ) --
 
              StatusQuest=7  --dat buoc tiep theo la: 7
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 7
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 7
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==7 then
              local  bool900000546 = GetQuestItme(UserWorldId, 900000546, 10)  --kiem tra vat pham nhiem vu
              if bool900000546 then --du yeu cau
                  AddQuestItme(UserWorldId,900000546,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,900000545,1) --them vat pham nhiem vu cho buoc tiep theo
              StatusQuest=8  --dat buoc tiep theo la: 8
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 8
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 8
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
          elseif QuestLevel==8 then
              local controng=GetPackages(UserWorldId,4)  --vi tri con trong
              if controng.Count < 4 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              local  bool900000545 = GetQuestItme(UserWorldId, 900000545, 1)  --kiem tra vat pham nhiem vu
              if bool900000545 then --du yeu cau
                  AddQuestItme(UserWorldId,900000545,0) --xoa vat pham nhiem vu
              StatusQuest=9  --dat buoc tiep theo la: 9
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 9
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 9
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
      if Player.Player_FLD_LEVEL<110 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 110 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==9 then 
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
      if QuestLevel==9 then
      local controng=GetPackages(UserWorldId,4)  --vi tri con trong
        if controng.Count < 4 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 4 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
              --tang thuong
              local weiz800000023=GetPackages(UserWorldId,1)  --vi tri con trong
                  local chiso=math.random(700015,700025) 
                  AddItmeProp(UserWorldId,800000023,weiz800000023[0],1,chiso,0,0,0,0,0,0,0,0)
              --tang thuong
              local weiz1000000839=GetPackage(UserWorldId)  --vi tri con trong
                  AddItme(UserWorldId,1000000839,weiz1000000839,50) 
                  AddExpToCharacter(UserWorldId,160000000) 
              --tang thuong
              local weiz800000024=GetPackages(UserWorldId,1)  --vi tri con trong
                  local chiso=math.random(200005,2000015) 
                  AddItmeProp(UserWorldId,800000024,weiz800000024[0],1,chiso,0,0,0,0,0,0,0,0)
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
