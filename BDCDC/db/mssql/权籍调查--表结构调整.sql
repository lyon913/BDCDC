-- 获取系统编号的存储过程
Create PROCEDURE [dbo].[getSysNo2]
	-- Add the parameters for the stored procedure here
	@bhlb varchar(50),
	@qxdm varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare
	 @bhid numeric(19,0), -- 编号配置表ID
	 @bhrq varchar(50),-- 流水日期
	 @bhcd int,-- 编号长度
	 @bhls varchar(50), -- 编号值
	 @rqcd int, --流水日期的长度，用于判定按年、月、日流水
	 @err_msg varchar(200)


	BEGIN TRANSACTION;
	BEGIN TRY
		SELECT @bhid=fId,@bhrq=BHRQ,@bhcd=BHCD,@bhls=BHLS from XTBH tbh where BHLB = @bhlb and QXDM=@qxdm;

		-- 未找到编号配置则直接返回null
		if @bhid is null
		begin
		
			set @err_msg = '未找到编号类别：'+@bhlb
			RAISERROR (@err_msg, 16, 1);
		end

		--编号日期不为null，则需要按日期重置流水
		if (@bhrq is not null)
		begin
			declare @str_date varchar(50),@len_rq int

			set @len_rq = len(@bhrq)
			if @len_rq<>4 and @len_rq <> 6 and @len_rq <> 8
			begin
				set @err_msg = '编号日期配置错误，无法识别：'+ @bhrq
				RAISERROR (@err_msg, 16, 1);
			end

			set @str_date = convert(varchar(20),getdate(),112)
			set @str_date = left(@str_date,@len_rq)
			--比较日期大小
			if(@bhrq < @str_date)
			begin
				set @bhrq = @str_date
				set @bhls = 0
				update XTBH set BHRQ=@bhrq where fId=@bhid
			end
		end

		if(@bhls is null)
		begin
			set @bhls='1'
		end
		--编号+1
		set @bhls = convert(varchar,(CONVERT(int,@bhls)+1))

		--编号补位
		set @bhls = '00000000000000000000000' + @bhls
		set @bhls = right(@bhls,@bhcd);

		update XTBH set BHLS=@bhls where fId=@bhid
		COMMIT TRANSACTION;
		select @bhrq+@bhls --输出结果
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH;
END
GO

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

--增加配置表
CREATE TABLE Config(
	fId int IDENTITY(1,1) NOT NULL,
	cfgKey [varchar](200) NOT NULL,
	cfgValue [varchar](1000) NOT NULL,
	note [varchar](500) NULL,
	primary key (fId)
);

CREATE NONCLUSTERED INDEX [IX_Config_cfgKey] ON Config
(
	cfgKey ASC
);
GO
--插入配置项(富民xian80 34度带)
insert into config values('SRID','2358','');

--区县标志
insert into config values('QXBZ','FM','');

--区县代码
insert into config values('QXDM','530124000000','');
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
alter table zrz alter column XMID int;
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
--alter table JZD add  GC numeric(15, 3);

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

--XTYH
alter table XTYH_XTJS drop constraint FK_belm320ldybqm3yc8udg7hprb;
alter table YHJS drop constraint FKo4co1j9pdrv54orgjpc86oi0h;
alter table XTYH drop constraint PK__XTYH__D9F8227C0BC6C43E;

alter table XTYH alter column FID int ;
alter table XTYH add constraint PK_XTYH_FID primary key clustered(FID) ;
go
alter table XTYH alter column fCreatorId int;
go
alter table XTYH alter column fLastUpdaterId int;
go

--H
alter table H drop constraint PK__H__D9F8227C6DCC4D03;
alter table H alter column fid int;
alter table H add constraint PK_H_FID primary key clustered(FID) ;
alter table H alter column fCreatorId int;
alter table H alter column fLastUpdaterId int;

alter table H add QJDCXM_ID int;

alter table H alter column QSC int;
alter table H alter column ZZC int;

alter table H alter column buildingId int;
alter table H alter column houseId int;

alter table H alter column SCDXBFJZMJ numeric(15,3);
alter table H alter column SCFTJZMJ numeric(15,6);
alter table H alter column SCFTXS numeric(15,6);
alter table H alter column SCJZMJ numeric(15,3);
alter table H alter column SCQTJZMJ numeric(15,3);
alter table H alter column SCTNJZMJ numeric(15,3);

alter table H alter column YCDXBFJZMJ numeric(15,3);
alter table H alter column YCFTJZMJ numeric(15,3);
alter table H alter column YCFTXS numeric(15,6);
alter table H alter column YCJZMJ numeric(15,3);
alter table H alter column YCQTJZMJ numeric(15,3);
alter table H alter column YCTNJZMJ numeric(15,3);

alter table H alter column GYTDMJ numeric(15,3);
alter table H alter column FTTDMJ numeric(15,3);
alter table H alter column DYTDMJ numeric(15,3);



--LJZ

alter table LJZ drop constraint PK__LJZ__D9F8227C76619304;
alter table LJZ alter column fid int;
alter table LJZ add constraint PK_LJZ_FID primary key clustered(FID) ;

alter table LJZ add ZTS int;

alter table LJZ alter column fCreatorId int;
alter table LJZ alter column fLastUpdaterId int;

--XM
alter table XM drop constraint PK__XM__D9F8227C2685A772;
alter table XM alter column FID int;
alter table XM add constraint PK_XM_FID primary key clustered(FID) ;

alter table XM alter column fCreatorId int;
alter table XM alter column fLastUpdaterId int;

