--�Զ���һ���Ʒ
--GetPakItmesx(UserWorldId,��ƷID, ����1, ����2, ����3,����4, ����5,����, ����, �м�����)
--AddItmeProp(UserWorldId,��ƷID,weizs[0],1,1010001910,70000050,70000050,70000050,70000050,5,0,2,0)
function ExchangeItem(UserWorldId,str1)
  if str1== "!�һ��ײ�" then
     local weiz1=GetPakItmesx(UserWorldId,900000001,10,1,1,1,1,1,1,1)
	if weiz1==-1 then 
		SendSysMsg(UserWorldId,"�������������", 10, "ϵͳ��ʾ")
		return 
	end
     	local weizs=GetPackages(UserWorldId,2)
	if weizs.Count< 2 then 
		SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
		return 
	end
        local yb=GetRxpiont(UserWorldId)
        if yb < 1000 then
               SendSysMsg(UserWorldId,"�һ���Ҫ������1000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
	       return 
	end
        DelItme(UserWorldId,weiz1,1)
        SetPlayerRxpiont(UserWorldId,10,0)
	AddItmeProp(UserWorldId,11,weizs[0],1,1010001910,70000050,70000050,70000050,70000050,5,0,2,0)
        SendSysMsg(UserWorldId,"���ͳɹ�", 10, "ϵͳ��ʾ")
  end

end