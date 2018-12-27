
select * from Roleinfo


------------------------------------插入身份
insert Roleinfo
values(NEWID(),'领导',null)
insert Roleinfo
values(NEWID(),'人力资源负责人', (select id from Roleinfo where Rolename='领导'))
insert Roleinfo
values(NEWID(),'人事经理', (select id from Roleinfo where Rolename='人力资源负责人'))
insert Roleinfo
values(NEWID(),'人事专员', (select id from Roleinfo where Rolename='人事经理'))
insert Roleinfo
values(NEWID(),'薪酬经理', (select id from Roleinfo where Rolename='人力资源负责人'))
insert Roleinfo
values(NEWID(),'薪酬专员', (select id from Roleinfo where Rolename='薪酬经理'))
insert Roleinfo
values(NEWID(),'系统管理员',null)

-------------------------------------插入部门
select ParentDepartment,count(*) from departments  group by ParentDepartment,dname
select * from departments
insert Departments
values(NEWID(),'ZCB','总裁办',null,'北京市朝阳区科技大楼','这是总裁办简介','总裁办备注')
insert Departments
values(NEWID(),'人自立','人力资源管理中心',(select ID from Departments where Dname='总裁办'),'北京市朝阳区科技大楼','人力资源管理中心简介','人力资源管理中心备注')
insert Departments
values(NEWID(),'教品展','教育产品发展部',(select ID from Departments where Dname='总裁办'),'北京市抚河县78号','教育产品发展部简介','教育产品发展部备注')
insert Departments
values(NEWID(),'区市一','区域市场发展一部',(select ID from Departments where Dname='教育产品发展部'),'北京市抚河县78号','区域市场发展一部简介','区域市场发展一部备注')
insert Departments
values(NEWID(),'区市二','区域市场发展二部',(select ID from Departments where Dname='教育产品发展部'),'北京市抚河县78号','区域市场发展二部简介','区域市场发展二部备注')
insert Departments
values(NEWID(),'区市三','区域市场发展三部',(select ID from Departments where Dname='教育产品发展部'),'北京市抚河县78号','区域市场发展三部简介','区域市场发展三部备注')

insert Departments
values(NEWID(),'职教院','职业教育研究院',(select ID from Departments where Dname='总裁办'),'北京市流星区15楼','职业教育研究院简介','总裁办备注')
insert Departments
values(NEWID(),'产理','产品管理部',(select ID from Departments where Dname='职业教育研究院'),'北京市流星区16楼','产品管理部简介','产品管理部备注')
insert Departments
values(NEWID(),'质理','质量管理部',(select ID from Departments where Dname='职业教育研究院'),'北京市流星区17楼','质量管理部简介','质量管理部备注')
insert Departments
values(NEWID(),'产品设计','产品设计中心',(select ID from Departments where Dname='职业教育研究院'),'北京市流星区18楼','产品设计中心简介','产品设计中心备注')
insert Departments
values(NEWID(),'平台研发','平台研发中心',(select ID from Departments where Dname='职业教育研究院'),'北京市流星区19楼','产品设计中心简介','产品设计中心备注')

------------------------------插入用户

select * from Users order by RID

insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'Boss','123456',(select id from Roleinfo where Rolename='领导'),18531090663,(select ID from Departments where Dname='总裁办'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'钱大钧','123456',(select id from Roleinfo where Rolename='人力资源负责人'),17731090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'张三','123456',(select id from Roleinfo where Rolename='人事经理'),16331090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'王子豪','123456',(select id from Roleinfo where Rolename='人事专员'),15631090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'刘海东','123456',(select id from Roleinfo where Rolename='人事专员'),17831090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'李四','123456',(select id from Roleinfo where Rolename='薪酬经理'),18531090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'张可欣','123456',(select id from Roleinfo where Rolename='薪酬专员'),15631090663,(select ID from Departments where Dname='人力资源管理中心'))
insert Users(ID, Username, PassWord, RID, Phone, DID) 
values(NEWID(),'柯震东','123456',(select id from Roleinfo where Rolename='薪酬专员'),17831090663,(select ID from Departments where Dname='人力资源管理中心'))




-------------------------------插入权限表




-------------------------------插入身份权限表





