
select * from Roleinfo


------------------------------------�������
insert Roleinfo
values(NEWID(),'�쵼',null)
insert Roleinfo
values(NEWID(),'������Դ������', (select id from Roleinfo where Rolename='�쵼'))
insert Roleinfo
values(NEWID(),'���¾���', (select id from Roleinfo where Rolename='������Դ������'))
insert Roleinfo
values(NEWID(),'����רԱ', (select id from Roleinfo where Rolename='���¾���'))
insert Roleinfo
values(NEWID(),'н�꾭��', (select id from Roleinfo where Rolename='������Դ������'))
insert Roleinfo
values(NEWID(),'н��רԱ', (select id from Roleinfo where Rolename='н�꾭��'))
insert Roleinfo
values(NEWID(),'ϵͳ����Ա',null)

-------------------------------------���벿��
select ParentDepartment,count(*) from departments  group by ParentDepartment,dname
select * from departments
insert Departments
values(NEWID(),'ZCB','�ܲð�',null,'�����г������Ƽ���¥','�����ܲð���','�ܲð챸ע')
insert Departments
values(NEWID(),'������','������Դ��������',(select ID from Departments where Dname='�ܲð�'),'�����г������Ƽ���¥','������Դ�������ļ��','������Դ�������ı�ע')
insert Departments
values(NEWID(),'��Ʒչ','������Ʒ��չ��',(select ID from Departments where Dname='�ܲð�'),'�����и�����78��','������Ʒ��չ�����','������Ʒ��չ����ע')
insert Departments
values(NEWID(),'����һ','�����г���չһ��',(select ID from Departments where Dname='������Ʒ��չ��'),'�����и�����78��','�����г���չһ�����','�����г���չһ����ע')
insert Departments
values(NEWID(),'���ж�','�����г���չ����',(select ID from Departments where Dname='������Ʒ��չ��'),'�����и�����78��','�����г���չ�������','�����г���չ������ע')
insert Departments
values(NEWID(),'������','�����г���չ����',(select ID from Departments where Dname='������Ʒ��չ��'),'�����и�����78��','�����г���չ�������','�����г���չ������ע')

insert Departments
values(NEWID(),'ְ��Ժ','ְҵ�����о�Ժ',(select ID from Departments where Dname='�ܲð�'),'������������15¥','ְҵ�����о�Ժ���','�ܲð챸ע')
insert Departments
values(NEWID(),'����','��Ʒ����',(select ID from Departments where Dname='ְҵ�����о�Ժ'),'������������16¥','��Ʒ�������','��Ʒ������ע')
insert Departments
values(NEWID(),'����','��������',(select ID from Departments where Dname='ְҵ�����о�Ժ'),'������������17¥','�����������','����������ע')
insert Departments
values(NEWID(),'��Ʒ���','��Ʒ�������',(select ID from Departments where Dname='ְҵ�����о�Ժ'),'������������18¥','��Ʒ������ļ��','��Ʒ������ı�ע')
insert Departments
values(NEWID(),'ƽ̨�з�','ƽ̨�з�����',(select ID from Departments where Dname='ְҵ�����о�Ժ'),'������������19¥','��Ʒ������ļ��','��Ʒ������ı�ע')

------------------------------�����û�

select * from Users order by RID

insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'Boss','123456',(select id from Roleinfo where Rolename='�쵼'),18531090663,(select ID from Departments where Dname='�ܲð�'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'Ǯ���','123456',(select id from Roleinfo where Rolename='������Դ������'),17731090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'����','123456',(select id from Roleinfo where Rolename='���¾���'),16331090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'���Ӻ�','123456',(select id from Roleinfo where Rolename='����רԱ'),15631090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'������','123456',(select id from Roleinfo where Rolename='����רԱ'),17831090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'����','123456',(select id from Roleinfo where Rolename='н�꾭��'),18531090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'�ſ���','123456',(select id from Roleinfo where Rolename='н��רԱ'),15631090663,(select ID from Departments where Dname='������Դ��������'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'����','123456',(select id from Roleinfo where Rolename='н��רԱ'),17831090663,(select ID from Departments where Dname='������Դ��������'))




-------------------------------����Ȩ�ޱ�




-------------------------------�������Ȩ�ޱ�





-------------------------------ְλ�����
insert ZhiWeiFenLei
values(newid(),'����')
insert ZhiWeiFenLei
values(newid(),'����')
insert ZhiWeiFenLei
values(newid(),'����')
insert ZhiWeiFenLei
values(newid(),'ʵʩ')
insert ZhiWeiFenLei
values(newid(),'��ǰ')
insert ZhiWeiFenLei
values(newid(),'����')
insert ZhiWeiFenLei
values(newid(),'����')


------------------------------����ְλ��
insert ZhiWei
values(newid(),'������ѵʦ',(select id from ZhiWeiFenLei where ZWFLName='����'),(select ID from Departments where Dname='��Ʒ�������'),'������ѵ����������ҵ������','�������е�')

insert ZhiWei
values(newid(),'�������ʦ',(select id from ZhiWeiFenLei where ZWFLName='����'),(select ID from Departments where Dname='ƽ̨�з�����'),'�����������������ƽ̨����','Ů�����')

insert ZhiWei
values(newid(),'�����ܼ�',(select id from ZhiWeiFenLei where ZWFLName='����'),(select ID from Departments where Dname='ƽ̨�з�����'),'������Ŀ�����Լ�������������','�������������')

insert ZhiWei
values(newid(),'��Ŀ����Ա',(select id from ZhiWeiFenLei where ZWFLName='����'),(select ID from Departments where Dname='��������'),'��BUG����Ŀ©��','û�����')


-----------------------------������������

insert ShiTiLei
values(newid(),'java����')

insert ShiTiLei
values(newid(),'c#����')

insert ShiTiLei
values(newid(),'C++����')

insert ShiTiLei
values(newid(),'PHP����')

----------------------------�����
select * from ShiTi

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='java����'),'A','2013.5.5','1����������������������..............',(select id from Users where Username='����'),'��������������ӦƸ�߼���������ߣ�����100�֣�80�ֿɽ�����档������')

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='c#����'),'B','2013.9.5','winfrom ��������Ĺ���..............',(select id from Users where Username='����'),'��������������ӦƸ�м�����������ߣ�����100�֣�70�ֿɽ�����档������')

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='PHP����'),'C','2013.9.5','PHP��ҳ����..............',(select id from Users where Username='������'),'��������������WEB�����ߣ�����100�֣�60�ֿɽ�����档������')


----------------------------н����Ŀ��
select * from XinChouXiangMu

insert XinChouXiangMu
values(newid(),'��������')
insert XinChouXiangMu
values(newid(),'��Ч����')
insert XinChouXiangMu
values(newid(),'��ͨ����')
insert XinChouXiangMu
values(newid(),'ͨѶ����')
insert XinChouXiangMu
values(newid(),'�Ͳ�')
insert XinChouXiangMu
values(newid(),'ס������')
insert XinChouXiangMu
values(newid(),'�����')
insert XinChouXiangMu
values(newid(),'�Ӱಹ��')


----------------------------н���׼��
select * from xinchou

insert XinChou
values (newid(),7000,'�м��������ʦ',(select id from Users where Username='����'),(select id from Users where Username='����'),default,2)
insert XinChou
values (newid(),5000,'�����������ʦ',(select id from Users where Username='����'),(select id from Users where Username='����'),default,2)
insert XinChou
values (newid(),10000,'�߼��������ʦ',(select id from Users where Username='����'),(select id from Users where Username='����'),default,2)


---------------------------н���׼��ϸ��

select * from XinChouDetail

insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='��������'),2500)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='��Ч����'),500)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='��ͨ����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='ͨѶ����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='�Ͳ�'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='ס������'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='�����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�����������ʦ'),(select id from XinChouXiangMu where XMName='�Ӱಹ��'),1000)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='��������'),4500)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='��Ч����'),500)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='��ͨ����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='ͨѶ����'),50)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='�Ͳ�'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='ס������'),350)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='�����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�м��������ʦ'),(select id from XinChouXiangMu where XMName='�Ӱಹ��'),1000)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='��������'),6500)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='��Ч����'),1500)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='��ͨ����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='ͨѶ����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='�Ͳ�'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='ס������'),100)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='�����'),200)
insert XinChouDetail
values ((select id from XinChou where Name='�߼��������ʦ'),(select id from XinChouXiangMu where XMName='�Ӱಹ��'),1100)



--------------------------------������ѵ������
select * from fankui
insert FanKui
values (newid(),1,'�ǳ�����','���˽��.........')

