--自定义兑换物品
--GetPakItmesx(UserWorldId,物品ID, 属性1, 属性2, 属性3,属性4, 属性5,进化, 觉醒, 中级附魂)
--AddItmeProp(UserWorldId,物品ID,weizs[0],1,1010001910,70000050,70000050,70000050,70000050,5,0,2,0)
function ExchangeItem(UserWorldId,str1)
  if str1== "!兑换白菜" then
     local weiz1=GetPakItmesx(UserWorldId,900000001,10,1,1,1,1,1,1,1)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"请检查蛤蟆后腿数量", 10, "系统提示")
		return 
	end
     	local weizs=GetPackages(UserWorldId,2)
	if weizs.Count< 2 then 
		SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
		return 
	end
        local yb=GetRxpiont(UserWorldId)
        if yb < 1000 then
               SendSysMsg(UserWorldId,"兑换需要手续费1000元宝,你的元宝不足", 10, "系统提示")
	       return 
	end
        DelItme(UserWorldId,weiz1,1)
        SetPlayerRxpiont(UserWorldId,10,0)
	AddItmeProp(UserWorldId,11,weizs[0],1,1010001910,70000050,70000050,70000050,70000050,5,0,2,0)
        SendSysMsg(UserWorldId,"发送成功", 10, "系统提示")
  end

end