-------------------------------职位分类表
insert ZhiWeiFenLei
values(newid(),'测试')
insert ZhiWeiFenLei
values(newid(),'管理')
insert ZhiWeiFenLei
values(newid(),'技术')
insert ZhiWeiFenLei
values(newid(),'实施')
insert ZhiWeiFenLei
values(newid(),'售前')
insert ZhiWeiFenLei
values(newid(),'财务')
insert ZhiWeiFenLei
values(newid(),'行政')


------------------------------插入职位表
insert ZhiWei
values(newid(),'技术培训师',(select id from ZhiWeiFenLei where ZWFLName='技术'),(select ID from Departments where Dname='产品设计中心'),'负责培训新人能力和业务流程','必须是男的')

insert ZhiWei
values(newid(),'软件开发师',(select id from ZhiWeiFenLei where ZWFLName='技术'),(select ID from Departments where Dname='平台研发中心'),'负责软件开发和其他平台开发','女的最好')

insert ZhiWei
values(newid(),'技术总监',(select id from ZhiWeiFenLei where ZWFLName='管理'),(select ID from Departments where Dname='平台研发中心'),'负责项目建都以及其他技术问题','工作经验必须丰厚')

insert ZhiWei
values(newid(),'项目测试员',(select id from ZhiWeiFenLei where ZWFLName='测试'),(select ID from Departments where Dname='质量管理部'),'找BUG和项目漏洞','没有最好')


-----------------------------插入试题分类表

insert ShiTiLei
values(newid(),'java开发')

insert ShiTiLei
values(newid(),'c#开发')

insert ShiTiLei
values(newid(),'C++开发')

insert ShiTiLei
values(newid(),'PHP开发')

----------------------------试题表
select * from ShiTi

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='java开发'),'A','2013.5.5','1、陈述面向对象的三大特性..............',(select id from Users where Username='李四'),'此套试题适用于应聘高级软件开发者，满分100分，80分可进入二面。。。。')

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='c#开发'),'B','2013.9.5','winfrom 开发软件的功能..............',(select id from Users where Username='李四'),'此套试题适用于应聘中级级软件开发者，满分100分，70分可进入二面。。。。')

insert ShiTi
values(newid(),(select id from ShiTiLei where SName='PHP开发'),'C','2013.9.5','PHP网页开发..............',(select id from Users where Username='刘海东'),'此套试题适用于WEB开发者，满分100分，60分可进入二面。。。。')


----------------------------薪酬项目表
select * from XinChouXiangMu

insert XinChouXiangMu
values(newid(),'基本工资')
insert XinChouXiangMu
values(newid(),'绩效奖金')
insert XinChouXiangMu
values(newid(),'交通补助')
insert XinChouXiangMu
values(newid(),'通讯补助')
insert XinChouXiangMu
values(newid(),'餐补')
insert XinChouXiangMu
values(newid(),'住房补助')
insert XinChouXiangMu
values(newid(),'出差补助')
insert XinChouXiangMu
values(newid(),'加班补助')


----------------------------薪酬标准表
select * from xinchou

insert XinChou
values (newid(),7000,'中级软件工程师',(select id from Users where Username='张三'),(select id from Users where Username='张三'),default,2)
insert XinChou
values (newid(),5000,'初级软件工程师',(select id from Users where Username='张三'),(select id from Users where Username='张三'),default,2)
insert XinChou
values (newid(),10000,'高级软件工程师',(select id from Users where Username='张三'),(select id from Users where Username='张三'),default,2)


---------------------------薪酬标准明细表

select * from XinChouDetail

insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='基本工资'),2500)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='绩效奖金'),500)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='交通补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='通讯补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='餐补'),200)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='住房补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='出差补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='初级软件工程师'),(select id from XinChouXiangMu where XMName='加班补助'),1000)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='基本工资'),4500)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='绩效奖金'),500)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='交通补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='通讯补助'),50)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='餐补'),200)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='住房补助'),350)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='出差补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='中级软件工程师'),(select id from XinChouXiangMu where XMName='加班补助'),1000)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='基本工资'),6500)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='绩效奖金'),1500)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='交通补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='通讯补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='餐补'),200)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='住房补助'),100)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='出差补助'),200)
insert XinChouDetail
values ((select id from XinChou where Name='高级软件工程师'),(select id from XinChouXiangMu where XMName='加班补助'),1100)



