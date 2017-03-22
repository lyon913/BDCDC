--权籍调查项目表
create table QJDCXM(
	[fId] int IDENTITY(1,1) NOT NULL primary key,
	[QXDM] [varchar](100) NULL,
	[QXMC] [varchar](200) NULL,
	[fCreateTime] [datetime] NULL,
	[fCreatorId] int NULL,
	[fCreatorIp] [varchar](100) NULL,
	[fCreatorLoginName] [varchar](100) NULL,
	[fCreatorName] [varchar](100) NULL,
	[fLastUpdaterId] int NULL,
	[fLastUpdaterIp] [varchar](100) NULL,
	[fLastUpdaterLoginName] [varchar](100) NULL,
	[fLastUpdaterName] [varchar](100) NULL,
	[fLstUpdateTime] [datetime] NULL,
	XMBH varchar(50) unique,
	XMMC varchar(200),
	XMLX varchar(50),
	DCDW varchar(200),
	LXR varchar(200),
	LXDH varchar(50),
	DCR varchar(50),
	DCRQ datetime,
	CLR varchar(50),
	CLRQ datetime,
	SHR varchar(50),
	SHRQ datetime,
	SHYJ varchar(500),
	SLR varchar(50),
	SLRQ datetime,
	BZ varchar(1000),
	ZT int
);
go


--ZDJBXX
alter table zdjbxx add QJDCXM_ID int;
go
alter table zdjbxx alter column fCreatorId int;
go
alter table zdjbxx alter column fLastUpdaterId int;
go
alter table ZDJBXX alter column ZDMJ numeric(15,4);
alter table ZDJBXX alter column JG numeric(15,4);
alter table ZDJBXX alter column JZMD numeric(15,2);
alter table ZDJBXX alter column RJL numeric(15,2);
alter table ZDJBXX alter column JZXG numeric(15,2);

--ZRZ
alter table zrz alter column fLastUpdaterId int;
go
alter table zrz add QJDCXM_ID int;
go
alter table zrz alter column fCreatorId int;
go
alter table ZRZ alter column DXSD numeric(15,2);
alter table ZRZ alter column JZWGD numeric(15,2);
alter table ZRZ alter column SCJZMJ numeric(15,2);
alter table ZRZ alter column YCJZMJ numeric(15,2);
alter table ZRZ alter column ZZDMJ numeric(15,2);
alter table ZRZ alter column ZYDMJ numeric(15,2);


--JZD
alter table JZD alter column JBLX varchar(10);
alter table JZD alter column JZDLX varchar(10);
alter table JZD alter column X numeric(15, 3);
alter table JZD alter column Y numeric(15, 3);
alter table JZD add  GC numeric(15, 3);

alter table JZD add  SXH int;
alter table JZD add  ZDDM varchar(50);
alter table JZD add	 QJDCXM_ID int;
alter table JZD add	 ZT int;

alter table JZD add	[QXDM] [varchar](100);
alter table JZD add	[QXMC] [varchar](200);
alter table JZD add	[fCreateTime] [datetime];
alter table JZD add	[fCreatorId] [int];
alter table JZD add	[fCreatorIp] [varchar](100);
alter table JZD add	[fCreatorLoginName] [varchar](100);
alter table JZD add	[fCreatorName] [varchar](100);
alter table JZD add	[fLastUpdaterId] [int];
alter table JZD add	[fLastUpdaterIp] [varchar](100);
alter table JZD add	[fLastUpdaterLoginName] [varchar](100);
alter table JZD add	[fLastUpdaterName] [varchar](100);
alter table JZD add	[fLstUpdateTime] [datetime];




--JZX
alter table JZX alter column JZXCD numeric(15,2);
alter table JZX alter column JZXLB varchar(10);
alter table JZX alter column JZXWZ varchar(10);
alter table JZX alter column JXXZ varchar(10);

alter table JZX add QDH varchar(50);
alter table JZX add ZDH varchar(50);
alter table JZX add ZDDM varchar(50);
alter table JZX add QJDCXM_ID int;
alter table JZX add ZT int;

alter table JZX add	[QXDM] [varchar](100);
alter table JZX add	[QXMC] [varchar](200);
alter table JZX add	[fCreateTime] [datetime];
alter table JZX add	[fCreatorId] [int];
alter table JZX add	[fCreatorIp] [varchar](100);
alter table JZX add	[fCreatorLoginName] [varchar](100);
alter table JZX add	[fCreatorName] [varchar](100);
alter table JZX add	[fLastUpdaterId] [int];
alter table JZX add	[fLastUpdaterIp] [varchar](100);
alter table JZX add	[fLastUpdaterLoginName] [varchar](100);
alter table JZX add	[fLastUpdaterName] [varchar](100);
alter table JZX add	[fLstUpdateTime] [datetime];
go