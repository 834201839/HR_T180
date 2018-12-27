--use master
--go

--drop database HumanManagement

create database HumanManagement
on primary(
	name='HumanManagement',
  filename='D:\ShuJuKu\HumanManagement.mdf'
)
go

use HumanManagement
go

-----------------��ݱ�

if exists(select * from sys.tables where name='Roleinfo')
drop table Roleinfo
create table Roleinfo(     
ID uniqueidentifier primary key,  --��ݱ��
Rolename varchar(60) not null,		--�������
ParentRole uniqueidentifier foreign key references Roleinfo(ID) --�ϼ���ݱ��
)
go
-----------------���ű�
if exists(select * from sys.tables where name='Departments')
drop table Departments
create table Departments(
ID uniqueidentifier primary key, --���ű��
DJianCheng varchar(20),			--���
Dname varchar(40) not null,		--����ȫ��
ParentDepartment uniqueidentifier foreign key references Departments(ID) null,  --�ϼ�����
Address varchar(70) not null,			--��ַ
Dinfo nvarchar(300),					--���
DBeiZhu nvarchar(300)					--��ע
)
go
----------------�û���
if exists(select * from sys.tables where name='Users')
drop table Users
create table Users(     --�û���
ID uniqueidentifier primary key,  --�û����
Username varchar(60) not null,		--�û�����
PassWord varchar(20) not null,		--��������
RID uniqueidentifier  foreign key references Roleinfo(ID) not null,	--��ݱ��
Phone varchar(15) not null,		--�绰
DID uniqueidentifier foreign key references Departments(ID) not null, --���ű��
)
go

------------------Ȩ�ޱ�
if exists (select * from sys.tables where name='QuanXian')
drop table QuanXian
create table QuanXian
(
ID uniqueidentifier primary key,					--Ȩ�ޱ��
OpenHtml varchar(30) not null						--��ҳ��
)
go
--------------���Ȩ�ޱ�
if exists(select * from sys.tables where name='UserRole')
drop table UserRole
create table UserRole
(
RID uniqueidentifier  foreign key references Roleinfo(ID) not null,	--��ݱ��
QID uniqueidentifier  foreign key references QuanXian(ID) not null,	--Ȩ�ޱ��

)
go
---------------ְλ�����
if exists(select * from sys.tables where name='ZhiWeiFenLei')
drop table ZhiWeiFenLei			
create table ZhiWeiFenLei
(
ID uniqueidentifier primary key,		--ְλ������
ZWFLName varchar(60) not null			--ְλ��������
)
go


---------------ְλ��
if exists(select * from sys.tables where name='ZhiWei')
drop table ZhiWei
create table ZhiWei
(
ID uniqueidentifier primary key,		--ְλ���
ZName varchar(50) not null,				--ְλ����
ZWFLID uniqueidentifier foreign key references ZhiWeiFenLei(ID),	--����ְλ����
DID uniqueidentifier foreign key references Departments(ID),		--�������ű��
Zinfo varchar(80),												--ְλ����	
Comment varchar(100)								--ְλ��ע
)
go
---------------�������ͱ�
if exists(select * from sys.tables where name='ShiTiLei')
drop table ShiTiLei
create table ShiTiLei
(
ID uniqueidentifier primary key,			--�������ͱ��
SName varchar(30) not null					--������������
)
go


---------------�����
if exists(select * from sys.tables where name='ShiTi')
drop table ShiTi
create table ShiTi
(
ID uniqueidentifier primary key,		--������
STLID uniqueidentifier foreign key references ShiTiLei(ID),	--��������
Level varchar(2) not null,				--����ȼ�
ChuTiShiJian datetime not null,			--����ʱ��
ChutiRenRong varchar(50) not null,		--��������
UID	uniqueidentifier foreign key references Users(ID),
Sinfo varchar(200) not null				--��ע
)
go
--------------н����Ŀ��
if exists(select * from sys.tables where name='XinChouXiangMu')
drop table XinChouXiangMu
create table XinChouXiangMu
(
ID uniqueidentifier primary key,		--н����Ŀ���
XMName varchar(40) not null				--н����Ŀ����
)
go

--------------н���׼��
if exists(select * from sys.tables where name='XinChou')
drop table XinChou
create table XinChou
(
ID uniqueidentifier primary key,		--н���׼���
SumPrice int not null,					--�ܽ��
Name varchar(200) not null,				--н���׼����
ZhiDingRen uniqueidentifier foreign key references Users(ID),		--�ƶ���
DengJiRen uniqueidentifier foreign key references Users(ID),		--�Ǽ���
DengJiDate datetime default(getdate()) not null, 			--�Ǽ�ʱ��
State int not null,                           --��ǰ״̬
)
go
--------------н���׼��ϸ��
if exists(select * from sys.tables where name='XinChouDetail')
drop table XinChouDetail
create table XinChouDetail
(
XCID uniqueidentifier foreign key references XinChou(ID),		--н����
XMID uniqueidentifier foreign key references XinChouXiangMu(ID),--н����Ŀ���
Price int not null						--���
)
go


--------------��ѵ������
if exists(select * from sys.tables where name='FanKui')
drop table FanKui
create table FanKui
(
ID uniqueidentifier primary key,		--�������
Level int not null,						--����Ч��
ZongJie varchar(200) not null,			--�����ܽ�
JieGuo varchar(200) not null			--�������
)
go

--------------��ѵ�ƻ���
if exists(select * from sys.tables where name='PeiXunJiHua')
drop table PeiXunJiHua
create table PeiXunJiHua
(
ID uniqueidentifier primary key,		--��ѵ�ƻ����
PXName varchar(30) not null,			--��ѵ�ƻ�����
Teacher varchar(60) not null,			--��ʦ
StartDate datetime not null,			--��ʼʱ��
EndDate datetime not null,				--����ʱ��
CanXuanRen nvarchar(30) not null,			--��ѵ��
Pinfo nvarchar(200) ,					--���
Opinion nvarchar(200),					--������
State int,                           --��ǰ״̬
FKID uniqueidentifier foreign key references FanKui(ID),
)
go

