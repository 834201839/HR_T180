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

-----------------身份表

if exists(select * from sys.tables where name='Roleinfo')
drop table Roleinfo
create table Roleinfo(     
ID uniqueidentifier primary key,  --身份编号
Rolename varchar(60) not null,		--身份名称
ParentRole uniqueidentifier foreign key references Roleinfo(ID) --上级身份编号
)
go
-----------------部门表
if exists(select * from sys.tables where name='Departments')
drop table Departments
create table Departments(
ID uniqueidentifier primary key, --部门编号
DJianCheng varchar(20),			--简称
Dname varchar(40) not null,		--部门全程
ParentDepartment uniqueidentifier foreign key references Departments(ID) null,  --上级部门
Address varchar(70) not null,			--地址
Dinfo nvarchar(300),					--简介
DBeiZhu nvarchar(300)					--备注
)
go
----------------用户表
if exists(select * from sys.tables where name='Users')
drop table Users
create table Users(     --用户表
ID uniqueidentifier primary key,  --用户编号
Username varchar(60) not null,		--用户名称
PassWord varchar(20) not null,		--登入密码
RID uniqueidentifier  foreign key references Roleinfo(ID) not null,	--身份编号
Phone varchar(15) not null,		--电话
DID uniqueidentifier foreign key references Departments(ID) not null, --部门编号
)
go

------------------权限表
if exists (select * from sys.tables where name='QuanXian')
drop table QuanXian
create table QuanXian
(
ID uniqueidentifier primary key,					--权限编号
OpenHtml varchar(30) not null						--打开页面
)
go
--------------身份权限表
if exists(select * from sys.tables where name='UserRole')
drop table UserRole
create table UserRole
(
RID uniqueidentifier  foreign key references Roleinfo(ID) not null,	--身份编号
QID uniqueidentifier  foreign key references QuanXian(ID) not null,	--权限编号

)
go
---------------职位分类表
if exists(select * from sys.tables where name='ZhiWeiFenLei')
drop table ZhiWeiFenLei			
create table ZhiWeiFenLei
(
ID uniqueidentifier primary key,		--职位分类编号
ZWFLName varchar(60) not null			--职位分类名称
)
go


---------------职位表
if exists(select * from sys.tables where name='ZhiWei')
drop table ZhiWei
create table ZhiWei
(
ID uniqueidentifier primary key,		--职位编号
ZName varchar(50) not null,				--职位名称
ZWFLID uniqueidentifier foreign key references ZhiWeiFenLei(ID),	--所属职位分类
DID uniqueidentifier foreign key references Departments(ID),		--所属部门编号
Zinfo varchar(80),												--职位介绍	
Comment varchar(100)								--职位备注
)
go
---------------试题类型表
if exists(select * from sys.tables where name='ShiTiLei')
drop table ShiTiLei
create table ShiTiLei
(
ID uniqueidentifier primary key,			--试题类型编号
SName varchar(30) not null					--试题类型名称
)
go


---------------试题表
if exists(select * from sys.tables where name='ShiTi')
drop table ShiTi
create table ShiTi
(
ID uniqueidentifier primary key,		--试题编号
STLID uniqueidentifier foreign key references ShiTiLei(ID),	--试题类型
Level varchar(2) not null,				--试题等级
ChuTiShiJian datetime not null,			--出题时间
ChutiRenRong varchar(50) not null,		--出题内容
UID	uniqueidentifier foreign key references Users(ID),
Sinfo varchar(200) not null				--备注
)
go
--------------薪酬项目表
if exists(select * from sys.tables where name='XinChouXiangMu')
drop table XinChouXiangMu
create table XinChouXiangMu
(
ID uniqueidentifier primary key,		--薪酬项目编号
XMName varchar(40) not null				--薪酬项目名称
)
go

--------------薪酬标准表
if exists(select * from sys.tables where name='XinChou')
drop table XinChou
create table XinChou
(
ID uniqueidentifier primary key,		--薪酬标准编号
SumPrice int not null,					--总金额
Name varchar(200) not null,				--薪酬标准名称
ZhiDingRen uniqueidentifier foreign key references Users(ID),		--制定人
DengJiRen uniqueidentifier foreign key references Users(ID),		--登记人
DengJiDate datetime default(getdate()) not null, 			--登记时间
State int not null,                           --当前状态
)
go
--------------薪酬标准明细表
if exists(select * from sys.tables where name='XinChouDetail')
drop table XinChouDetail
create table XinChouDetail
(
XCID uniqueidentifier foreign key references XinChou(ID),		--薪酬编号
XMID uniqueidentifier foreign key references XinChouXiangMu(ID),--薪酬项目编号
Price int not null						--金额
)
go


--------------培训反馈表
if exists(select * from sys.tables where name='FanKui')
drop table FanKui
create table FanKui
(
ID uniqueidentifier primary key,		--反馈编号
Level int not null,						--反馈效果
ZongJie varchar(200) not null,			--反馈总结
JieGuo varchar(200) not null			--反馈结果
)
go

--------------培训计划表
if exists(select * from sys.tables where name='PeiXunJiHua')
drop table PeiXunJiHua
create table PeiXunJiHua
(
ID uniqueidentifier primary key,		--培训计划编号
PXName varchar(30) not null,			--培训计划名称
Teacher varchar(60) not null,			--讲师
StartDate datetime not null,			--开始时间
EndDate datetime not null,				--结束时间
CanXuanRen nvarchar(30) not null,			--参训人
Pinfo nvarchar(200) ,					--简介
Opinion nvarchar(200),					--审核意见
State int,                           --当前状态
FKID uniqueidentifier foreign key references FanKui(ID),
)
go

