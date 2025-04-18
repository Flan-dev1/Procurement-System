USE [master]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1082, N'Ballpens')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1083, N'NoteBook')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1084, N'Bag')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1085, N'Paper')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1086, N'Pencils')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1087, N'Erasers')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1088, N'Calculator')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1089, N'Ruler')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1090, N'Backpack')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1091, N'Scissors')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1092, N'Markers')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1093, N'Tapes')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1094, N'Crayons')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1095, N'Sharpeners')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1096, N'Cases')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1097, N'Glues')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1098, N'Highlighter')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1001, N'Acme Book Store', N'Looney Tunes Inc.', N'acme@looneytunes.com', 1001)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1002, N'Pandayan BookStore', N'Hagonoy Bulacan', N'pandayanbookstore@yahoo.com', 1001)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1005, N'Sandugo BookStore', N'Hagonoy Bulacan', N'pandayanbookstore@yahoo.com', 1001)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1055, N'Acute Triangle Supplies', N'B.S Aquino Avenue 3006 Baliuag Central Luzon', N'acutetrianglesupplies@yahoo.com', 1001)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1056, N'SchoolMate Plus', N'0976 Ma.Lourdes Tabang Plaridel Bulacan', N'schoolmateplus@yahoo.com', 1020)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1057, N'School Supply Alley', N'076 Sagrada Familia Hagonoy Bulacan', N'schoolsupplyalley@yahoo.com', 1021)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1058, N'Supply & pens', N'44 Pulilan Regional Road, Tabon Pulilan Bulacan', N'supplynpens@yahoo.com', 1022)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1059, N'The Supply Studies', N'Room 203, 169 Paseo del Congreso St, Malolos Bulacan ', N'thesupplystudies@yahoo.com', 1023)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1060, N'Magic Horse Supply', N'739 Ma. Ramona Tabang Plaridel Bulacan', N'magichorsesupply@yahoo.com', 1001)
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Address], [SupplierEmail], [PaymentTermsID]) VALUES (1061, N'The Educational Hut', N'32 Rocka Village II Tabang Plaridel Bulacan', N'theeducationalhut@yahoo.com', 1020)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemType] ON 

INSERT [dbo].[ItemType] ([ItemTypeID], [TypeName]) VALUES (1004, N'Fast Moving Items')
INSERT [dbo].[ItemType] ([ItemTypeID], [TypeName]) VALUES (1005, N'Non Fast Moving Items')
SET IDENTITY_INSERT [dbo].[ItemType] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1067, N'White Board Marker', N'black', 80, 35, N'No Description Provided', 1092, 1004, 1061)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1068, N'Avery Glue', N'white', 108, 40, N'No Descriptio Provided', 1097, 1004, 1001)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1069, N'Jansport Student Bag', N'blue', 95, 450, N'No Description Provided', 1084, 1004, 1002)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1070, N'Tape Eraser', N'white', 205, 62, N'No Description Provided', 1093, 1004, 1005)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1071, N'Kokuyo Camlin Crayons', N'mix colors', 105, 150, N'No Description Provided', 1094, 1004, 1055)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1072, N'Masking Tape', N'white', 75, 36, N'No Description Provided', 1093, 1004, 1056)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1073, N'Sharpie Clear View Chisel Tip', N'yellow green', 45, 78, N'No Description Provided', 1098, 1004, 1057)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1074, N'Belmont Scissors', N'red', 89, 32, N'No Description Provided', 1091, 1004, 1058)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1075, N'Wescott Flexible 12-inch Ruler', N'white', 76, 20, N'No Description Provided', 1090, 1004, 1059)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1076, N'CIAK Notebook', N'red', 99, 99.75, N'No Description Provided', 1083, 1004, 1001)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1077, N'American Pencil', N'yellow', 399, 39.75, N'No Description Provided', 1086, 1004, 1002)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1078, N'Parker Pens Black Ballpen', N'black', 299, 59.75, N'No Description Provided', 1082, 1004, 1005)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1079, N'Parker Pens Red Ballpen', N'red', 299, 59.75, N'No Description Provided', 1082, 1004, 1005)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1080, N'Faber Castell', N'any', 10, 149.75, N'No Description Provided', 1094, 1004, 1005)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1081, N'Herschel Pencil Case', N'blue', 59, 199.75, N'No Description Provided', 1096, 1004, 1055)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1082, N'BAZIC Ruler', N'ruler', 199, 19.75, N'No Description Provided', 1089, 1004, 1056)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1083, N'Prismacolor Artgum Eraser', N'no color', 99, 19.75, N'No Description Provided', 1087, 1004, 1057)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1084, N'Copic Marker', N'blue', 199, 29.75, N'No Description Provided', 1092, 1004, 1059)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1085, N'Bostitch Electric Pencil Sharpener', N'any', 99, 19.75, N'No Description Provided', 1095, 1004, 1060)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1086, N'Pilot White Board Marker', N'black', 40, 52, N'No Description Provided', 1092, 1004, 1001)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1087, N'R-Tec White Glue', N'white', 35, 24, N'No Descriptio Provided', 1097, 1004, 1005)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1088, N'Hawk Bag', N'Black', 50, 1160, N'No Description Provided', 1090, 1005, 1002)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1089, N'Joy Correction Tape', N'white', 130, 44, N'No Description Provided', 1093, 1004, 1055)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1090, N'CraZart Crayons', N'mix colors', 150, 95, N'No Description Provided', 1094, 1004, 1056)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1091, N'CrafZilla Masking Tape', N'white', 145, 66, N'No Description Provided', 1093, 1004, 1057)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1092, N'Staedtler Compass', N'blue', 199, 88.75, N'No Description Provided', 1089, 1004, 1058)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1093, N'Stabilo Highlighter Pen', N'yellow green', 78, 48, N'No Description Provided', 1092, 1004, 1059)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1094, N'WestCott Scissor', N'red', 89, 50, N'No Description Provided', 1091, 1004, 1060)
INSERT [dbo].[Items] ([ItemID], [ItemName], [Color], [Quantity], [Price], [Description], [CategoryID], [ItemTypeID], [SupplierID]) VALUES (1095, N'WestCott Ruler', N'white', 76, 25, N'No Description Provided', 1089, 1004, 1061)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