--------------------------------插入培训反馈表
select * from fankui
insert FanKui
values (newid(),1,'非常完美','考核结果.........')

------------------------------插入培训计划表
select * from PeiXunJiHua
insert PeiXunJiHua
values(newid(),'技术专家和教学专家的合作','杨赤','2018-09-9','2018-09-12','李明、 潘贞玉、 李治、 武欣、 孙威、 韩健','技术专家和教学专家合作开发技术类课程的方法，包括开发流程、岗位职责与沟通方式。',null,0,null)

insert PeiXunJiHua
values(newid(),'人工智能的未来发展规划','刘斯大','2017-10-19','2018-09-12','李明、 潘贞玉、 李治、 武欣、 孙威、 韩健','人工智能对未来的发展影响，以及其他应用','效果非常好',0,(select top 1 id from FanKui))


-----------------------------插入职位发布表
select * from ZhiWeiFaBu

insert ZhiWeiFaBu
values(newid(),(select ID from Departments where Dname='产品设计中心'),(select ID from ZhiWei where Zname='软件开发师'),(select id from Users where Username='王子豪'),3,'2018.5.5','2018.6.6','1、负责指导java产品技术方向，研发java教育产品。
2、为java产品提供专家级的技术支持。','技能要求：
1、至少5年以上大型B/S架构软件开发经验。
2、精通SSH，有2年以上的使用经验持。
3、至少具有一种主流数据库系统的缝隙使用经验，精通sql，熟悉基本的性能优化方法。
4、。。。
5.。。。')


--------------------------插入面试表
select * from MianShi

insert MianShi
values(NEWID(),(select id from Users where Username='王子豪'),'2017.5.5','推荐二面',(select id from Users where Username='刘海东'),'2017.6.5','推荐三面',(select id from Users where Username='王子豪'),'2017.7.5','推荐录用')
--------------------------插入简历表

select * from jianli

insert jianli
values(newid(),(select ID from ZhiWei where Zname='软件开发师'),'清雪','女','校园招聘','123456@163.com','18134090635','湖南','顺丰市','性格温和，技术过关','150981197202284550','蓝翔技术学院','技校','挖掘机','2年','8000',0,0,getdate(),'2006-2008年 就职于***公司，职位：中级软件开发工程师',null,0)

insert jianli
values(newid(),(select ID from ZhiWei where Zname='软件开发师'),'张锋','男','社会招聘','123456@163.com','18134090635','河北','邯郸市','技术高超，性别孤傲','164665097202284550','二本学院','大专','厨师','2年','9000',0,0,getdate(),'2006-2008年 就职于新东方，职位：厨师长',(select top 1 id from MianShi),0)


------------------------插入档案状态

select * from DangAnState

insert DangAnState
values (NEWID(),'试用期')
insert DangAnState
values (NEWID(),'正式员工')
insert DangAnState
values (NEWID(),'离职')
insert DangAnState
values (NEWID(),'实习员工')

------------------------插入档案表
select * from DangAn

insert DangAn
values(newid(),(select ID from DangAnState where Name='试用期'),(select ID from ZhiWei where Zname='软件开发师'),'d://图片','张小花','男','123456@163.com','18134090635','河北','邯郸市','这是王小花的描述','164665097202284550','三本学院','大专','计算机网络',(select id from XinChou where Name='中级软件工程师'),'中国银行','xxxxxxxxxxxxxx','sssssssssssss',GETDATE(),'这是张小花的个人履历',(select id from Users where Username='王子豪'),'非常和睦','这是张小花的备注',0)

insert DangAn
values(NEWID(),(select ID from DangAnState where Name='正式员工'),(select ID from ZhiWei where Zname='技术培训师'),'d://图片','王文龙','男','789456@qq.com','13633108164','广州','湖南市','这是王文龙的描述','133238612348642348','河北职中','大学','技术培训',(select id from XinChou where Name='高级软件工程师'),'建设银行','xxxxxxxxxxxxxx','sssssssssssss',getdate(),'这是王文龙的个人履历',(select id from Users where Username='王子豪'),'这是王文龙的简介','这是王文龙的备注',0)