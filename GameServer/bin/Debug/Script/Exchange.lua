--Exchange为打开物品的触发器，本函数名不可以更改
--ItmeId  物品ID
--site	  物品在包裹中的位置
--number  物品数量
--GetPakItmesx 取得背包属性物品 
--GetPakItmesx(UserWorldId,999000020,属性1,属性2,属性3,属性4,属性5, int 进化, int 觉醒, int 中级附魂)
--GetPakItme 取得背包普通物品
--GetPakItmesx(UserWorldId,999000020)
function Exchange(UserWorldId, ItmeId, site, number)
	SendMissionMsg(UserWorldId,ItmeId, 11, site)
	if ItmeId==1000000388 then
	 	SetPlayerdh(UserWorldId, ItmeId, site, number)
	end
end
function SetPlayerdh(UserWorldId, ItmeId, site, number)
local weiz1=GetPakItmesx(UserWorldId,999000020,0,0,0,0,0,0,0,0)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"不符合回收要求 ", 9, "系统提示")
		return 
	end
UpUseItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,500,1)
SendSysMsg(UserWorldId,"恭喜你获得500元宝", 9, "系统提示")
end