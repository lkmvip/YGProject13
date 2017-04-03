--Unpacked and Fixed by Kr.Huy
--Yahoo: krhuy1996 - Phone: 01202.452.652
--Tools tao Script Lua nhiem vu Hiep Khach
--Ten nhiem vu: (升级送大礼活动) --- So buoc: (40)
function MissIon9751(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<1 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 1 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
              StatusQuest=3  --dat buoc tiep theo la: 3
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 3
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 3
          elseif QuestLevel==3 then
              StatusQuest=4  --dat buoc tiep theo la: 4
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 4
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 4
          elseif QuestLevel==4 then
              StatusQuest=5  --dat buoc tiep theo la: 5
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 5
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 5
          elseif QuestLevel==5 then
              StatusQuest=6  --dat buoc tiep theo la: 6
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 6
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 6
          elseif QuestLevel==6 then
              StatusQuest=7  --dat buoc tiep theo la: 7
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 7
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 7
          elseif QuestLevel==7 then
              StatusQuest=8  --dat buoc tiep theo la: 8
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 8
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 8
          elseif QuestLevel==8 then
              StatusQuest=9  --dat buoc tiep theo la: 9
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 9
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 9
          elseif QuestLevel==9 then
              StatusQuest=10  --dat buoc tiep theo la: 10
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 10
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 10
          elseif QuestLevel==10 then
              StatusQuest=11  --dat buoc tiep theo la: 11
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 11
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 11
          elseif QuestLevel==11 then
              StatusQuest=12  --dat buoc tiep theo la: 12
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 12
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 12
          elseif QuestLevel==12 then
              StatusQuest=13  --dat buoc tiep theo la: 13
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 13
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 13
          elseif QuestLevel==13 then
              StatusQuest=14  --dat buoc tiep theo la: 14
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 14
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 14
          elseif QuestLevel==14 then
              StatusQuest=15  --dat buoc tiep theo la: 15
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 15
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 15
          elseif QuestLevel==15 then
              StatusQuest=16  --dat buoc tiep theo la: 16
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 16
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 16
          elseif QuestLevel==16 then
              StatusQuest=17  --dat buoc tiep theo la: 17
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 17
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 17
          elseif QuestLevel==17 then
              StatusQuest=18  --dat buoc tiep theo la: 18
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 18
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 18
          elseif QuestLevel==18 then
              StatusQuest=19  --dat buoc tiep theo la: 19
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 19
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 19
          elseif QuestLevel==19 then
              StatusQuest=20  --dat buoc tiep theo la: 20
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 20
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 20
          elseif QuestLevel==20 then
              StatusQuest=21  --dat buoc tiep theo la: 21
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 21
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 21
          elseif QuestLevel==21 then
              StatusQuest=22  --dat buoc tiep theo la: 22
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 22
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 22
          elseif QuestLevel==22 then
              StatusQuest=23  --dat buoc tiep theo la: 23
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 23
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 23
          elseif QuestLevel==23 then
              StatusQuest=24  --dat buoc tiep theo la: 24
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 24
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 24
          elseif QuestLevel==24 then
              StatusQuest=25  --dat buoc tiep theo la: 25
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 25
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 25
          elseif QuestLevel==25 then
              StatusQuest=26  --dat buoc tiep theo la: 26
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 26
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 26
          elseif QuestLevel==26 then
              StatusQuest=27  --dat buoc tiep theo la: 27
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 27
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 27
          elseif QuestLevel==27 then
              StatusQuest=28  --dat buoc tiep theo la: 28
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 28
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 28
          elseif QuestLevel==28 then
              StatusQuest=29  --dat buoc tiep theo la: 29
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 29
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 29
          elseif QuestLevel==29 then
              StatusQuest=30  --dat buoc tiep theo la: 30
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 30
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 30
          elseif QuestLevel==30 then
              StatusQuest=31  --dat buoc tiep theo la: 31
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 31
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 31
          elseif QuestLevel==31 then
              StatusQuest=32  --dat buoc tiep theo la: 32
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 32
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 32
          elseif QuestLevel==32 then
              StatusQuest=33  --dat buoc tiep theo la: 33
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 33
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 33
          elseif QuestLevel==33 then
              StatusQuest=34  --dat buoc tiep theo la: 34
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 34
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 34
          elseif QuestLevel==34 then
              StatusQuest=35  --dat buoc tiep theo la: 35
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 35
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 35
          elseif QuestLevel==35 then
              StatusQuest=36  --dat buoc tiep theo la: 36
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 36
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 36
          elseif QuestLevel==36 then
              StatusQuest=37  --dat buoc tiep theo la: 37
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 37
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 37
          elseif QuestLevel==37 then
              StatusQuest=38  --dat buoc tiep theo la: 38
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 38
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 38
          elseif QuestLevel==38 then
              StatusQuest=39  --dat buoc tiep theo la: 39
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 39
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 39
          elseif QuestLevel==39 then
              StatusQuest=40  --dat buoc tiep theo la: 40
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 40
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 40
          elseif QuestLevel==40 then
              local controng=GetPackages(UserWorldId,0)  --vi tri con trong
              if controng.Count < 0 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 0 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
              StatusQuest=41  --dat buoc tiep theo la: 41
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 41
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 41
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
         if QuestLevel==41 then 
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
      if QuestLevel==41 then
      local controng=GetPackages(UserWorldId,0)  --vi tri con trong
        if controng.Count < 0 then  --neu thung do day 
          SendSysMsg(UserWorldId,"Tui do khong du 0 khong gian trong!", 9, "Chu Y")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
          return 
        else  --neu con cho trong
        end 
              SendSysMsg(UserWorldId,"Chuc mung ban da hoan thanh nhiem vu !!!",10,"Chu Y") 
      end
      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)
  end
end