--------------职位发布表
if exists(select * from sys.tables where name='ZhiWeiFaBu')
drop table ZhiWeiFaBu
create table ZhiWeiFaBu
(
ID uniqueidentifier primary key,		--职位发布编号
DID uniqueidentifier foreign key references Departments(ID),    --部门编号
ZID uniqueidentifier foreign key references ZhiWei(ID),			--职位编号
DengJiRen uniqueidentifier foreign key references Users(ID),	--登记人
Number  int not null,					--招聘人数
DengJiDate datetime not null,			--登记时间
EndDate datetime not null,				--结束时间
MiaoShu varchar(200) not null,			--职位描述
YaoQiu varchar(200) not null			--招聘要求
)
go
--------------面试表
if exists(select * from sys.tables where name='MianShi')
drop table MianShi
create table MianShi
(
ID uniqueidentifier primary key,		--编号
YiUID uniqueidentifier  foreign key references Users(ID) not null,	--一面人编号
YiDate datetime not null,		--一面时间
YiComment varchar(200) not null,	--一面评论
ErUID uniqueidentifier  foreign key references Users(ID) not null,	--二面人编号
ErDate datetime not null,		--二面时间
ErComment varchar(200) not null,	--二面评论
SanUID uniqueidentifier  foreign key references Users(ID) not null,	--二面人编号
SanDate datetime not null,		--二面时间
SanComment varchar(200) not null,	--二面评论
)
go
--------------简历表
if exists(select * from sys.tables where name='JianLi')
drop table JianLi
create table JianLi
(
ID uniqueidentifier primary key,		--简历编号
ZWID uniqueidentifier foreign key references ZhiWei(ID),	--缺少职位编号
JName varchar(30) not null,					--名字
Sex char(2) not null,						--性别
ZhaoPingLeiXing varchar(50) not null,		--招聘类型
Email varchar(30) not null,					--邮箱
Phone varchar(20) not null,					--手机号
SuoZaiDi varchar(30) not null,				--所在地户口
Address varchar(200) not null,				--地址
MianMao varchar(20) not null,				--描述
ShenFenZheng varchar(20) not null,			--身份证
BiYe varchar(40) not null,					--毕业院校
XueLi varchar(20) not null,					--学历
ZhuanYe varchar(30) not null,				--专业
JingYan varchar(10) not null,				--工作经验
XinZiYaoQiu varchar(200) not null,			--薪资要求
ShiFouZaiZhi bit not null,					--是否在职
YingJieSheng bit not null,					--是否是应届生
DengJiDate datetime not null,				--登记时间
LVLi varchar(200) not null,					--个人履历
MID uniqueidentifier foreign key references MianShi(ID),	--面试编号
State int not null							--当前状态
)
go

-----------------------档案状态表
if exists(select * from sys.tables where name='DangAnState')
drop table DangAnState
create table DangAnState
(
ID uniqueidentifier primary key,		--档案状态编号
Name varchar(200) not null				--档案名称
)

-----------------------人事档案表
if exists(select * from sys.tables where name='DangAn')
drop table DangAn
create table DangAn
(
ID uniqueidentifier primary key,		--人事档案编号
DangAnZhuangTai uniqueidentifier foreign key references DangAnState(ID),  --档案状态编号
ZWID uniqueidentifier foreign key references ZhiWei(ID),	--所属职位编号
ImgPath varchar(200) not null,				--图片路径
Name varchar(30) not null,					--姓名		
Sex char(2) not null,						--性别
Email varchar(30) not null,					--邮箱
Phone varchar(20) not null,					--手机号
SuoZaiDi varchar(30) not null,				--所在地户口
Address varchar(200) not null,				--地址
MianMao varchar(20) not null,				--描述
ShenFenZheng varchar(20) not null,			--身份证
BiYe varchar(40) not null,					--毕业院校
XueLi varchar(20) not null,					--学历
ZhuanYe varchar(30) not null,				--专业
XID uniqueidentifier foreign key references XinChou(ID),		--薪酬标准编号
YinHang varchar(30) not null,				--银行						
YinHangKaHao varchar(30) not null,			--银行卡号
SheBaoKaHao varchar(50) not null,			--社保卡号
JianDangDate datetime not null,				--建档时间
LVLi varchar(200) not null,					--个人履历
DengJiRen uniqueidentifier foreign key references Users(ID),			--登记人
JiaTingXinXi varchar(40) not null,			--家庭信息
BeiZhu	varchar(80),							--备注
State int                           --当前状态
)
go

-------------------审批人编号
if exists(select * from sys.tables where name='ShenHeRen')
drop table ShenHeRen
create table ShenHeRen
(
ID int identity(1,1) not null,			--审核编号
TiJiaoRen uniqueidentifier foreign key references Users(ID),	--提交人编号
ShenHeYiJian varchar(20) not null,		--审核意见
ShenHeRen uniqueidentifier foreign key references Users(ID)		--审核人
)

-------------------审核表
if exists(select * from sys.tables where name='ShenHe')
drop table ShenHe
create table ShenHe
(
ID int identity(1,1) not null,			--审核编号
TiJiaoRen uniqueidentifier foreign key references Users(ID),	--提交人编号
Type int not null	--审核类型
)
