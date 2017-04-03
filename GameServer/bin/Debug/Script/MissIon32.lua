--LUA Generator by YULGANG - 13 - 20170319 
--Ten nhiem vu: () --- So buoc: (29)
function MissIon32(UserWorldId,QuestId, StepQuest, StatusQuest)
  local Player = GetPlayer(UserWorldId)
--Cac buoc xu li nhiem vu
  if StepQuest==1 then
      if Player.Player_FLD_LEVEL<0 then 
          SendSysMsg(UserWorldId,"Ban phai dat cap do 0 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau
      else
          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt
          if QuestLevel==1 then  --neu dang o buoc 1
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 1 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 1 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 199 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 17 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 199 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 29 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
                  AddQuestItme(UserWorldId,0,1) --them vat pham nhiem vu cho buoc tiep theo
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 7 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 101 ) -- X: ( 267 ) -- Y: ( 29 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 3 ) -- SO LUONG: ( 1000000623 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 100 ) -- X: ( 101 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 1000000771 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 10 ) -- X: ( 101 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 1000000772 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 1 ) -- X: ( 101 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 344 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 100 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 226 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 281 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 100 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 101 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 102 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 127 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 81 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 357 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 7 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 101 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 267 ) -- X: ( 29 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 226 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 226 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 101 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 49 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 61 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 107 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 102 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 81 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 234 ) -- Y: ( 28 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 110 ) -- Y: ( 2 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 1 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 199 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 17 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 199 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 2 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
              StatusQuest=2 
              AddQuest(UserWorldId,QuestId, StatusQuest) 
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2
          elseif QuestLevel==2 then
              local  bool1 = GetQuestItme(UserWorldId, 1, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool29 = GetQuestItme(UserWorldId, 29, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 1)  --kiem tra vat pham nhiem vu
              local  bool7 = GetQuestItme(UserWorldId, 7, 0)  --kiem tra vat pham nhiem vu
              local  bool3 = GetQuestItme(UserWorldId, 3, 1000000623)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 1000000771)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 1000000772)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 344)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool100 = GetQuestItme(UserWorldId, 100, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool101 = GetQuestItme(UserWorldId, 101, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool127 = GetQuestItme(UserWorldId, 127, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool81 = GetQuestItme(UserWorldId, 81, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 101)  --kiem tra vat pham nhiem vu
              local  bool226 = GetQuestItme(UserWorldId, 226, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 101)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 61)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool102 = GetQuestItme(UserWorldId, 102, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 199)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 0)  --kiem tra vat pham nhiem vu
              if bool1 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool29 then --du yeu cau
              if bool0 then --du yeu cau
              if bool7 then --du yeu cau
              if bool3 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool100 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool101 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool127 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool81 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool226 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool102 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
              if bool0 then --du yeu cau
                  AddQuestItme(UserWorldId,1,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,29,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,7,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,3,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,100,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,101,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,127,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,81,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,226,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,102,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 8 ) -- SO LUONG: ( 0 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 101 ) -- X: ( 328 ) -- Y: ( 30 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 3 ) -- SO LUONG: ( 1000000624 ) -- BUOC: ( 3 ) --
-- BAN DO: ( 100 ) -- X: ( 101 ) -- Y: ( 0 ) --
 
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
          elseif QuestLevel==3 then
              local  bool8 = GetQuestItme(UserWorldId, 8, 0)  --kiem tra vat pham nhiem vu
              local  bool3 = GetQuestItme(UserWorldId, 3, 1000000624)  --kiem tra vat pham nhiem vu
              if bool8 then --du yeu cau
              if bool3 then --du yeu cau
                  AddQuestItme(UserWorldId,8,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,3,0) --xoa vat pham nhiem vu
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
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 170 ) -- SO LUONG: ( 0 ) -- BUOC: ( 19 ) --
-- BAN DO: ( 101 ) -- X: ( 285 ) -- Y: ( 96 ) --
 
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 77 ) -- BUOC: ( 19 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 0 ) --
 
              StatusQuest=19  --dat buoc tiep theo la: 19
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 19
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 19
          elseif QuestLevel==19 then
              local  bool170 = GetQuestItme(UserWorldId, 170, 0)  --kiem tra vat pham nhiem vu
              local  bool0 = GetQuestItme(UserWorldId, 0, 77)  --kiem tra vat pham nhiem vu
              if bool170 then --du yeu cau
              if bool0 then --du yeu cau
                  AddQuestItme(UserWorldId,170,0) --xoa vat pham nhiem vu
                  AddQuestItme(UserWorldId,0,0) --xoa vat pham nhiem vu
              StatusQuest=20  --dat buoc tiep theo la: 20
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 20
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 20
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
              else 
                  SendSysMsg(UserWorldId,"Chua dat yeu cau, quay lai sau !", 9, "He thong")
                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) 
              end
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
              local controng=GetPackages(UserWorldId,0)  --vi tri con trong
              if controng.Count < 0 then  --neu thung do day 
                SendSysMsg(UserWorldId,"Tui do khong du 0 khong gian trong!", 9, "Chu Y")
                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)
                return 
              else  --neu con cho trong
 
-- VAT PHAM ROT RA KHI DANH QUAI --
-- ID VAT PHAM: ( 0 ) -- SO LUONG: ( 0 ) -- BUOC: ( 30 ) --
-- BAN DO: ( 0 ) -- X: ( 0 ) -- Y: ( 1 ) --
 
              StatusQuest=30  --dat buoc tiep theo la: 30
              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: 30
              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 30
              end
           else
           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) 
           end
      end
  elseif StepQuest==2 then
      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)
      if Player.Player_FLD_LEVEL<0 then  
          SendSysMsg(UserWorldId,"Ban phai dat cap do 0 moi co the nhan nhiem vu !", 9, "He thong")
          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau
      else
         if QuestLevel==30 then 
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
      if QuestLevel==30 then
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
