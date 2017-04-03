--OpenItmeTrigGer为打开物品的触发器，本函数名不可以更改
--ItmeId  物品ID
--site	  物品在包裹中的位置
--number  物品数量
function OpenItmeTrigGer(UserWorldId, ItmeId, site, number)
	SendMissionMsg(UserWorldId,ItmeId, 11, site)
	if ItmeId==1000000388 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000389 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000390 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000391 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000392 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000393 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000394 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000395 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000396 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000397 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000398 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000399 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
		
				---buffdhl--
	elseif ItmeId==1000001009 then
		Skill(UserWorldId, ItmeId, site, number)
		
--会员一个月红包
	--elseif ItmeId==1000000050 then
	 	--SetPlayerVIPP(UserWorldId, ItmeId, site, number)
--冲级礼包
	--elseif ItmeId==1008000776 then
	 	--Dengjijiang(UserWorldId, ItmeId, site, number)
--新加的琴师
	elseif ItmeId==1000000495 then
	 	addQSKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000498 then
	 	addQSKONGFU(UserWorldId, ItmeId, site, number)

	elseif ItmeId==1000000494 then
	 	addQ1KONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000497 then
	 	addQ1KONGFU(UserWorldId, ItmeId, site, number)

	elseif ItmeId==1000000496 then
	 	addQ3KONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000499 then
	 	addQ3KONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000060 then
	 	--yuanbaoshi(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000061 then
	 	--yuanbaowushi(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000062 then
	 	--yuanbaoyibai(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000058 then
	 	--yuanbaosanbai(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000059 then
	 	--yuanbaowubai(UserWorldId, ItmeId, site, number)
--会员套装
	elseif ItmeId==1008000034 then
	 	--SetPlayerVLB1(UserWorldId, ItmeId, site, number)
------85级套餐=30000元宝

	elseif ItmeId==1008000035 then
	 	--SetPlayerVLB2(UserWorldId, ItmeId, site, number)
------125级套餐=60000元宝
	elseif ItmeId==1008000036 then
	 	--SetPlayerVLB3(UserWorldId, ItmeId, site, number)
------135级套餐=90000元宝

	elseif ItmeId==1008000037 then
	 	--SetPlayerVLB4(UserWorldId, ItmeId, site, number)
------血红首饰套餐=20000元宝
	elseif ItmeId==1008000038 then
	 	--SetPlayerVLB5(UserWorldId, ItmeId, site, number)
------F31套装=20000元宝
	elseif ItmeId==1008000516 then
	 	--SetPlayerVLB31(UserWorldId, ItmeId, site, number)
------狱魔首饰套餐=40000元宝
	elseif ItmeId==1008000501 then
	 	--SetPlayerVLB6(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000502 then
	 	--SetPlayerVLB7(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000503 then
	 	--SetPlayerVLB8(UserWorldId, ItmeId, site, number)
------新手礼包
	elseif ItmeId==1008000504 then
	 	--SetPlayerVLBX(UserWorldId, ItmeId, site, number)
		
-- Bat dau Config rieng

	elseif ItmeId==1008000032 then
	 	DiemTuLuyen(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000385 then
	 	DiemTuLuyenL2(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==1000000379 then
	 	--DiemTuLuyenLV55(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==900000040 then
	 	HoTroNewbie(UserWorldId, ItmeId, site, number)
	
	elseif ItmeId==1000000333 then
	 	NhoOnBac(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000334 then
	 	NhoOnBac(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000335 then
	 	NhoOnBac(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000394 then
	 	NhoOnBac(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000395 then
	 	NhoOnBac(UserWorldId, ItmeId, site, number)
		
	--elseif ItmeId==999000136 then
	 	--ThieuNhi(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==999000137 then
	 	--ThieuNhi(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==999000138 then
	 	--ThieuNhi(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==999000139 then
	 	--ThieuNhi(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==999000142 then
	 	--ThieuNhi(UserWorldId, ItmeId, site, number)
	--elseif ItmeId==999000136 then
	

		
	elseif ItmeId==1000000098 then
	 	BonBinhMuc1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000099 then
	 	BonBinhMuc1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000100 then
	 	BonBinhMuc1(UserWorldId, ItmeId, site, number)
	
	
	elseif ItmeId==1000000380 then
	 	THANG9(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000381 then
	 	THANG9(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000382 then
	 	THANG9(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000383 then
	 	THANG9(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==900000156 then
	 	TrungThu1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000157 then
	 	TrungThu1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000158 then
	 	TrungThu1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000159 then
	 	TrungThu1(UserWorldId, ItmeId, site, number)	
		
		
	elseif ItmeId==999000298 then
	 	THANG92(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000299 then
	 	THANG92(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000380 then
	 	THANG92(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000269 then
	 	THANG92(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==1000000901 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000911 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000913 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000914 then
	 	TrungThu(UserWorldId, ItmeId, site, number) 
	
	elseif ItmeId==1000000608 then
	 	HLWKEO(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000609 then
	 	HLWKEO(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000610 then
	 	HLWKEO(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==900000161 then
	 	HLWAoChoang(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000162 then
	 	HLWAoChoang(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000163 then
	 	HLWAoChoang(UserWorldId, ItmeId, site, number)
	

	elseif ItmeId==999000772 then
	 	ChuCaiMayMan(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000771 then
	 	ChuCaiMayMan(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000770 then
	 	ChuCaiMayMan(UserWorldId, ItmeId, site, number)

		
	elseif ItmeId==900000743 then
	 	DOITIEN1(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000744 then
	 	DOITIEN2(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000745 then
	 	DOITIEN3(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000746 then
	 	DOITIEN4(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000747 then
	 	DOITIEN5(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000748 then
	 	DOITIEN6(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==999000094 then
	 	Noel(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000095 then
	 	Noel(UserWorldId, ItmeId, site, number)
	
	
	elseif ItmeId==999000096 then
	 	NoelDoiQua(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000097 then
	 	NoelDoiQua(UserWorldId, ItmeId, site, number)
	
	elseif ItmeId==999000056 then
	 	NamMoi(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000057 then
	 	NamMoi(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000088 then
	 	NamMoi(UserWorldId, ItmeId, site, number)
	
	elseif ItmeId==900000749 then
	 	BanhChung(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000751 then
	 	BanhChung(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000752 then
	 	BanhChung(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000753 then
	 	BanhChung(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==900000741 then
	 	BanhChungDoiQua(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000740 then
	 	BanhChungDoiQua(UserWorldId, ItmeId, site, number)

	elseif ItmeId==1000000684 then
	 	Socola(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000139 then
	 	Socola(UserWorldId, ItmeId, site, number)
		
	elseif ItmeId==1000000906 then
	 	Banhkem(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000923 then
	 	Banhkem(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000138 then
	 	Banhkem(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000910 then
	 	Banhkem(UserWorldId, ItmeId, site, number)
	
	
	elseif ItmeId==900000736 then
	 	GiaiPhong(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000737 then
	 	GiaiPhong(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000738 then
	 	GiaiPhong(UserWorldId, ItmeId, site, number)
	elseif ItmeId==900000739 then
	 	GiaiPhong(UserWorldId, ItmeId, site, number)	
	
	

	elseif ItmeId==1000000901 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000911 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000913 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000914 then
	 	TrungThu(UserWorldId, ItmeId, site, number)
	
		
	elseif ItmeId==999000554 then
	 	SaoVang(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000555 then
	 	SaoVang(UserWorldId, ItmeId, site, number)
		
	end
end
function addFqjnKONGFU(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local JnId=0
	if Player.Player_Job==1 then
		JnId=100301
	elseif Player.Player_Job==2 then
		JnId=200301
	elseif Player.Player_Job==3 then
		JnId=300301
	elseif Player.Player_Job==4 then
		JnId=400301
	elseif Player.Player_Job==5 then
		JnId=500301
	elseif Player.Player_Job==6 then
		JnId=800301
	elseif Player.Player_Job==7 then
		JnId=900301
	elseif Player.Player_Job==8 then
		JnId=1000301
	elseif Player.Player_Job==9 then
		JnId=2000301
	end

end

function addKONGFU(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_FLD_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_FLD_JOB_LEVEL then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,4)
	AddStKongfu(UserWorldId,3,5)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end
function SetPlayerVIPP(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)

	SetPlayerVIP(UserWorldId,1)
	SendSysMsg(UserWorldId,"恭喜你获得了一个月会员", 9, "系统提示")

end

function yuanbaoshi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,10,1)
	SendSysMsg(UserWorldId,"恭喜你获得10元宝", 9, "系统提示")
end
function yuanbaowushi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,50,1)
	SendSysMsg(UserWorldId,"恭喜你获得50元宝", 9, "系统提示")
end
function yuanbaoyibai(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,100,1)
	SendSysMsg(UserWorldId,"恭喜你获得100元宝", 9, "系统提示")
end
function yuanbaosanbai(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,300,1)
	SendSysMsg(UserWorldId,"恭喜你获得300元宝", 9, "系统提示")
end
function yuanbaowubai(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,500,1)
	SendSysMsg(UserWorldId,"恭喜你获得500元宝", 9, "系统提示")
end
function SetPlayerVSX1(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerShuxing(UserWorldId,100000)
	SendSysMsg(UserWorldId,"恭喜你获得10W攻击", 9, "系统提示")
end


function THANG92(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,999000298)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Muc Vang ", 9, "He Thong")
		return 
	end

local weiz2=GetPakItme(UserWorldId,999000299)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Muc Do", 9, "He Thong")
		return 
	end

local weiz3=GetPakItme(UserWorldId,999000269)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co Duot", 9, "He Thong")
		return 
	end
local weiz4=GetPakItme(UserWorldId,999000380)
	if weiz4==-1 then 
		SendSysMsg(UserWorldId,"Chua co La Co", 9, "He Thong")
		return 
	end

local weizs=GetPackages(UserWorldId,4)
if weizs.Count<4 then 
	SendSysMsg(UserWorldId,"Khong Du 4 O Con Trong Tren Tui Do", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)
UpUseItme(UserWorldId,weiz4,1)
--SetPlayerRxpiont(UserWorldId,0,1)
SendSysMsg(UserWorldId,"Chuc Mung Da Nhan Duoc Vat Pham", 9, "He Thong")

local tiletangqua=math.random(1,100) 
	if tiletangqua > 85 and tiletangqua <= 100 then  -- ngu sac
		AddItmeProp(UserWorldId,1008000055,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 50 and tiletangqua <= 60 then  -- Thai Cuc
		AddItmeProp(UserWorldId,1008000188,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
    if tiletangqua > 0 and tiletangqua <= 20 then -- Ho Tam Dan 40%
		AddItmeProp(UserWorldId,1008000097,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 35 and tiletangqua <= 50 then -- yeu hoa 2h
		AddItmeProp(UserWorldId,1008000306,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 65 and tiletangqua <= 75 then -- yeu hoa 24h
		AddItmeProp(UserWorldId,1008000326,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 20 and tiletangqua <= 35 then -- nghich thien
		AddItmeProp(UserWorldId,1008000212,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 75 and tiletangqua <= 85 then  -- long lan
		AddItmeProp(UserWorldId,1008000213,weizs[0],1,0,0,0,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
	if tiletangqua > 60 and tiletangqua <= 65 then -- STH 10
		AddItmeProp(UserWorldId,1007000027,weizs[0],1,0,0,2000000020,0,0,0,0,0,0)
		SendSysMsg(UserWorldId,"Chuc mung nhan thuong thanh cong ", 10, "He thong")
	end
end

function DiemTuLuyen(UserWorldId, ItmeId, site, number)
local Player = GetPlayer(UserWorldId)
local vitri=GetPakItme(UserWorldId,1008000032)

	if Player.Player_FLD_Level < 80 then 
		SendSysMsg(UserWorldId,"Cap do 80 tro len moi co the su dung !!!", 9, "Luu y")
		return 
	end
	
UpUseItme(UserWorldId,vitri,1)
	AddExpToCharacter(UserWorldId,20000000)
SendSysMsg(UserWorldId,"Nho Than Dan - Diem kinh nghiem gia tang  20.000.000!", 10, "Tu Luyen Dan")
end

function DOITIEN1(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,100,1)
	SendSysMsg(UserWorldId,"Doi duoc 100@CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end

function DOITIEN2(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,300,1)
	SendSysMsg(UserWorldId,"Doi duoc 300@CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end

function DOITIEN3(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,500,1)
	SendSysMsg(UserWorldId,"Doi duoc 500@CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end
function DOITIEN4(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,1000,1)
	SendSysMsg(UserWorldId,"Doi duoc 1000@CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end
function DOITIEN5(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,2000,1)
	SendSysMsg(UserWorldId,"Doi duoc 2000@CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end
function DOITIEN6(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,5000,1)
	SendSysMsg(UserWorldId,"Doi duoc 5000 @CASH. Bam lenh !cash de kiem tra", 20, "He thong")
end


function Noel111(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,999000094)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Hoa Qua ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,999000095)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Nen ", 9, "He Thong")
		return 
	end


local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
		local tile=math.random(1,100) 
			if tile > 55 and tile <= 65 then
			AddItmeProp(UserWorldId,8,weizs[0],1,20000004,80000002,40000100,30000150,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 15 and tile <= 25 then
			AddItmeProp(UserWorldId,1008000251,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 25 and tile <= 35 then -- doi mau toc
			AddItmeProp(UserWorldId,1008000015,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 35 and tile <= 45 then
			AddItmeProp(UserWorldId,100013,weizs[0],1,20000004,60000015,50000015,30000050,40000050,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 45 and tile <= 55 then
			AddItmeProp(UserWorldId,1008000188,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 0 and tile <= 15 then
			AddItmeProp(UserWorldId,1000000901,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 65 and tile <= 75 then --cay tha boss
			AddItmeProp(UserWorldId,1008000110,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 75 and tile <= 100 then
			AddItmeProp(UserWorldId,999000097,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end

function NoelDoiQua111(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,999000096)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Keo Ngot ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,999000097)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Cay Thong ", 9, "He Thong")
		return 
	end


local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
		local tile=math.random(1,83) 
			if tile > 0 and tile <= 15 then
			AddItmeProp(UserWorldId,1008000115,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 15 and tile <= 30 then
			AddItmeProp(UserWorldId,400008,weizs[0],1,20000008,20000031,20000031,0,0,0,0,0,1)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 30 and tile <= 60 then
			AddItmeProp(UserWorldId,1007000007,weizs[0],1,0,0,0,0,0,0,0,0,0) 
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 60 and tile <= 70 then
			AddItmeProp(UserWorldId,900005,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 70 and tile <= 83 then
			AddItmeProp(UserWorldId,900006,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end


function NamMoi111(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,999000056)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham ", 10, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,999000057)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham", 10, "He Thong")
		return 
	end
local weiz3=GetPakItme(UserWorldId,999000088)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham", 10, "He Thong")
		return 
	end




local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)

		local ngaunhien=math.random(1,80) 
					if ngaunhien > 0 and ngaunhien <= 15 then --1000000830
						--AddItmeProp(UserWorldId,1000000357,weiz800000023[0],1,0,0,0,0,0,0,0,0,0)
						AddItmeProp(UserWorldId,1008000055,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc ngu sac", 20, "He thong")
					end
					if ngaunhien > 15 and ngaunhien <= 30 then  --1008000107 ok
						AddItmeProp(UserWorldId,1007000002,weizs[0],1,2000000010,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Tho linh phu", 20, "He thong")
					end
					if ngaunhien > 30 and ngaunhien <= 40 then --  1008000053 tho linh phu
						AddItmeProp(UserWorldId,1007000027,weizs[0],1,2000000010,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Su tu !hong", 20, "He thong")
					end
					if ngaunhien > 40 and ngaunhien <= 50 then --   1008000054 5 sac ok
						AddItmeProp(UserWorldId,1008000197,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Dai chien Than Dan", 20, "He thong")
					end
					if ngaunhien > 50 and ngaunhien <= 55 then --
						AddItmeProp(UserWorldId,1008000241,weizs[0],1,2000000005,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Yeu Hoa Ma Vo", 20, "He thong")
					end
					if ngaunhien >55 and ngaunhien <= 65 then -- Ngoc % cc
						local chiso=math.random(700050,700054) 
						AddItmeProp(UserWorldId,800000023,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Kim Cang Thach Cao Cap ", 20, "He thong")
					end
					if ngaunhien >65 and ngaunhien <= 75 then -- Ngoc pt cc ok
						local chiso=math.random(200029,200034) 
						AddItmeProp(UserWorldId,800000024,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Han Ngoc Thach Cao Cap ", 20, "He thong")
					end
					if ngaunhien >75 and ngaunhien <=80 then -- Ngoc pt cc ok
						AddItmeProp(UserWorldId,1008000232,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Meo Tai Phu ", 20, "He thong")
					end

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 10, "He Thong")
end





function BanhChung(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,900000749)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham ", 10, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,900000751)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham", 10, "He Thong")
		return 
	end
local weiz3=GetPakItme(UserWorldId,900000752)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham", 10, "He Thong")
		return 
	end
local weiz4=GetPakItme(UserWorldId,900000753)
	if weiz4==-1 then 
		SendSysMsg(UserWorldId,"Chua co du vat pham", 10, "He Thong")
		return 
	end



local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)
UpUseItme(UserWorldId,weiz4,1)

		local ngaunhien=math.random(5,100) 
					if ngaunhien > 4 and ngaunhien <= 15 then --1000000830
						--AddItmeProp(UserWorldId,1000000357,weiz800000023[0],1,0,0,0,0,0,0,0,0,0)
						AddItmeProp(UserWorldId,1008000055,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc ngu sac", 20, "He thong")
					end
					if ngaunhien > 15 and ngaunhien <= 30 then  --pil vh
						AddItmeProp(UserWorldId,1000000289,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc yeu hoa", 20, "He thong")
				
					end
					if ngaunhien > 40 and ngaunhien <= 50 then --   meo
						AddItmeProp(UserWorldId,1008000232,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan meo tai phu", 20, "He thong")
				
					end
					if ngaunhien >55 and ngaunhien <= 65 then -- Ngoc % sc
						local chiso=math.random(700035,700040)
						AddItmeProp(UserWorldId,800000061,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Kim Cang Thach Cao Cap ", 20, "He thong")
					end
					if ngaunhien >65 and ngaunhien <= 75 then -- Ngoc kc 1-3
						local chiso=math.random(800003,800003) 
						AddItmeProp(UserWorldId,800000061,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Han Ngoc Thach Cao Cap ", 20, "He thong")
					end
				
					

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 10, "He Thong")
end

function BanhChungDoiQua(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,900000741)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Banh chung ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,900000740)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Canh Dao ", 9, "He Thong")
		return 
	end


local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
		local tile=math.random(1,76) 
			if tile > 0 and tile <= 10 then -- bua 5%
			AddItmeProp(UserWorldId,1000000209,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 10 and tile <= 20 then -- bua 25%
			AddItmeProp(UserWorldId,1008000136,weizs[0],1,0,0,0,0,0,0,0,0,1)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 20 and tile <= 30 then -- chi ton
			AddItmeProp(UserWorldId,1008000194,weizs[0],1,0,0,0,0,0,0,0,0,0) 
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 30 and tile <= 42 then
			AddItmeProp(UserWorldId,801014,weizs[0],1,0,0,0,0,0,0,0,2,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 42 and tile <= 54 then
			AddItmeProp(UserWorldId,802014,weizs[0],1,0,0,0,0,0,0,0,2,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 54 and tile <= 66 then
			AddItmeProp(UserWorldId,400012,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end


function Socola(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,1000000684)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co socola tho ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,999000139)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co sua ", 9, "He Thong")
		return 
	end

local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)

		local tile=math.random(1,100) 
			if tile > 0 and tile <= 0 then
			end
			if tile > 15 and tile <= 25 then
			AddItmeProp(UserWorldId,1008000232,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 25 and tile <= 35 then -- shol
			AddItmeProp(UserWorldId,1000000365,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 45 and tile <= 55 then  -- pil vh
			AddItmeProp(UserWorldId,1000000289,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 1 and tile <= 2 then  -- hop vk han bang
			AddItmeProp(UserWorldId,1000000006,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 65 and tile <= 75 then --cay tha boss
			AddItmeProp(UserWorldId,1008000110,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 75 and tile <= 80 then --shol trung
			AddItmeProp(UserWorldId,1000000330,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 80 and tile <= 90 then --so cap
			AddItmeProp(UserWorldId,800000046,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			
			

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end

function Banhkem(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,1000000906)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co banh kem ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,1000000923)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co thiep ", 9, "He Thong")
		return 
	end
local weiz3=GetPakItme(UserWorldId,999000138)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co socola ", 9, "He Thong")
		return 
end
local weiz4=GetPakItme(UserWorldId,1000000910)
	if weiz4==-1 then 
		SendSysMsg(UserWorldId,"Chua co bong bong ", 9, "He Thong")
		return 
end


local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)
UpUseItme(UserWorldId,weiz4,1)
		local tile=math.random(1,75) 
			if tile > 45 and tile <= 55 then
			AddItmeProp(UserWorldId,12,weizs[0],1,20000004,80000004,40000100,30000150,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 30 and tile <= 45 then -- doi mau toc
			AddItmeProp(UserWorldId,1008000015,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 20 and tile <= 30 then
			AddItmeProp(UserWorldId,100015,weizs[0],1,20000005,20000015,40000050,30000100,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 10 and tile <= 20 then -- diem tu luyen
			AddItmeProp(UserWorldId,1008000032,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 0 and tile <= 10 then
			AddItmeProp(UserWorldId,100014,weizs[0],1,20000006,20000025,0,0,0,0,0,2,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if ngaunhien >55 and ngaunhien <= 65 then -- Ngoc pt cc ok
						local chiso=math.random(200033,200036) 
						AddItmeProp(UserWorldId,800000024,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Han Ngoc Thach Cao Cap ", 20, "He thong")
			end
			if ngaunhien >65 and ngaunhien <= 75 then -- Ngoc % cc
						local chiso=math.random(700052,700055) 
						AddItmeProp(UserWorldId,800000023,weizs[0],1,chiso,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan duoc Kim Cang Thach Cao Cap ", 20, "He thong")
			end

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end

function GiaiPhong(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,900000736)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co chu I", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,900000737)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Trai tim ", 9, "He Thong")
		return 
	end
local weiz3=GetPakItme(UserWorldId,900000738)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co chu V ", 9, "He Thong")
		return 
	end
local weiz4=GetPakItme(UserWorldId,900000739)
	if weiz4==-1 then 
		SendSysMsg(UserWorldId,"Chua co chu N ", 9, "He Thong")
		return 
	end

local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)
UpUseItme(UserWorldId,weiz4,1)

		local ngaunhien=math.random(13,90) 
					if ngaunhien > 12 and ngaunhien <= 15 then --1000000830
						--AddItmeProp(UserWorldId,1000000357,weiz800000023[0],1,0,0,0,0,0,0,0,0,0)
						AddItmeProp(UserWorldId,1007000013,weizs[0],1,2000000020,0,0,0,0,0,0,0,0)
						--SendSysMsg(UserWorldId,"Nhan duoc phao hoa", 20, "He thong")
					end
					if ngaunhien > 15 and ngaunhien <= 30 then  --yeu hoa vua
						AddItmeProp(UserWorldId,1008000241,weizs[0],1,0,0,0,0,0,0,0,0,0)
						--SendSysMsg(UserWorldId,"Nhan duoc yeu hoa", 20, "He thong")
					end
					if ngaunhien > 30 and ngaunhien <= 40 then -- -- 5 sac
						AddItmeProp(UserWorldId,1008000055,weizs[0],1,0,0,0,0,0,0,0,0,0)
					--SendSysMsg(UserWorldId,"Nhan 5 sac", 20, "He thong")
					end 
					if ngaunhien > 40 and ngaunhien <= 50 then --   meo
						AddItmeProp(UserWorldId,1008000232,weizs[0],1,0,0,0,0,0,0,0,0,0)
						--SendSysMsg(UserWorldId,"Nhan meo tai phu", 20, "He thong")
					end
					if ngaunhien > 50 and ngaunhien <= 55 then -- bua thuy tinh
						AddItmeProp(UserWorldId,1008000115,weizs[0],1,0,0,0,0,0,0,0,0,0)
						--SendSysMsg(UserWorldId,"Nhan duoc phan thuong", 20, "He thong")
					end
					if ngaunhien >55 and ngaunhien <= 65 then -- Ngoc pt cc ok
						AddItmeProp(UserWorldId,1008000306,weizs[0],1,0,0,0,0,0,0,0,0,0)
					end
					if ngaunhien >65 and ngaunhien <= 75 then -- sht
						AddItmeProp(UserWorldId,1007000026,weizs[0],1,0,0,0,0,0,0,0,0,0)
							--SendSysMsg(UserWorldId,"Nhan duoc Kim Cang Thach Cao Cap ", 20, "He thong")
					end
					if ngaunhien > 75 and ngaunhien <= 90 then -- Hop doi Ac
					AddItmeProp(UserWorldId,1008000192,weizs[0],1,0,0,0,0,0,0,0,0,0)
					--SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
					end

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end



function TrungThu1(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,900000156)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Chu Hiep ", 10, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,900000157)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Chu Khach", 10, "He Thong")
		return 
	end
local weiz3=GetPakItme(UserWorldId,900000158)
	if weiz3==-1 then 
		SendSysMsg(UserWorldId,"Chua co Chu Giang", 10, "He Thong")
		return 
	end
local weiz4=GetPakItme(UserWorldId,900000159)
	if weiz4==-1 then 
		SendSysMsg(UserWorldId,"Chua co Chu Ho", 10, "He Thong")
		return 
	end


local weizs=GetPackages(UserWorldId,1)
if weizs.Count<1 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
UpUseItme(UserWorldId,weiz3,1)
UpUseItme(UserWorldId,weiz4,1)


		local ngaunhien=math.random(1,100) 
					if ngaunhien > 50 and ngaunhien <= 100 then  -- PVP 20%
						AddItmeProp(UserWorldId,1000000289,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Dc Pill VH 10.000 He thong")
					end
					if ngaunhien > 30 and ngaunhien <= 50 then  -- PVP 20%
						AddItmeProp(UserWorldId,800000029,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Dc PVP 20% He thong")
					end
					if ngaunhien > 10 and ngaunhien <= 30 then -- Pill EXP 40%
						AddItmeProp(UserWorldId,1008000097,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Dc Pill EXP 40% He thong")
					end
					if ngaunhien > 0 and ngaunhien <= 10 then -- Sói 
						AddItmeProp(UserWorldId,1000000267,weizs[0],1,0,0,0,0,0,0,0,0,0)
						SendSysMsg(UserWorldId,"Nhan Dc Hop Ngau Nhien He thong")
					end

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 10, "He Thong")
end

function SaoVang(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItme(UserWorldId,999000554)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"Chua co Huy Hieu ", 9, "He Thong")
		return 
	end
local weiz2=GetPakItme(UserWorldId,999000555)
	if weiz2==-1 then 
		SendSysMsg(UserWorldId,"Chua co Sao Vang", 9, "He Thong")
		return 
	end


local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"Khong du o trong chua vat pham", 9, "He Thong")
	return 
end
UpUseItme(UserWorldId,weiz1,1)
UpUseItme(UserWorldId,weiz2,1)
		local tile=math.random(1,100) 
			if tile > 0 and tile <= 10 then -- bua 5%
			AddItmeProp(UserWorldId,1000000209,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 10 and tile <= 20 then -- bua 25%
			AddItmeProp(UserWorldId,900000743,weizs[0],1,0,0,0,0,0,0,0,0,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 20 and tile <= 30 then -- chi ton
			AddItmeProp(UserWorldId,1008000194,weizs[0],1,0,0,0,0,0,0,0,0,0) 
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 30 and tile <= 42 then
			AddItmeProp(UserWorldId,16900517,weizs[0],1,0,0,0,0,0,0,0,2,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			if tile > 42 and tile <= 100 then
			AddItmeProp(UserWorldId,26900534,weizs[0],1,0,0,0,0,0,0,0,2,0)
			SendSysMsg(UserWorldId,"Nhan thuong thanh cong ", 10, "He thong")
			end
			

SendSysMsg(UserWorldId,"Chuc mung - Nhan duoc phan thuong", 9, "He Thong")
end