------------------------------������ѵ�ƻ���
select * from PeiXunJiHua
insert PeiXunJiHua
values(newid(),'����ר�Һͽ�ѧר�ҵĺ���','���','2018-09-9','2018-09-12','������ ������ ���Ρ� ������ ������ ����','����ר�Һͽ�ѧר�Һ�������������γ̵ķ����������������̡���λְ���빵ͨ��ʽ��',null,0,null)

insert PeiXunJiHua
values(newid(),'�˹����ܵ�δ����չ�滮','��˹��','2017-10-19','2018-09-12','������ ������ ���Ρ� ������ ������ ����','�˹����ܶ�δ���ķ�չӰ�죬�Լ�����Ӧ��','Ч���ǳ���',0,(select top 1 id from FanKui))


-----------------------------����ְλ������
select * from ZhiWeiFaBu

insert ZhiWeiFaBu
values(newid(),(select ID from Departments where Dname='��Ʒ�������'),(select ID from ZhiWei where Zname='�������ʦ'),(select id from Users where Username='���Ӻ�'),3,'2018.5.5','2018.6.6','1������ָ��java��Ʒ���������з�java������Ʒ��
2��Ϊjava��Ʒ�ṩר�Ҽ��ļ���֧�֡�','����Ҫ��
1������5�����ϴ���B/S�ܹ�����������顣
2����ͨSSH����2�����ϵ�ʹ�þ���֡�
3�����پ���һ���������ݿ�ϵͳ�ķ�϶ʹ�þ��飬��ͨsql����Ϥ�����������Ż�������
4��������
5.������')


--------------------------�������Ա�
select * from MianShi

insert MianShi
values(NEWID(),(select id from Users where Username='���Ӻ�'),'2017.5.5','�Ƽ�����',(select id from Users where Username='������'),'2017.6.5','�Ƽ�����',(select id from Users where Username='���Ӻ�'),'2017.7.5','�Ƽ�¼��')
--------------------------���������

select * from jianli

insert jianli
values(newid(),(select ID from ZhiWei where Zname='�������ʦ'),'��ѩ','Ů','У԰��Ƹ','123456@163.com','18134090635','����','˳����','�Ը��ºͣ���������','150981197202284550','���輼��ѧԺ','��У','�ھ��','2��','8000',0,0,getdate(),'2006-2008�� ��ְ��***��˾��ְλ���м������������ʦ',null,0)

insert jianli
values(newid(),(select ID from ZhiWei where Zname='�������ʦ'),'�ŷ�','��','�����Ƹ','123456@163.com','18134090635','�ӱ�','������','�����߳����Ա�°�','164665097202284550','����ѧԺ','��ר','��ʦ','2��','9000',0,0,getdate(),'2006-2008�� ��ְ���¶�����ְλ����ʦ��',(select top 1 id from MianShi),0)


------------------------���뵵��״̬

select * from DangAnState

insert DangAnState
values (NEWID(),'������')
insert DangAnState
values (NEWID(),'��ʽԱ��')
insert DangAnState
values (NEWID(),'��ְ')
insert DangAnState
values (NEWID(),'ʵϰԱ��')

------------------------���뵵����
select * from DangAn

insert DangAn
values(newid(),(select ID from DangAnState where Name='������'),(select ID from ZhiWei where Zname='�������ʦ'),'d://ͼƬ','��С��','��','123456@163.com','18134090635','�ӱ�','������','������С��������','164665097202284550','����ѧԺ','��ר','���������',(select id from XinChou where Name='�м��������ʦ'),'�й�����','xxxxxxxxxxxxxx','sssssssssssss',GETDATE(),'������С���ĸ�������',(select id from Users where Username='���Ӻ�'),'�ǳ�����','������С���ı�ע',0)

insert DangAn
values(NEWID(),(select ID from DangAnState where Name='��ʽԱ��'),(select ID from ZhiWei where Zname='������ѵʦ'),'d://ͼƬ','������','��','789456@qq.com','13633108164','����','������','����������������','133238612348642348','�ӱ�ְ��','��ѧ','������ѵ',(select id from XinChou where Name='�߼��������ʦ'),'��������','xxxxxxxxxxxxxx','sssssssssssss',getdate(),'�����������ĸ�������',(select id from Users where Username='���Ӻ�'),'�����������ļ��','�����������ı�ע',0)