USE [master]
GO
/****** Object:  Database [dbDiablo3]    Script Date: 14/8/2023 16:59:49 ******/
CREATE DATABASE [dbDiablo3]

ALTER DATABASE [dbDiablo3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbDiablo3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbDiablo3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbDiablo3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbDiablo3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbDiablo3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbDiablo3] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbDiablo3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbDiablo3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbDiablo3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbDiablo3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbDiablo3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbDiablo3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbDiablo3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbDiablo3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbDiablo3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbDiablo3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbDiablo3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbDiablo3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbDiablo3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbDiablo3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbDiablo3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbDiablo3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbDiablo3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbDiablo3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbDiablo3] SET  MULTI_USER 
GO
ALTER DATABASE [dbDiablo3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbDiablo3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbDiablo3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbDiablo3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbDiablo3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbDiablo3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbDiablo3] SET QUERY_STORE = OFF
GO
USE [dbDiablo3]
GO
/****** Object:  Table [dbo].[Atributo]    Script Date: 14/8/2023 16:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atributo](
	[idAtributo] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idPersonaje] [int] NOT NULL,
 CONSTRAINT [PK_Atributo] PRIMARY KEY CLUSTERED 
(
	[idAtributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habilidad]    Script Date: 14/8/2023 16:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habilidad](
	[idHabilidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[idPersonaje] [int] NOT NULL,
 CONSTRAINT [PK_Habilidad] PRIMARY KEY CLUSTERED 
(
	[idHabilidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 14/8/2023 16:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[idItem] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idPersonaje] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[idItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personaje]    Script Date: 14/8/2023 16:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personaje](
	[idPersonaje] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Personaje] PRIMARY KEY CLUSTERED 
(
	[idPersonaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salud]    Script Date: 14/8/2023 16:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salud](
	[IdSalud] [int] IDENTITY(1,1) NOT NULL,
	[Porcentaje] [decimal](18, 2) NOT NULL,
	[IdPersonaje] [int] NOT NULL,
 CONSTRAINT [PK_Salud] PRIMARY KEY CLUSTERED 
(
	[IdSalud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Habilidad] ON 
GO
INSERT [dbo].[Habilidad] ([idHabilidad], [nombre], [tipo], [idPersonaje]) VALUES (1, N'Espada de caída', N'Convicción', 1)
GO
INSERT [dbo].[Habilidad] ([idHabilidad], [nombre], [tipo], [idPersonaje]) VALUES (2, N'Tajo', N'Primaria', 1)
GO
INSERT [dbo].[Habilidad] ([idHabilidad], [nombre], [tipo], [idPersonaje]) VALUES (3, N'Castigo', N'Primaria', 1)
GO
INSERT [dbo].[Habilidad] ([idHabilidad], [nombre], [tipo], [idPersonaje]) VALUES (4, N'Escarmiento', N'Primaria', 1)
GO
SET IDENTITY_INSERT [dbo].[Habilidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Personaje] ON 
GO
INSERT [dbo].[Personaje] ([idPersonaje], [tipo], [nombre]) VALUES (1, N'Guerrero', N'Apriken')
GO
INSERT [dbo].[Personaje] ([idPersonaje], [tipo], [nombre]) VALUES (2, N'Enemigo_1', N'Berserk')
GO
INSERT [dbo].[Personaje] ([idPersonaje], [tipo], [nombre]) VALUES (3, N'Enemigo_2', N'Chaman')
GO
INSERT [dbo].[Personaje] ([idPersonaje], [tipo], [nombre]) VALUES (4, N'Enemigo_3', N'Orco Warrior')
GO
SET IDENTITY_INSERT [dbo].[Personaje] OFF
GO
SET IDENTITY_INSERT [dbo].[Salud] ON 
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (1, CAST(30.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (2, CAST(350.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (3, CAST(20.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (4, CAST(470.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (5, CAST(220.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (6, CAST(520.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (7, CAST(280.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (8, CAST(70.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (9, CAST(290.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (10, CAST(580.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (11, CAST(290.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (12, CAST(700.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (13, CAST(290.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Salud] ([IdSalud], [Porcentaje], [IdPersonaje]) VALUES (14, CAST(580.00 AS Decimal(18, 2)), 2)
GO
SET IDENTITY_INSERT [dbo].[Salud] OFF
GO
ALTER TABLE [dbo].[Atributo]  WITH CHECK ADD  CONSTRAINT [fk_Atributo_pk_Personaje] FOREIGN KEY([idPersonaje])
REFERENCES [dbo].[Personaje] ([idPersonaje])
GO
ALTER TABLE [dbo].[Atributo] CHECK CONSTRAINT [fk_Atributo_pk_Personaje]
GO
ALTER TABLE [dbo].[Habilidad]  WITH CHECK ADD  CONSTRAINT [fk_Habilidad_pk_Personaje] FOREIGN KEY([idPersonaje])
REFERENCES [dbo].[Personaje] ([idPersonaje])
GO
ALTER TABLE [dbo].[Habilidad] CHECK CONSTRAINT [fk_Habilidad_pk_Personaje]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [fk_Item_pk_Personaje] FOREIGN KEY([idPersonaje])
REFERENCES [dbo].[Personaje] ([idPersonaje])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [fk_Item_pk_Personaje]
GO
ALTER TABLE [dbo].[Salud]  WITH CHECK ADD  CONSTRAINT [pk_Personaje_fk_Salud] FOREIGN KEY([IdPersonaje])
REFERENCES [dbo].[Personaje] ([idPersonaje])
GO
ALTER TABLE [dbo].[Salud] CHECK CONSTRAINT [pk_Personaje_fk_Salud]
GO
USE [master]
GO
ALTER DATABASE [dbDiablo3] SET  READ_WRITE 
GO
