USE [Test]
GO
/****** Object:  Table [dbo].[Citys]    Script Date: 6/26/2021 3:44:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citys](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CityName] [nvarchar](50) NULL,
	[Orders] [int] NULL,
 CONSTRAINT [PK_Citys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Citys] ON 

INSERT [dbo].[Citys] ([ID], [CityName], [Orders]) VALUES (1, N'Dhaka', 5)
INSERT [dbo].[Citys] ([ID], [CityName], [Orders]) VALUES (2, N'Chitagong', 4)
INSERT [dbo].[Citys] ([ID], [CityName], [Orders]) VALUES (3, N'Sylhet', 3)
INSERT [dbo].[Citys] ([ID], [CityName], [Orders]) VALUES (4, N'Khulna', 10)
SET IDENTITY_INSERT [dbo].[Citys] OFF

-- Second MAX --
SELECT MAX(Orders) AS Orders 
FROM Citys 
WHERE Orders <(SELECT MAX(Orders) 
FROM Citys)


-- Second MAX --
SELECT * 
FROM Citys 
ORDER BY Orders DESC 
OFFSET (1) ROWS FETCH NEXT (1) ROWS ONLY


-- Second MIN --
SELECT * 
FROM Citys 
ORDER BY Orders ASC 
OFFSET (1) ROWS FETCH NEXT (1) ROWS ONLY