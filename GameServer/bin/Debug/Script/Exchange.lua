--ExchangeΪ����Ʒ�Ĵ��������������������Ը���
--ItmeId  ��ƷID
--site	  ��Ʒ�ڰ����е�λ��
--number  ��Ʒ����
--GetPakItmesx ȡ�ñ���������Ʒ 
--GetPakItmesx(UserWorldId,999000020,����1,����2,����3,����4,����5, int ����, int ����, int �м�����)
--GetPakItme ȡ�ñ�����ͨ��Ʒ
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
		SendSysMsg(UserWorldId,"�����ϻ���Ҫ�� ", 9, "ϵͳ��ʾ")
		return 
	end
UpUseItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,500,1)
SendSysMsg(UserWorldId,"��ϲ����500Ԫ��", 9, "ϵͳ��ʾ")
end