--------------ְλ������
if exists(select * from sys.tables where name='ZhiWeiFaBu')
drop table ZhiWeiFaBu
create table ZhiWeiFaBu
(
ID uniqueidentifier primary key,		--ְλ�������
DID uniqueidentifier foreign key references Departments(ID),    --���ű��
ZID uniqueidentifier foreign key references ZhiWei(ID),			--ְλ���
DengJiRen uniqueidentifier foreign key references Users(ID),	--�Ǽ���
Number  int not null,					--��Ƹ����
DengJiDate datetime not null,			--�Ǽ�ʱ��
EndDate datetime not null,				--����ʱ��
MiaoShu varchar(200) not null,			--ְλ����
YaoQiu varchar(200) not null			--��ƸҪ��
)
go
--------------���Ա�
if exists(select * from sys.tables where name='MianShi')
drop table MianShi
create table MianShi
(
ID uniqueidentifier primary key,		--���
YiUID uniqueidentifier  foreign key references Users(ID) not null,	--һ���˱��
YiDate datetime not null,		--һ��ʱ��
YiComment varchar(200) not null,	--һ������
ErUID uniqueidentifier  foreign key references Users(ID) not null,	--�����˱��
ErDate datetime not null,		--����ʱ��
ErComment varchar(200) not null,	--��������
SanUID uniqueidentifier  foreign key references Users(ID) not null,	--�����˱��
SanDate datetime not null,		--����ʱ��
SanComment varchar(200) not null,	--��������
)
go
--------------������
if exists(select * from sys.tables where name='JianLi')
drop table JianLi
create table JianLi
(
ID uniqueidentifier primary key,		--�������
ZWID uniqueidentifier foreign key references ZhiWei(ID),	--ȱ��ְλ���
JName varchar(30) not null,					--����
Sex char(2) not null,						--�Ա�
ZhaoPingLeiXing varchar(50) not null,		--��Ƹ����
Email varchar(30) not null,					--����
Phone varchar(20) not null,					--�ֻ���
SuoZaiDi varchar(30) not null,				--���ڵػ���
Address varchar(200) not null,				--��ַ
MianMao varchar(20) not null,				--����
ShenFenZheng varchar(20) not null,			--���֤
BiYe varchar(40) not null,					--��ҵԺУ
XueLi varchar(20) not null,					--ѧ��
ZhuanYe varchar(30) not null,				--רҵ
JingYan varchar(10) not null,				--��������
XinZiYaoQiu varchar(200) not null,			--н��Ҫ��
ShiFouZaiZhi bit not null,					--�Ƿ���ְ
YingJieSheng bit not null,					--�Ƿ���Ӧ����
DengJiDate datetime not null,				--�Ǽ�ʱ��
LVLi varchar(200) not null,					--��������
MID uniqueidentifier foreign key references MianShi(ID),	--���Ա��
State int not null							--��ǰ״̬
)
go

-----------------------����״̬��
if exists(select * from sys.tables where name='DangAnState')
drop table DangAnState
create table DangAnState
(
ID uniqueidentifier primary key,		--����״̬���
Name varchar(200) not null				--��������
)

-----------------------���µ�����
if exists(select * from sys.tables where name='DangAn')
drop table DangAn
create table DangAn
(
ID uniqueidentifier primary key,		--���µ������
DangAnZhuangTai uniqueidentifier foreign key references DangAnState(ID),  --����״̬���
ZWID uniqueidentifier foreign key references ZhiWei(ID),	--����ְλ���
ImgPath varchar(200) not null,				--ͼƬ·��
Name varchar(30) not null,					--����		
Sex char(2) not null,						--�Ա�
Email varchar(30) not null,					--����
Phone varchar(20) not null,					--�ֻ���
SuoZaiDi varchar(30) not null,				--���ڵػ���
Address varchar(200) not null,				--��ַ
MianMao varchar(20) not null,				--����
ShenFenZheng varchar(20) not null,			--���֤
BiYe varchar(40) not null,					--��ҵԺУ
XueLi varchar(20) not null,					--ѧ��
ZhuanYe varchar(30) not null,				--רҵ
XID uniqueidentifier foreign key references XinChou(ID),		--н���׼���
YinHang varchar(30) not null,				--����						
YinHangKaHao varchar(30) not null,			--���п���
SheBaoKaHao varchar(50) not null,			--�籣����
JianDangDate datetime not null,				--����ʱ��
LVLi varchar(200) not null,					--��������
DengJiRen uniqueidentifier foreign key references Users(ID),			--�Ǽ���
JiaTingXinXi varchar(40) not null,			--��ͥ��Ϣ
BeiZhu	varchar(80),							--��ע
State int                           --��ǰ״̬
)
go

-------------------�����˱��
if exists(select * from sys.tables where name='ShenHeRen')
drop table ShenHeRen
create table ShenHeRen
(
ID int identity(1,1) not null,			--��˱��
TiJiaoRen uniqueidentifier foreign key references Users(ID),	--�ύ�˱��
ShenHeYiJian varchar(20) not null,		--������
ShenHeRen uniqueidentifier foreign key references Users(ID)		--�����
)

-------------------��˱�
if exists(select * from sys.tables where name='ShenHe')
drop table ShenHe
create table ShenHe
(
ID int identity(1,1) not null,			--��˱��
TiJiaoRen uniqueidentifier foreign key references Users(ID),	--�ύ�˱��
Type int not null	--�������
)
