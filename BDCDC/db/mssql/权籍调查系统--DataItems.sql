CREATE TABLE [dbo].[DataItems](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[typeName] [varchar](100) NULL,
	[typeCode] [varchar](100) NULL,
	[itemName] [varchar](200) NULL,
	[itemCode] [varchar](200) NULL,
	[code] [varchar](200) NULL,
	[itemOrder] [int] NULL,
	[remark] [varchar](500) NULL,
 CONSTRAINT [PK_DataItems] PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET IDENTITY_INSERT [dbo].[DataItems] ON 

GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (1, N'界线类型', N'A1', N'海岸线', N'250200', N'A1_250200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (2, N'界线类型', N'A1', N'大潮平均高潮线', N'250201', N'A1_250201', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (3, N'界线类型', N'A1', N'海岸线', N'250200', N'A1_250200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (4, N'界线类型', N'A1', N'大潮平均高潮线', N'250201', N'A1_250201', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (5, N'界线类型', N'A1', N'零米等深线', N'250202', N'A1_250202', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (6, N'界线类型', N'A1', N'江河入海口陆海分界线', N'250203', N'A1_250203', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (7, N'界线类型', N'A1', N'国界', N'620200', N'A1_620200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (8, N'界线类型', N'A1', N'省、自治区、直辖市界', N'630200', N'A1_630200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (9, N'界线类型', N'A1', N'地区、自治州、地级市界', N'640200', N'A1_640200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (10, N'界线类型', N'A1', N'县、区、旗、县级市界', N'650200', N'A1_650200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (11, N'界线类型', N'A1', N'街道、乡、（镇）界', N'660200', N'A1_660200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (12, N'界线类型', N'A1', N'开发区、保税区界', N'670402', N'A1_670402', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (13, N'界线类型', N'A1', N'街坊、村界', N'670500', N'A1_670500', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (14, N'界线性质', N'A2', N'已定界', N'600001', N'A2_600001', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (15, N'界线性质', N'A2', N'未定界', N'600002', N'A2_600002', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (16, N'界线性质', N'A2', N'争议界', N'600003', N'A2_600003', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (17, N'界线性质', N'A2', N'工作界', N'600004', N'A2_600004', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (18, N'界线性质', N'A2', N'其它', N'600009', N'A2_600009', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (19, N'界址线位置', N'A3', N'内', N'1', N'A3_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (20, N'界址线位置', N'A3', N'中', N'2', N'A3_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (21, N'界址线位置', N'A3', N'外', N'3', N'A3_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (22, N'界标类型', N'A4', N'钢钉', N'1', N'A4_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (23, N'界标类型', N'A4', N'水泥桩', N'2', N'A4_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (24, N'界标类型', N'A4', N'石灰桩', N'3', N'A4_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (25, N'界标类型', N'A4', N'喷涂', N'4', N'A4_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (26, N'界标类型', N'A4', N'瓷标志', N'5', N'A4_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (27, N'界标类型', N'A4', N'无标志', N'6', N'A4_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (28, N'界标类型', N'A4', N'其它', N'7', N'A4_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (29, N'界址点类型', N'A5', N'解析界址点', N'1', N'A5_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (30, N'界址点类型', N'A5', N'图解界址点', N'2', N'A5_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (31, N'界址点类型', N'A5', N'航测界址点', N'3', N'A5_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (32, N'界址点类型', N'A5', N'其它', N'4', N'A5_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (33, N'是否', N'A6', N'否', N'0', N'A6_0', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (34, N'是否', N'A6', N'是', N'1', N'A6_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (35, N'面积单位', N'A7', N'平方米', N'1', N'A7_1', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (36, N'面积单位', N'A7', N'亩', N'2', N'A7_2', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (37, N'面积单位', N'A7', N'公顷', N'3', N'A7_3', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (38, N'权利类型', N'A8', N'集体土地所有权', N'1', N'A8_1', 11, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (39, N'权利类型', N'A8', N'国家土地所有权', N'2', N'A8_2', 12, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (40, N'权利类型', N'A8', N'国有建设用地使用权', N'3', N'A8_3', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (41, N'权利类型', N'A8', N'国有建设用地使用权/房屋（构筑物）所有权', N'4', N'A8_4', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (42, N'权利类型', N'A8', N'宅基地使用权', N'5', N'A8_5', 5, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (43, N'权利类型', N'A8', N'宅基地使用权/房屋（构筑物）所有权', N'6', N'A8_6', 6, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (44, N'权利类型', N'A8', N'集体建设用地使用权', N'7', N'A8_7', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (45, N'权利类型', N'A8', N'集体建设用地使用权/房屋（构筑物）所有权', N'8', N'A8_8', 4, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (46, N'权利类型', N'A8', N'土地承包经营权', N'9', N'A8_9', 7, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (47, N'权利类型', N'A8', N'土地承包经营权/森林、林木所有权', N'10', N'A8_10', 8, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (48, N'权利类型', N'A8', N'林地使用权', N'11', N'A8_11', 9, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (49, N'权利类型', N'A8', N'林地使用权/森林、林木使用权', N'12', N'A8_12', 10, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (50, N'权利类型', N'A8', N'草原使用权', N'13', N'A8_13', 13, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (51, N'权利类型', N'A8', N'水域滩涂养殖权', N'14', N'A8_14', 14, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (52, N'权利类型', N'A8', N'海域使用权', N'15', N'A8_15', 15, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (53, N'权利类型', N'A8', N'海域使用权/构（建）筑物所有权', N'16', N'A8_16', 16, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (54, N'权利类型', N'A8', N'无居民海岛使用权', N'17', N'A8_17', 17, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (55, N'权利类型', N'A8', N'无居民海岛使用权/构（建）筑物所有权', N'18', N'A8_18', 18, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (56, N'权利类型', N'A8', N'地役权', N'19', N'A8_19', 19, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (57, N'权利类型', N'A8', N'取水权', N'20', N'A8_20', 20, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (58, N'权利类型', N'A8', N'探矿权', N'21', N'A8_21', 21, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (59, N'权利类型', N'A8', N'采矿权', N'22', N'A8_22', 22, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (60, N'权利类型', N'A8', N'其它权利', N'99', N'A8_99', 23, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (61, N'权利性质', N'A9', N'国有土地', N'100', N'A9_100', 14, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (62, N'权利性质', N'A9', N'划拨', N'101', N'A9_101', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (63, N'权利性质', N'A9', N'出让', N'102', N'A9_102', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (64, N'权利性质', N'A9', N'作价出资（入股）', N'103', N'A9_103', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (65, N'权利性质', N'A9', N'国有土地租赁', N'104', N'A9_104', 4, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (66, N'权利性质', N'A9', N'授权经营', N'105', N'A9_105', 5, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (67, N'权利性质', N'A9', N'家庭承包', N'106', N'A9_106', 6, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (68, N'权利性质', N'A9', N'其它方式承包', N'107', N'A9_107', 7, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (69, N'权利性质', N'A9', N'集体土地', N'200', N'A9_200', 8, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (70, N'权利性质', N'A9', N'家庭承包', N'201', N'A9_201', 9, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (71, N'权利性质', N'A9', N'其它方式承包', N'202', N'A9_202', 10, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (72, N'权利性质', N'A9', N'批准拨用', N'203', N'A9_203', 11, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (73, N'权利性质', N'A9', N'入股', N'204', N'A9_204', 12, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (74, N'权利性质', N'A9', N'联营', N'205', N'A9_205', 13, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (75, N'权利设定方式', N'A10', N'地上', N'1', N'A10_1', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (76, N'权利设定方式', N'A10', N'地表', N'2', N'A10_2', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (77, N'权利设定方式', N'A10', N'地下', N'3', N'A10_3', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (78, N'不动产单元状态', N'A11', N'无效', N'0', N'A11_0', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (79, N'不动产单元状态', N'A11', N'有效', N'1', N'A11_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (80, N'海域使用类型A', N'A12', N'渔业用海', N'1', N'A12_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (81, N'海域使用类型A', N'A12', N'工业用海', N'2', N'A12_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (82, N'海域使用类型A', N'A12', N'交通运输用海', N'3', N'A12_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (83, N'海域使用类型A', N'A12', N'旅游娱乐用海', N'4', N'A12_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (84, N'海域使用类型A', N'A12', N'海底工程用海', N'5', N'A12_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (85, N'海域使用类型A', N'A12', N'排污倾倒用海', N'6', N'A12_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (86, N'海域使用类型A', N'A12', N'造地工程用海', N'7', N'A12_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (87, N'海域使用类型A', N'A12', N'特殊用海', N'8', N'A12_8', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (88, N'海域使用类型A', N'A12', N'其它用海', N'9', N'A12_9', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (89, N'海域使用类型B', N'A13', N'渔业基础设施用海', N'11', N'A13_11', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (90, N'海域使用类型B', N'A13', N'围海养殖用海', N'12', N'A13_12', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (91, N'海域使用类型B', N'A13', N'开放式养殖用海', N'13', N'A13_13', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (92, N'海域使用类型B', N'A13', N'人工鱼礁用海', N'14', N'A13_14', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (93, N'海域使用类型B', N'A13', N'盐业用海', N'21', N'A13_21', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (94, N'海域使用类型B', N'A13', N'固体矿产开采用海', N'22', N'A13_22', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (95, N'海域使用类型B', N'A13', N'油气开采用海', N'23', N'A13_23', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (96, N'海域使用类型B', N'A13', N'船舶工业用海', N'24', N'A13_24', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (97, N'海域使用类型B', N'A13', N'电力工业用海', N'25', N'A13_25', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (98, N'海域使用类型B', N'A13', N'海水综合利用用海', N'26', N'A13_26', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (99, N'海域使用类型B', N'A13', N'其它工业用海', N'27', N'A13_27', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (100, N'海域使用类型B', N'A13', N'港口用海', N'31', N'A13_31', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (101, N'海域使用类型B', N'A13', N'航道用海', N'32', N'A13_32', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (102, N'海域使用类型B', N'A13', N'锚地用海', N'33', N'A13_33', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (103, N'海域使用类型B', N'A13', N'路桥用海', N'34', N'A13_34', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (104, N'海域使用类型B', N'A13', N'旅游基础设施用海', N'41', N'A13_41', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (105, N'海域使用类型B', N'A13', N'浴场用海', N'42', N'A13_42', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (106, N'海域使用类型B', N'A13', N'游乐场用海', N'43', N'A13_43', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (107, N'海域使用类型B', N'A13', N'电缆管道用海', N'51', N'A13_51', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (108, N'海域使用类型B', N'A13', N'海底隧道用海', N'52', N'A13_52', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (109, N'海域使用类型B', N'A13', N'海底场馆用海', N'53', N'A13_53', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (110, N'海域使用类型B', N'A13', N'污水达标排放用海', N'61', N'A13_61', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (111, N'海域使用类型B', N'A13', N'倾倒区用海', N'62', N'A13_62', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (112, N'海域使用类型B', N'A13', N'城镇建设填海造地用海', N'71', N'A13_71', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (113, N'海域使用类型B', N'A13', N'农业填海造地用海', N'72', N'A13_72', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (114, N'海域使用类型B', N'A13', N'废弃物处置填海造地用海', N'73', N'A13_73', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (115, N'海域使用类型B', N'A13', N'科研教学用海', N'81', N'A13_81', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (116, N'海域使用类型B', N'A13', N'军事用海', N'82', N'A13_82', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (117, N'海域使用类型B', N'A13', N'海洋保护区用海', N'83', N'A13_83', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (118, N'海域使用类型B', N'A13', N'海岸防护工程用海', N'84', N'A13_84', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (119, N'海域等别', N'A14', N'一级', N'1', N'A14_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (120, N'海域等别', N'A14', N'二级', N'2', N'A14_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (121, N'海域等别', N'A14', N'三级', N'3', N'A14_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (122, N'海域等别', N'A14', N'四级', N'4', N'A14_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (123, N'海域等别', N'A14', N'五级', N'5', N'A14_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (124, N'海域等别', N'A14', N'六级', N'6', N'A14_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (125, N'户型', N'A15', N'一居室', N'1', N'A15_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (126, N'户型', N'A15', N'二居室', N'2', N'A15_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (127, N'户型', N'A15', N'三居室', N'3', N'A15_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (128, N'户型', N'A15', N'四居室', N'4', N'A15_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (129, N'户型', N'A15', N'五居室', N'5', N'A15_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (130, N'户型', N'A15', N'其它', N'99', N'A15_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (131, N'户型结构', N'A16', N'平层', N'1', N'A16_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (132, N'户型结构', N'A16', N'错层', N'2', N'A16_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (133, N'户型结构', N'A16', N'复式楼', N'3', N'A16_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (134, N'户型结构', N'A16', N'跃层', N'4', N'A16_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (135, N'户型结构', N'A16', N'其它', N'99', N'A16_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (136, N'房屋用途', N'A17', N'住宅', N'10', N'A17_10', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (137, N'房屋用途', N'A17', N'成套住宅', N'11', N'A17_11', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (138, N'房屋用途', N'A17', N'别墅', N'111', N'A17_111', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (139, N'房屋用途', N'A17', N'高档公寓', N'112', N'A17_112', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (140, N'房屋用途', N'A17', N'非成套住宅', N'12', N'A17_12', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (141, N'房屋用途', N'A17', N'集体宿舍', N'13', N'A17_13', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (142, N'房屋用途', N'A17', N'工业、交通、仓储', N'20', N'A17_20', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (143, N'房屋用途', N'A17', N'工业', N'21', N'A17_21', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (144, N'房屋用途', N'A17', N'公共设施', N'22', N'A17_22', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (145, N'房屋用途', N'A17', N'铁路', N'23', N'A17_23', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (146, N'房屋用途', N'A17', N'民航', N'24', N'A17_24', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (147, N'房屋用途', N'A17', N'航运', N'25', N'A17_25', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (148, N'房屋用途', N'A17', N'公共运输', N'26', N'A17_26', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (149, N'房屋用途', N'A17', N'仓储', N'27', N'A17_27', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (150, N'房屋用途', N'A17', N'商业、金融、信息', N'30', N'A17_30', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (151, N'房屋用途', N'A17', N'商业服务', N'31', N'A17_31', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (152, N'房屋用途', N'A17', N'经营', N'32', N'A17_32', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (153, N'房屋用途', N'A17', N'旅游', N'33', N'A17_33', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (154, N'房屋用途', N'A17', N'金融保险', N'34', N'A17_34', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (155, N'房屋用途', N'A17', N'电讯信息', N'35', N'A17_35', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (156, N'房屋用途', N'A17', N'教育、医疗、卫生、科研', N'40', N'A17_40', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (157, N'房屋用途', N'A17', N'教育', N'41', N'A17_41', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (158, N'房屋用途', N'A17', N'医疗卫生', N'42', N'A17_42', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (159, N'房屋用途', N'A17', N'科研', N'43', N'A17_43', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (160, N'房屋用途', N'A17', N'文化、娱乐、体育', N'50', N'A17_50', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (161, N'房屋用途', N'A17', N'文化', N'51', N'A17_51', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (162, N'房屋用途', N'A17', N'新闻', N'52', N'A17_52', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (163, N'房屋用途', N'A17', N'娱乐', N'53', N'A17_53', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (164, N'房屋用途', N'A17', N'园林绿化', N'54', N'A17_54', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (165, N'房屋用途', N'A17', N'体育', N'55', N'A17_55', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (166, N'房屋用途', N'A17', N'办公', N'60', N'A17_60', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (167, N'房屋用途', N'A17', N'军事', N'70', N'A17_70', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (168, N'房屋用途', N'A17', N'其它', N'80', N'A17_80', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (169, N'房屋用途', N'A17', N'涉外', N'81', N'A17_81', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (170, N'房屋用途', N'A17', N'宗教', N'82', N'A17_82', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (171, N'房屋用途', N'A17', N'监狱', N'83', N'A17_83', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (172, N'房屋用途', N'A17', N'物管用房', N'84', N'A17_84', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (173, N'房屋类型', N'A18', N'住宅', N'1', N'A18_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (174, N'房屋类型', N'A18', N'商业用房', N'2', N'A18_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (175, N'房屋类型', N'A18', N'办公用房', N'3', N'A18_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (176, N'房屋类型', N'A18', N'工业用房', N'4', N'A18_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (177, N'房屋类型', N'A18', N'仓储用房', N'5', N'A18_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (178, N'房屋类型', N'A18', N'车库', N'6', N'A18_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (179, N'房屋类型', N'A18', N'其它', N'99', N'A18_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (180, N'房屋性质', N'A19', N'市场化商品房', N'0', N'A19_0', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (181, N'房屋性质', N'A19', N'动迁房', N'1', N'A19_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (182, N'房屋性质', N'A19', N'配套商品房', N'2', N'A19_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (183, N'房屋性质', N'A19', N'公共租赁住房', N'3', N'A19_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (184, N'房屋性质', N'A19', N'廉租住房', N'4', N'A19_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (185, N'房屋性质', N'A19', N'限价普通商品住房', N'5', N'A19_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (186, N'房屋性质', N'A19', N'经济适用住房', N'6', N'A19_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (187, N'房屋性质', N'A19', N'定销商品房', N'7', N'A19_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (188, N'房屋性质', N'A19', N'集资建房', N'8', N'A19_8', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (189, N'房屋性质', N'A19', N'福利房', N'9', N'A19_9', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (190, N'房屋性质', N'A19', N'其它', N'99', N'A19_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (191, N'区县', N'A20', N'某某市某某区', N'310101', N'A20_310101', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (192, N'区县', N'A20', N'??', N'310103', N'A20_310103', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (193, N'区县', N'A20', N'??', N'??', N'A20_??', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (194, N'登记类型', N'A21', N'首次登记', N'100', N'A21_100', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (195, N'登记类型', N'A21', N'转移登记', N'200', N'A21_200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (196, N'登记类型', N'A21', N'变更登记', N'300', N'A21_300', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (197, N'登记类型', N'A21', N'注销登记', N'400', N'A21_400', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (198, N'登记类型', N'A21', N'更正登记', N'500', N'A21_500', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (199, N'登记类型', N'A21', N'异议登记', N'600', N'A21_600', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (200, N'登记类型', N'A21', N'预告登记', N'700', N'A21_700', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (201, N'登记类型', N'A21', N'查封登记', N'800', N'A21_800', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (202, N'登记类型', N'A21', N'其它登记', N'900', N'A21_900', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (203, N'权属状态', N'A22', N'临时', N'0', N'A22_0', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (204, N'权属状态', N'A22', N'现势', N'1', N'A22_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (205, N'权属状态', N'A22', N'历史', N'2', N'A22_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (206, N'权属状态', N'A22', N'终止', N'3', N'A22_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (207, N'水域滩涂类型', N'A23', N'淡水水域滩涂', N'1', N'A23_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (208, N'水域滩涂类型', N'A23', N'海水水域滩涂', N'2', N'A23_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (209, N'养殖业方式', N'A24', N'池塘', N'1', N'A24_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (210, N'养殖业方式', N'A24', N'大水面放养', N'2', N'A24_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (211, N'养殖业方式', N'A24', N'围栏', N'3', N'A24_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (212, N'养殖业方式', N'A24', N'工厂化', N'4', N'A24_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (213, N'养殖业方式', N'A24', N'筏吊式', N'5', N'A24_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (214, N'养殖业方式', N'A24', N'滩涂底播', N'6', N'A24_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (215, N'养殖业方式', N'A24', N'网箱', N'7', N'A24_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (216, N'构(建)筑物类型', N'A25', N'地上构筑物', N'100', N'A25_100', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (217, N'构(建)筑物类型', N'A25', N'隧道', N'101', N'A25_101', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (218, N'构(建)筑物类型', N'A25', N'桥梁', N'102', N'A25_102', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (219, N'构(建)筑物类型', N'A25', N'水塔', N'103', N'A25_103', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (220, N'构(建)筑物类型', N'A25', N'其它地上构筑物', N'199', N'A25_199', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (221, N'构(建)筑物类型', N'A25', N'海上构筑物', N'200', N'A25_200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (222, N'构(建)筑物类型', N'A25', N'透水构筑物', N'201', N'A25_201', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (223, N'构(建)筑物类型', N'A25', N'非透水构筑物', N'202', N'A25_202', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (224, N'构(建)筑物类型', N'A25', N'跨海桥梁', N'203', N'A25_203', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (225, N'构(建)筑物类型', N'A25', N'海底隧道', N'204', N'A25_204', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (226, N'构(建)筑物类型', N'A25', N'其它海上构筑物', N'299', N'A25_299', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (227, N'林种', N'A26', N'防护林', N'1', N'A26_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (228, N'林种', N'A26', N'用材林', N'2', N'A26_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (229, N'林种', N'A26', N'经济林', N'3', N'A26_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (230, N'林种', N'A26', N'薪炭林', N'4', N'A26_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (231, N'林种', N'A26', N'特种用途林', N'5', N'A26_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (232, N'抵押不动产类型', N'A27', N'土地', N'1', N'A27_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (233, N'抵押不动产类型', N'A27', N'土地和房屋', N'2', N'A27_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (234, N'抵押不动产类型', N'A27', N'林地和林木', N'3', N'A27_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (235, N'抵押不动产类型', N'A27', N'土地和在建建筑物', N'4', N'A27_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (236, N'抵押不动产类型', N'A27', N'海域', N'5', N'A27_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (237, N'抵押不动产类型', N'A27', N'海域和构筑物', N'6', N'A27_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (238, N'抵押不动产类型', N'A27', N'其它', N'7', N'A27_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (239, N'抵押方式', N'A28', N'一般抵押', N'1', N'A28_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (240, N'抵押方式', N'A28', N'最高额抵押', N'2', N'A28_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (241, N'预告登记种类', N'A29', N'预售商品房买卖预告登记', N'1', N'A29_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (242, N'预告登记种类', N'A29', N'其它不动产买卖预告登记', N'2', N'A29_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (243, N'预告登记种类', N'A29', N'预售商品房抵押权预告登记', N'3', N'A29_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (244, N'预告登记种类', N'A29', N'其它不动产抵押权预告登记', N'4', N'A29_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (245, N'证件种类', N'A30', N'身份证', N'1', N'A30_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (246, N'证件种类', N'A30', N'港澳台身份证', N'2', N'A30_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (247, N'证件种类', N'A30', N'护照', N'3', N'A30_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (248, N'证件种类', N'A30', N'户口簿', N'4', N'A30_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (249, N'证件种类', N'A30', N'军官证（士兵证）', N'5', N'A30_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (250, N'证件种类', N'A30', N'组织机构代码', N'6', N'A30_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (251, N'证件种类', N'A30', N'营业执照', N'7', N'A30_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (252, N'证件种类', N'A30', N'其它', N'99', N'A30_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (253, N'案件状态', N'A31', N'在办', N'1', N'A31_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (254, N'案件状态', N'A31', N'已办', N'2', N'A31_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (255, N'案件状态', N'A31', N'暂停', N'3', N'A31_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (256, N'案件状态', N'A31', N'不予登记', N'4', N'A31_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (257, N'案件状态', N'A31', N'用户撤回', N'5', N'A31_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (258, N'查封类型', N'A32', N'查封', N'1', N'A32_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (259, N'查封类型', N'A32', N'轮候查封', N'2', N'A32_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (260, N'查封类型', N'A32', N'预查封', N'3', N'A32_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (261, N'查封类型', N'A32', N'轮候预查封', N'4', N'A32_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (262, N'付费方字', N'A33', N'甲方', N'1', N'A33_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (263, N'付费方字', N'A33', N'乙方', N'2', N'A33_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (264, N'付费方字', N'A33', N'双方', N'3', N'A33_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (265, N'共有方式', N'A34', N'单独所有', N'0', N'A34_0', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (266, N'共有方式', N'A34', N'共同共有', N'1', N'A34_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (267, N'共有方式', N'A34', N'按份共有', N'2', N'A34_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (268, N'共有方式', N'A34', N'其它共有', N'3', N'A34_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (269, N'国家和地区', N'A35', N'中华人民共和国', N'142', N'A35_142', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (270, N'国家和地区', N'A35', N'亚洲', N'100', N'A35_100', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (271, N'国家和地区', N'A35', N'阿富汗', N'101', N'A35_101', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (272, N'国家和地区', N'A35', N'巴林', N'102', N'A35_102', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (273, N'国家和地区', N'A35', N'孟加拉国', N'103', N'A35_103', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (274, N'国家和地区', N'A35', N'不丹', N'104', N'A35_104', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (275, N'国家和地区', N'A35', N'文莱', N'105', N'A35_105', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (276, N'国家和地区', N'A35', N'缅甸', N'106', N'A35_106', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (277, N'国家和地区', N'A35', N'柬埔寨', N'107', N'A35_107', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (278, N'国家和地区', N'A35', N'塞浦路斯', N'108', N'A35_108', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (279, N'国家和地区', N'A35', N'朝鲜民主主义人民共和国', N'109', N'A35_109', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (280, N'国家和地区', N'A35', N'印度', N'111', N'A35_111', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (281, N'国家和地区', N'A35', N'印度尼西亚', N'112', N'A35_112', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (282, N'国家和地区', N'A35', N'伊朗', N'113', N'A35_113', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (283, N'国家和地区', N'A35', N'伊拉克', N'114', N'A35_114', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (284, N'国家和地区', N'A35', N'以色列', N'115', N'A35_115', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (285, N'国家和地区', N'A35', N'日本', N'116', N'A35_116', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (286, N'国家和地区', N'A35', N'约旦', N'117', N'A35_117', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (287, N'国家和地区', N'A35', N'科威特', N'118', N'A35_118', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (288, N'国家和地区', N'A35', N'老挝', N'119', N'A35_119', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (289, N'国家和地区', N'A35', N'黎巴嫩', N'120', N'A35_120', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (290, N'国家和地区', N'A35', N'马来西亚', N'122', N'A35_122', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (291, N'国家和地区', N'A35', N'马尔代夫', N'123', N'A35_123', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (292, N'国家和地区', N'A35', N'蒙古', N'124', N'A35_124', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (293, N'国家和地区', N'A35', N'尼泊尔', N'125', N'A35_125', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (294, N'国家和地区', N'A35', N'阿曼', N'126', N'A35_126', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (295, N'国家和地区', N'A35', N'巴基斯坦', N'127', N'A35_127', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (296, N'国家和地区', N'A35', N'巴勒斯坦', N'128', N'A35_128', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (297, N'国家和地区', N'A35', N'菲律宾', N'129', N'A35_129', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (298, N'国家和地区', N'A35', N'卡塔尔', N'130', N'A35_130', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (299, N'国家和地区', N'A35', N'沙特阿拉伯', N'131', N'A35_131', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (300, N'国家和地区', N'A35', N'新加坡', N'132', N'A35_132', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (301, N'国家和地区', N'A35', N'韩国', N'133', N'A35_133', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (302, N'国家和地区', N'A35', N'斯里兰卡', N'134', N'A35_134', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (303, N'国家和地区', N'A35', N'叙利亚', N'135', N'A35_135', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (304, N'国家和地区', N'A35', N'泰国', N'136', N'A35_136', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (305, N'国家和地区', N'A35', N'土耳其', N'137', N'A35_137', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (306, N'国家和地区', N'A35', N'阿拉伯联合酋长国', N'138', N'A35_138', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (307, N'国家和地区', N'A35', N'也门共和国', N'139', N'A35_139', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (308, N'国家和地区', N'A35', N'越南', N'141', N'A35_141', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (309, N'国家和地区', N'A35', N'非洲', N'200', N'A35_200', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (310, N'国家和地区', N'A35', N'阿尔及利亚', N'201', N'A35_201', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (311, N'国家和地区', N'A35', N'安哥拉', N'202', N'A35_202', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (312, N'国家和地区', N'A35', N'贝宁', N'203', N'A35_203', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (313, N'国家和地区', N'A35', N'博茨瓦纳', N'204', N'A35_204', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (314, N'国家和地区', N'A35', N'布隆迪', N'205', N'A35_205', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (315, N'国家和地区', N'A35', N'喀麦隆', N'206', N'A35_206', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (316, N'国家和地区', N'A35', N'加那利群岛', N'207', N'A35_207', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (317, N'国家和地区', N'A35', N'佛得角', N'208', N'A35_208', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (318, N'国家和地区', N'A35', N'中非', N'209', N'A35_209', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (319, N'国家和地区', N'A35', N'塞卜泰(休达)', N'210', N'A35_210', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (320, N'国家和地区', N'A35', N'乍得', N'211', N'A35_211', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (321, N'国家和地区', N'A35', N'科摩罗', N'212', N'A35_212', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (322, N'国家和地区', N'A35', N'刚果', N'213', N'A35_213', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (323, N'国家和地区', N'A35', N'吉布提', N'214', N'A35_214', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (324, N'国家和地区', N'A35', N'埃及', N'215', N'A35_215', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (325, N'国家和地区', N'A35', N'赤道几内亚', N'216', N'A35_216', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (326, N'国家和地区', N'A35', N'埃塞俄比亚', N'217', N'A35_217', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (327, N'国家和地区', N'A35', N'加蓬', N'218', N'A35_218', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (328, N'国家和地区', N'A35', N'冈比亚', N'219', N'A35_219', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (329, N'国家和地区', N'A35', N'加纳', N'220', N'A35_220', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (330, N'国家和地区', N'A35', N'几内亚', N'221', N'A35_221', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (331, N'国家和地区', N'A35', N'几内亚(比绍)', N'222', N'A35_222', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (332, N'国家和地区', N'A35', N'科特迪瓦', N'223', N'A35_223', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (333, N'国家和地区', N'A35', N'肯尼亚', N'224', N'A35_224', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (334, N'国家和地区', N'A35', N'利比里亚', N'225', N'A35_225', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (335, N'国家和地区', N'A35', N'利比亚', N'226', N'A35_226', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (336, N'国家和地区', N'A35', N'马达加斯加', N'227', N'A35_227', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (337, N'国家和地区', N'A35', N'马拉维', N'228', N'A35_228', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (338, N'国家和地区', N'A35', N'马里', N'229', N'A35_229', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (339, N'国家和地区', N'A35', N'毛里塔尼亚', N'230', N'A35_230', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (340, N'国家和地区', N'A35', N'毛里求斯', N'231', N'A35_231', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (341, N'国家和地区', N'A35', N'摩洛哥', N'232', N'A35_232', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (342, N'国家和地区', N'A35', N'莫桑比克', N'233', N'A35_233', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (343, N'国家和地区', N'A35', N'纳米比亚', N'234', N'A35_234', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (344, N'国家和地区', N'A35', N'尼日尔', N'235', N'A35_235', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (345, N'国家和地区', N'A35', N'尼日利亚', N'236', N'A35_236', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (346, N'国家和地区', N'A35', N'留尼汪', N'237', N'A35_237', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (347, N'国家和地区', N'A35', N'卢旺达', N'238', N'A35_238', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (348, N'国家和地区', N'A35', N'圣多美和普林西比', N'239', N'A35_239', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (349, N'国家和地区', N'A35', N'塞内加尔', N'240', N'A35_240', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (350, N'国家和地区', N'A35', N'塞舌尔', N'241', N'A35_241', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (351, N'国家和地区', N'A35', N'塞拉利昂', N'242', N'A35_242', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (352, N'国家和地区', N'A35', N'索马里', N'243', N'A35_243', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (353, N'国家和地区', N'A35', N'南非', N'244', N'A35_244', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (354, N'国家和地区', N'A35', N'西撒哈拉', N'245', N'A35_245', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (355, N'国家和地区', N'A35', N'苏丹', N'246', N'A35_246', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (356, N'国家和地区', N'A35', N'坦桑尼亚', N'247', N'A35_247', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (357, N'国家和地区', N'A35', N'多哥', N'248', N'A35_248', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (358, N'国家和地区', N'A35', N'突尼斯', N'249', N'A35_249', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (359, N'国家和地区', N'A35', N'乌干达', N'250', N'A35_250', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (360, N'国家和地区', N'A35', N'布基纳法索', N'251', N'A35_251', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (361, N'国家和地区', N'A35', N'扎伊尔', N'252', N'A35_252', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (362, N'国家和地区', N'A35', N'赞比亚', N'253', N'A35_253', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (363, N'国家和地区', N'A35', N'津巴布韦', N'254', N'A35_254', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (364, N'国家和地区', N'A35', N'莱索托', N'255', N'A35_255', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (365, N'国家和地区', N'A35', N'梅利利亚', N'256', N'A35_256', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (366, N'国家和地区', N'A35', N'斯威士兰', N'257', N'A35_257', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (367, N'国家和地区', N'A35', N'厄立特里亚', N'258', N'A35_258', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (368, N'国家和地区', N'A35', N'非洲其它国家(地区)', N'299', N'A35_299', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (369, N'国家和地区', N'A35', N'欧洲', N'300', N'A35_300', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (370, N'国家和地区', N'A35', N'比利时', N'301', N'A35_301', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (371, N'国家和地区', N'A35', N'丹麦', N'302', N'A35_302', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (372, N'国家和地区', N'A35', N'英国', N'303', N'A35_303', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (373, N'国家和地区', N'A35', N'德意志联邦共和国', N'304', N'A35_304', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (374, N'国家和地区', N'A35', N'法国', N'305', N'A35_305', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (375, N'国家和地区', N'A35', N'爱尔兰', N'306', N'A35_306', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (376, N'国家和地区', N'A35', N'意大利', N'307', N'A35_307', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (377, N'国家和地区', N'A35', N'卢森堡', N'308', N'A35_308', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (378, N'国家和地区', N'A35', N'荷兰', N'309', N'A35_309', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (379, N'国家和地区', N'A35', N'希腊', N'310', N'A35_310', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (380, N'国家和地区', N'A35', N'葡萄牙', N'311', N'A35_311', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (381, N'国家和地区', N'A35', N'西班牙', N'312', N'A35_312', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (382, N'国家和地区', N'A35', N'阿尔巴尼亚', N'313', N'A35_313', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (383, N'国家和地区', N'A35', N'安道尔', N'314', N'A35_314', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (384, N'国家和地区', N'A35', N'奥地利', N'315', N'A35_315', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (385, N'国家和地区', N'A35', N'保加利亚', N'316', N'A35_316', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (386, N'国家和地区', N'A35', N'芬兰', N'318', N'A35_318', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (387, N'国家和地区', N'A35', N'直布罗陀', N'320', N'A35_320', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (388, N'国家和地区', N'A35', N'匈牙利', N'321', N'A35_321', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (389, N'国家和地区', N'A35', N'冰岛', N'322', N'A35_322', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (390, N'国家和地区', N'A35', N'列支敦士登', N'323', N'A35_323', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (391, N'国家和地区', N'A35', N'马耳他', N'324', N'A35_324', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (392, N'国家和地区', N'A35', N'摩纳哥', N'325', N'A35_325', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (393, N'国家和地区', N'A35', N'挪威', N'326', N'A35_326', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (394, N'国家和地区', N'A35', N'波兰', N'327', N'A35_327', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (395, N'国家和地区', N'A35', N'罗马尼亚', N'328', N'A35_328', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (396, N'国家和地区', N'A35', N'圣马力诺', N'329', N'A35_329', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (397, N'国家和地区', N'A35', N'瑞典', N'330', N'A35_330', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (398, N'国家和地区', N'A35', N'瑞士', N'331', N'A35_331', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (399, N'国家和地区', N'A35', N'爱沙尼亚', N'334', N'A35_334', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (400, N'国家和地区', N'A35', N'拉脱维亚', N'335', N'A35_335', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (401, N'国家和地区', N'A35', N'立陶宛', N'336', N'A35_336', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (402, N'国家和地区', N'A35', N'格鲁吉亚', N'337', N'A35_337', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (403, N'国家和地区', N'A35', N'亚美尼亚', N'338', N'A35_338', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (404, N'国家和地区', N'A35', N'阿塞拜疆', N'339', N'A35_339', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (405, N'国家和地区', N'A35', N'白俄罗斯', N'340', N'A35_340', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (406, N'国家和地区', N'A35', N'哈萨克斯坦', N'341', N'A35_341', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (407, N'国家和地区', N'A35', N'吉尔吉斯', N'342', N'A35_342', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (408, N'国家和地区', N'A35', N'摩尔多瓦', N'343', N'A35_343', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (409, N'国家和地区', N'A35', N'俄罗斯', N'344', N'A35_344', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (410, N'国家和地区', N'A35', N'塔吉克斯坦', N'345', N'A35_345', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (411, N'国家和地区', N'A35', N'乌克兰', N'347', N'A35_347', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (412, N'国家和地区', N'A35', N'乌兹别克斯坦', N'348', N'A35_348', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (413, N'国家和地区', N'A35', N'南斯拉夫联盟共和国', N'349', N'A35_349', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (414, N'国家和地区', N'A35', N'斯洛文尼亚共和国', N'350', N'A35_350', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (415, N'国家和地区', N'A35', N'克罗地亚共和国', N'351', N'A35_351', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (416, N'国家和地区', N'A35', N'捷克共和国', N'352', N'A35_352', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (417, N'国家和地区', N'A35', N'斯洛伐克共和国', N'353', N'A35_353', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (418, N'国家和地区', N'A35', N'前南斯拉夫马其顿共和国', N'354', N'A35_354', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (419, N'国家和地区', N'A35', N'波斯尼亚-黑塞哥维那共和国', N'355', N'A35_355', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (420, N'国家和地区', N'A35', N'土库曼斯坦', N'356', N'A35_356', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (421, N'国家和地区', N'A35', N'拉丁美洲', N'400', N'A35_400', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (422, N'国家和地区', N'A35', N'安提瓜和巴布达', N'401', N'A35_401', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (423, N'国家和地区', N'A35', N'阿根廷', N'402', N'A35_402', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (424, N'国家和地区', N'A35', N'阿鲁巴岛', N'403', N'A35_403', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (425, N'国家和地区', N'A35', N'巴哈马', N'404', N'A35_404', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (426, N'国家和地区', N'A35', N'巴巴多斯', N'405', N'A35_405', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (427, N'国家和地区', N'A35', N'伯利兹', N'406', N'A35_406', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (428, N'国家和地区', N'A35', N'玻利维亚', N'408', N'A35_408', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (429, N'国家和地区', N'A35', N'博奈尔', N'409', N'A35_409', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (430, N'国家和地区', N'A35', N'巴西', N'410', N'A35_410', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (431, N'国家和地区', N'A35', N'开曼群岛', N'411', N'A35_411', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (432, N'国家和地区', N'A35', N'智利', N'412', N'A35_412', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (433, N'国家和地区', N'A35', N'哥伦比亚', N'413', N'A35_413', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (434, N'国家和地区', N'A35', N'多米尼克', N'414', N'A35_414', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (435, N'国家和地区', N'A35', N'哥斯达黎加', N'415', N'A35_415', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (436, N'国家和地区', N'A35', N'古巴', N'416', N'A35_416', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (437, N'国家和地区', N'A35', N'库腊索岛', N'417', N'A35_417', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (438, N'国家和地区', N'A35', N'多米尼加共和国', N'418', N'A35_418', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (439, N'国家和地区', N'A35', N'厄瓜多尔', N'419', N'A35_419', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (440, N'国家和地区', N'A35', N'法属圭亚那', N'420', N'A35_420', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (441, N'国家和地区', N'A35', N'格林纳达', N'421', N'A35_421', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (442, N'国家和地区', N'A35', N'瓜德罗普', N'422', N'A35_422', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (443, N'国家和地区', N'A35', N'危地马拉', N'423', N'A35_423', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (444, N'国家和地区', N'A35', N'圭亚那', N'424', N'A35_424', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (445, N'国家和地区', N'A35', N'海地', N'425', N'A35_425', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (446, N'国家和地区', N'A35', N'洪都拉斯', N'426', N'A35_426', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (447, N'国家和地区', N'A35', N'牙买加', N'427', N'A35_427', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (448, N'国家和地区', N'A35', N'马提尼克', N'428', N'A35_428', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (449, N'国家和地区', N'A35', N'墨西哥', N'429', N'A35_429', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (450, N'国家和地区', N'A35', N'蒙特塞拉特', N'430', N'A35_430', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (451, N'国家和地区', N'A35', N'尼加拉瓜', N'431', N'A35_431', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (452, N'国家和地区', N'A35', N'巴拿马', N'432', N'A35_432', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (453, N'国家和地区', N'A35', N'巴拉圭', N'433', N'A35_433', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (454, N'国家和地区', N'A35', N'秘鲁', N'434', N'A35_434', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (455, N'国家和地区', N'A35', N'波多黎各', N'435', N'A35_435', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (456, N'国家和地区', N'A35', N'萨巴', N'436', N'A35_436', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (457, N'国家和地区', N'A35', N'圣卢西亚', N'437', N'A35_437', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (458, N'国家和地区', N'A35', N'圣马丁岛', N'438', N'A35_438', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (459, N'国家和地区', N'A35', N'圣文森特和格林纳丁斯', N'439', N'A35_439', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (460, N'国家和地区', N'A35', N'萨尔瓦多', N'440', N'A35_440', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (461, N'国家和地区', N'A35', N'苏里南', N'441', N'A35_441', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (462, N'国家和地区', N'A35', N'特立尼达和多巴哥', N'442', N'A35_442', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (463, N'国家和地区', N'A35', N'特克斯和凯科斯群岛', N'443', N'A35_443', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (464, N'国家和地区', N'A35', N'乌拉圭', N'444', N'A35_444', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (465, N'国家和地区', N'A35', N'委内瑞拉', N'445', N'A35_445', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (466, N'国家和地区', N'A35', N'英属维尔京群岛', N'446', N'A35_446', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (467, N'国家和地区', N'A35', N'圣其茨-尼维斯', N'447', N'A35_447', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (468, N'国家和地区', N'A35', N'拉丁美洲其它国家(地区)', N'499', N'A35_499', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (469, N'国家和地区', N'A35', N'北美洲', N'500', N'A35_500', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (470, N'国家和地区', N'A35', N'加拿大', N'501', N'A35_501', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (471, N'国家和地区', N'A35', N'美国', N'502', N'A35_502', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (472, N'国家和地区', N'A35', N'格陵兰', N'503', N'A35_503', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (473, N'国家和地区', N'A35', N'百慕大', N'504', N'A35_504', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (474, N'国家和地区', N'A35', N'北美洲其它国家(地区)', N'599', N'A35_599', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (475, N'国家和地区', N'A35', N'大洋洲', N'600', N'A35_600', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (476, N'国家和地区', N'A35', N'澳大利亚', N'601', N'A35_601', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (477, N'国家和地区', N'A35', N'库克群岛', N'602', N'A35_602', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (478, N'国家和地区', N'A35', N'斐济', N'603', N'A35_603', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (479, N'国家和地区', N'A35', N'盖比群岛', N'604', N'A35_604', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (480, N'国家和地区', N'A35', N'马克萨斯群岛', N'605', N'A35_605', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (481, N'国家和地区', N'A35', N'脑鲁', N'606', N'A35_606', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (482, N'国家和地区', N'A35', N'新喀里多尼亚', N'607', N'A35_607', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (483, N'国家和地区', N'A35', N'瓦努阿图', N'608', N'A35_608', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (484, N'国家和地区', N'A35', N'新西兰', N'609', N'A35_609', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (485, N'国家和地区', N'A35', N'诺福克岛', N'610', N'A35_610', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (486, N'国家和地区', N'A35', N'巴布亚新几内亚', N'611', N'A35_611', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (487, N'国家和地区', N'A35', N'社会群岛', N'612', N'A35_612', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (488, N'国家和地区', N'A35', N'所罗门群岛', N'613', N'A35_613', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (489, N'国家和地区', N'A35', N'汤加', N'614', N'A35_614', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (490, N'国家和地区', N'A35', N'土阿莫土群岛', N'615', N'A35_615', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (491, N'国家和地区', N'A35', N'土布艾群岛', N'616', N'A35_616', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (492, N'国家和地区', N'A35', N'萨摩亚', N'617', N'A35_617', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (493, N'国家和地区', N'A35', N'基里巴斯', N'618', N'A35_618', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (494, N'国家和地区', N'A35', N'图瓦卢', N'619', N'A35_619', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (495, N'国家和地区', N'A35', N'密克罗尼西亚联邦', N'620', N'A35_620', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (496, N'国家和地区', N'A35', N'马绍尔群岛共和国', N'621', N'A35_621', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (497, N'国家和地区', N'A35', N'贝劳共和国', N'622', N'A35_622', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (498, N'国家和地区', N'A35', N'大洋洲其它国家(地区)', N'699', N'A35_699', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (499, N'国家和地区', N'A35', N'国(地)别不详的', N'701', N'A35_701', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (500, N'国家和地区', N'A35', N'联合国及所属机构和其它国际组织', N'702', N'A35_702', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (501, N'国家和地区', N'A35', N'香港特别行政区', N'1421', N'A35_1421', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (502, N'国家和地区', N'A35', N'澳门特别行政区', N'1422', N'A35_1422', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (503, N'国家和地区', N'A35', N'台湾省', N'1423', N'A35_1423', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (504, N'国家和地区', N'A35', N'亚洲其它国家(地区)', N'1990', N'A35_1990', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (505, N'权利人类型', N'A36', N'个人', N'1', N'A36_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (506, N'权利人类型', N'A36', N'企业', N'2', N'A36_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (507, N'权利人类型', N'A36', N'事业单位', N'3', N'A36_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (508, N'权利人类型', N'A36', N'国家机关', N'4', N'A36_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (509, N'权利人类型', N'A36', N'其它', N'99', N'A36_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (510, N'审核意见操作结果', N'A37', N'同意', N'1', N'A37_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (511, N'审核意见操作结果', N'A37', N'回退', N'2', N'A37_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (512, N'审核意见操作结果', N'A37', N'退件', N'3', N'A37_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (513, N'审核意见操作结果', N'A37', N'转件', N'4', N'A37_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (514, N'省市', N'A38', N'北京', N'110000', N'A38_110000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (515, N'省市', N'A38', N'天津', N'120000', N'A38_120000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (516, N'省市', N'A38', N'河北', N'130000', N'A38_130000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (517, N'省市', N'A38', N'山西', N'140000', N'A38_140000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (518, N'省市', N'A38', N'内蒙古', N'150000', N'A38_150000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (519, N'省市', N'A38', N'辽宁', N'210000', N'A38_210000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (520, N'省市', N'A38', N'吉林', N'220000', N'A38_220000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (521, N'省市', N'A38', N'黑龙江', N'230000', N'A38_230000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (522, N'省市', N'A38', N'上海', N'310000', N'A38_310000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (523, N'省市', N'A38', N'江苏', N'320000', N'A38_320000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (524, N'省市', N'A38', N'浙江', N'330000', N'A38_330000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (525, N'省市', N'A38', N'安徽', N'340000', N'A38_340000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (526, N'省市', N'A38', N'福建', N'350000', N'A38_350000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (527, N'省市', N'A38', N'江西', N'360000', N'A38_360000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (528, N'省市', N'A38', N'山东', N'370000', N'A38_370000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (529, N'省市', N'A38', N'河南', N'410000', N'A38_410000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (530, N'省市', N'A38', N'湖北', N'420000', N'A38_420000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (531, N'省市', N'A38', N'湖南', N'430000', N'A38_430000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (532, N'省市', N'A38', N'广东', N'440000', N'A38_440000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (533, N'省市', N'A38', N'广西', N'450000', N'A38_450000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (534, N'省市', N'A38', N'海南', N'460000', N'A38_460000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (535, N'省市', N'A38', N'重庆', N'500000', N'A38_500000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (536, N'省市', N'A38', N'四川', N'510000', N'A38_510000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (537, N'省市', N'A38', N'贵州', N'520000', N'A38_520000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (538, N'省市', N'A38', N'云南', N'530000', N'A38_530000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (539, N'省市', N'A38', N'西藏', N'540000', N'A38_540000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (540, N'省市', N'A38', N'陕西', N'610000', N'A38_610000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (541, N'省市', N'A38', N'甘肃', N'620000', N'A38_620000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (542, N'省市', N'A38', N'青海', N'630000', N'A38_630000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (543, N'省市', N'A38', N'宁夏', N'640000', N'A38_640000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (544, N'省市', N'A38', N'新疆', N'650000', N'A38_650000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (545, N'省市', N'A38', N'台湾', N'710000', N'A38_710000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (546, N'省市', N'A38', N'香港', N'810000', N'A38_810000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (547, N'省市', N'A38', N'澳门', N'820000', N'A38_820000', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (548, N'收费类型', N'A39', N'按件', N'1', N'A39_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (549, N'收费类型', N'A39', N'面积', N'2', N'A39_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (550, N'收费类型', N'A39', N'金额', N'3', N'A39_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (551, N'收费类型', N'A39', N'累进', N'4', N'A39_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (552, N'收费类型', N'A39', N'按套', N'5', N'A39_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (553, N'收费类型', N'A39', N'按证', N'6', N'A39_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (554, N'收件类型', N'A40', N'原件正本', N'1', N'A40_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (555, N'收件类型', N'A40', N'正本复印件', N'2', N'A40_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (556, N'收件类型', N'A40', N'原件副本', N'3', N'A40_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (557, N'收件类型', N'A40', N'副本复印件', N'4', N'A40_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (558, N'收件类型', N'A40', N'手稿', N'5', N'A40_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (559, N'收件类型', N'A40', N'其它', N'99', N'A40_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (560, N'所属行业', N'A41', N'交邮', N'1', N'A41_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (561, N'所属行业', N'A41', N'金融', N'2', N'A41_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (562, N'所属行业', N'A41', N'服务', N'3', N'A41_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (563, N'所属行业', N'A41', N'地勘', N'4', N'A41_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (564, N'所属行业', N'A41', N'工业', N'5', N'A41_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (565, N'所属行业', N'A41', N'商业', N'6', N'A41_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (566, N'所属行业', N'A41', N'房地产', N'7', N'A41_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (567, N'所属行业', N'A41', N'农业', N'8', N'A41_8', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (568, N'所属行业', N'A41', N'建筑', N'9', N'A41_9', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (569, N'所属行业', N'A41', N'其它', N'99', N'A41_99', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (570, N'通知方式', N'A42', N'电话', N'1', N'A42_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (571, N'通知方式', N'A42', N'移动电话', N'2', N'A42_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (572, N'通知方式', N'A42', N'电子邮件', N'3', N'A42_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (573, N'通知方式', N'A42', N'信函', N'4', N'A42_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (574, N'性别', N'A43', N'男性', N'1', N'A43_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (575, N'性别', N'A43', N'女性', N'2', N'A43_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (576, N'性别', N'A43', N'不详', N'3', N'A43_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (577, N'宗地（宗海）特征码', N'A44', N'集体土地所有权宗地', N'A', N'A44_A', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (578, N'宗地（宗海）特征码', N'A44', N'建设用地使用权宗地（地表）', N'B', N'A44_B', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (579, N'宗地（宗海）特征码', N'A44', N'建设用地使用权宗地（地上）', N'S', N'A44_S', 4, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (580, N'宗地（宗海）特征码', N'A44', N'建设用地使用权宗地（地下）', N'X', N'A44_X', 5, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (581, N'宗地（宗海）特征码', N'A44', N'宅基地使用权宗地', N'C', N'A44_C', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (582, N'宗地（宗海）特征码', N'A44', N'土地承包经营权宗地（耕地）', N'D', N'A44_D', 6, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (583, N'宗地（宗海）特征码', N'A44', N'土地承包经营权宗地（林地）', N'E', N'A44_E', 7, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (584, N'宗地（宗海）特征码', N'A44', N'土地承包经营权宗地（草地）', N'F', N'A44_F', 8, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (585, N'宗地（宗海）特征码', N'A44', N'海域使用权宗海', N'H', N'A44_H', 9, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (586, N'宗地（宗海）特征码', N'A44', N'无居民海岛使用权', N'G', N'A44_G', 10, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (587, N'宗地（宗海）特征码', N'A44', N'使用权未确定或有争议的土地或海域海岛', N'W', N'A44_W', 11, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (588, N'宗地（宗海）特征码', N'A44', N'其它使用权土地、海域、海岛', N'Y', N'A44_Y', 12, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (589, N'土地所有权性质', N'A45', N'国家所有', N'1', N'A45_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (590, N'土地所有权性质', N'A45', N'集体所有', N'2', N'A45_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (591, N'房屋结构', N'A46', N'钢结构', N'1', N'A46_1', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (592, N'房屋结构', N'A46', N'钢和钢筋混凝土结构', N'2', N'A46_2', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (593, N'房屋结构', N'A46', N'钢筋混凝土结构', N'3', N'A46_3', 1, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (594, N'房屋结构', N'A46', N'混合结构', N'4', N'A46_4', 4, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (595, N'房屋结构', N'A46', N'砖木结构', N'5', N'A46_5', 5, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (596, N'房屋结构', N'A46', N'其它结构', N'6', N'A46_6', 6, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (597, N'建筑物状态', N'A47', N'历史', N'1', N'A47_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (598, N'建筑物状态', N'A47', N'期房', N'2', N'A47_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (599, N'建筑物状态', N'A47', N'现房', N'3', N'A47_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (600, N'建筑物状态', N'A47', N'虚拟', N'4', N'A47_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (601, N'界址线类别', N'A48', N'围墙', N'1', N'A48_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (602, N'界址线类别', N'A48', N'墙壁', N'2', N'A48_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (603, N'界址线类别', N'A48', N'栅栏', N'3', N'A48_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (604, N'界址线类别', N'A48', N'铁丝网', N'4', N'A48_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (605, N'界址线类别', N'A48', N'滴水线', N'5', N'A48_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (606, N'界址线类别', N'A48', N'路涯线', N'6', N'A48_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (607, N'界址线类别', N'A48', N'两点连线', N'7', N'A48_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (608, N'界址线类别', N'A48', N'其它', N'9', N'A48_9', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (609, N'项目性质', N'A49', N'公益性', N'1', N'A49_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (610, N'项目性质', N'A49', N'经营性', N'2', N'A49_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (611, N'项目性质', N'A49', N'公益性和经营性', N'3', N'A49_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (612, N'土地等级', N'A50', N'一类', N'1', N'A50_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (613, N'土地等级', N'A50', N'二类', N'2', N'A50_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (614, N'土地等级', N'A50', N'三类', N'3', N'A50_3', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (615, N'土地等级', N'A50', N'四类', N'4', N'A50_4', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (616, N'土地等级', N'A50', N'五类', N'5', N'A50_5', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (617, N'土地等级', N'A50', N'六类', N'6', N'A50_6', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (618, N'土地等级', N'A50', N'七类', N'7', N'A50_7', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (619, N'土地等级', N'A50', N'八类', N'8', N'A50_8', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (620, N'土地等级', N'A50', N'九类', N'9', N'A50_9', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (621, N'土地等级', N'A50', N'十类', N'10', N'A50_10', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (622, N'用海方式', N'A51', N'建设填海造地', N'11', N'A51_11', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (623, N'用海方式', N'A51', N'农业填海造地', N'12', N'A51_12', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (624, N'用海方式', N'A51', N'废弃物处置填海造地', N'13', N'A51_13', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (625, N'用海方式', N'A51', N'非透水构筑物', N'21', N'A51_21', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (626, N'用海方式', N'A51', N'跨海桥梁、海底隧道', N'22', N'A51_22', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (627, N'用海方式', N'A51', N'透水构筑物', N'23', N'A51_23', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (628, N'用海方式', N'A51', N'港池、蓄水', N'31', N'A51_31', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (629, N'用海方式', N'A51', N'盐田', N'32', N'A51_32', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (630, N'用海方式', N'A51', N'围海养殖', N'33', N'A51_33', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (631, N'用海方式', N'A51', N'开放式养殖', N'41', N'A51_41', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (632, N'用海方式', N'A51', N'浴场', N'42', N'A51_42', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (633, N'用海方式', N'A51', N'游乐场', N'43', N'A51_43', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (634, N'用海方式', N'A51', N'专用航道、锚地及其它开放式', N'44', N'A51_44', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (635, N'用海方式', N'A51', N'人工岛式油气开采', N'51', N'A51_51', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (636, N'用海方式', N'A51', N'平台式油气开采', N'52', N'A51_52', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (637, N'用海方式', N'A51', N'海底电缆管道', N'53', N'A51_53', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (638, N'用海方式', N'A51', N'海砂等矿产开采', N'54', N'A51_54', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (639, N'用海方式', N'A51', N'取、排水口', N'55', N'A51_55', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (640, N'用海方式', N'A51', N'污水达标排放', N'56', N'A51_56', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (641, N'用海方式', N'A51', N'倾倒', N'57', N'A51_57', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (642, N'用海方式', N'A51', N'防护林种植', N'58', N'A51_58', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (643, N'起源', N'A52', N'天然林', N'1', N'A52_1', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (644, N'起源', N'A52', N'人工林', N'2', N'A52_2', NULL, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (645, N'所有权类型', N'C1', N'国家土地所有权', N'G', N'C1_G', 1, N'用于宗地代码')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (646, N'所有权类型', N'C1', N'集体土地所有权', N'J', N'C1_J', 2, N'用于宗地代码')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (647, N'定着物特征码', N'C2', N'无定着物', N'W', N'C2_W', 1, N'')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (648, N'定着物特征码', N'C2', N'森林或林木', N'L', N'C2_L', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (649, N'定着物特征码', N'C2', N'房屋等建筑物、构筑物', N'F', N'C2_F', 3, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (650, N'定着物特征码', N'C2', N'其他类型的定着物', N'Q', N'C2_Q', 4, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (651, N'土地用途', N'C3', N'水田', N'11', N'C3_11', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (652, N'土地用途', N'C3', N'水浇地', N'12', N'C3_12', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (653, N'土地用途', N'C3', N'旱地', N'13', N'C3_13', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (654, N'土地用途', N'C3', N'果园', N'21', N'C3_21', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (655, N'土地用途', N'C3', N'茶园', N'22', N'C3_22', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (656, N'土地用途', N'C3', N'其他园地', N'23', N'C3_23', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (657, N'土地用途', N'C3', N'有林地', N'31', N'C3_31', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (658, N'土地用途', N'C3', N'灌木林地', N'32', N'C3_32', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (659, N'土地用途', N'C3', N'其他林地', N'33', N'C3_33', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (660, N'土地用途', N'C3', N'天然牧草地', N'41', N'C3_41', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (661, N'土地用途', N'C3', N'人工牧草地', N'42', N'C3_42', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (662, N'土地用途', N'C3', N'其他草地', N'43', N'C3_43', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (663, N'土地用途', N'C3', N'批发零售用地', N'51', N'C3_51', 3, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (664, N'土地用途', N'C3', N'住宿餐饮用地', N'52', N'C3_52', 4, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (665, N'土地用途', N'C3', N'商务金融用地', N'53', N'C3_53', 5, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (666, N'土地用途', N'C3', N'其他商服用地', N'54', N'C3_54', 6, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (667, N'土地用途', N'C3', N'工业用地', N'61', N'C3_61', 7, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (668, N'土地用途', N'C3', N'采矿用地', N'62', N'C3_62', 8, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (669, N'土地用途', N'C3', N'仓储用地', N'63', N'C3_63', 9, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (670, N'土地用途', N'C3', N'城镇住宅用地', N'71', N'C3_71', 1, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (671, N'土地用途', N'C3', N'农村宅基地', N'72', N'C3_72', 2, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (672, N'土地用途', N'C3', N'机关团体用地', N'81', N'C3_81', 10, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (673, N'土地用途', N'C3', N'新闻出版用地', N'82', N'C3_82', 11, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (674, N'土地用途', N'C3', N'科教用地', N'83', N'C3_83', 12, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (675, N'土地用途', N'C3', N'医卫慈善用地', N'84', N'C3_84', 13, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (676, N'土地用途', N'C3', N'文体娱乐用地', N'85', N'C3_85', 14, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (677, N'土地用途', N'C3', N'公共设施用地', N'86', N'C3_86', 15, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (678, N'土地用途', N'C3', N'公园与绿地', N'87', N'C3_87', 16, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (679, N'土地用途', N'C3', N'风景名胜设施用地', N'88', N'C3_88', 17, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (680, N'土地用途', N'C3', N'军事设施用地', N'91', N'C3_91', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (681, N'土地用途', N'C3', N'使领馆用地', N'92', N'C3_92', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (682, N'土地用途', N'C3', N'监教场所用地', N'93', N'C3_93', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (683, N'土地用途', N'C3', N'宗教用地', N'94', N'C3_94', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (684, N'土地用途', N'C3', N'殡葬用地', N'95', N'C3_95', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (685, N'土地用途', N'C3', N'铁路用地', N'101', N'C3_101', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (686, N'土地用途', N'C3', N'公路用地', N'102', N'C3_102', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (687, N'土地用途', N'C3', N'街巷用地', N'103', N'C3_103', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (688, N'土地用途', N'C3', N'农村道路', N'104', N'C3_104', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (689, N'土地用途', N'C3', N'机场用地', N'105', N'C3_105', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (690, N'土地用途', N'C3', N'港口码头用地', N'106', N'C3_106', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (691, N'土地用途', N'C3', N'管道运输用地', N'107', N'C3_107', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (692, N'土地用途', N'C3', N'河流水面', N'111', N'C3_111', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (693, N'土地用途', N'C3', N'湖泊水面', N'112', N'C3_112', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (694, N'土地用途', N'C3', N'水库水面', N'113', N'C3_113', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (695, N'土地用途', N'C3', N'坑塘水面', N'114', N'C3_114', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (696, N'土地用途', N'C3', N'沿海滩涂', N'115', N'C3_115', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (697, N'土地用途', N'C3', N'内陆滩涂', N'116', N'C3_116', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (698, N'土地用途', N'C3', N'沟渠', N'117', N'C3_117', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (699, N'土地用途', N'C3', N'水工建筑用地', N'118', N'C3_118', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (700, N'土地用途', N'C3', N'冰川及永久积雪', N'119', N'C3_119', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (701, N'土地用途', N'C3', N'空闲地', N'121', N'C3_121', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (702, N'土地用途', N'C3', N'设施农业用地', N'122', N'C3_122', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (703, N'土地用途', N'C3', N'田坎', N'123', N'C3_123', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (704, N'土地用途', N'C3', N'盐碱地', N'124', N'C3_124', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (705, N'土地用途', N'C3', N'沼泽地', N'125', N'C3_125', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (706, N'土地用途', N'C3', N'沙地', N'126', N'C3_126', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (707, N'土地用途', N'C3', N'裸地', N'127', N'C3_127', NULL, N'土地利用现状二级分类')
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (708, N'权籍调查项目类型', N'C4', N'宗地\林地\自然幢', N'1', N'C4_1', 2, NULL)
GO
INSERT [dbo].[DataItems] ([fid], [typeName], [typeCode], [itemName], [itemCode], [code], [itemOrder], [remark]) VALUES (709, N'权籍调查项目类型', N'C4', N'房屋（户）', N'2', N'C4_2', 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[DataItems] OFF
GO
