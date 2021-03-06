USE [master]
GO
/****** Object:  Database [SchoolCourse]    Script Date: 12.01.2021 13:06:22 ******/
CREATE DATABASE [SchoolCourse]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolCourse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolCourse.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolCourse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolCourse_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolCourse] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolCourse].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolCourse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolCourse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolCourse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolCourse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolCourse] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolCourse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolCourse] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolCourse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolCourse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolCourse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolCourse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolCourse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolCourse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolCourse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolCourse] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolCourse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolCourse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolCourse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolCourse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolCourse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolCourse] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolCourse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolCourse] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolCourse] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolCourse] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolCourse] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolCourse] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolCourse] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolCourse] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolCourse] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolCourse] SET QUERY_STORE = OFF
GO
USE [SchoolCourse]
GO
/****** Object:  Table [dbo].[AdditionalActivity]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdditionalActivity](
	[Activity_ID] [int] IDENTITY(1,1) NOT NULL,
	[Activity_name] [nvarchar](200) NOT NULL,
	[Activity_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Activity_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdditionalParticipation]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdditionalParticipation](
	[Pupil_ID] [int] NOT NULL,
	[Activity_ID] [int] NOT NULL,
	[Distribution_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pupil_ID] ASC,
	[Activity_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JournalRecord]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JournalRecord](
	[Record_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pupil_ID] [int] NOT NULL,
	[Test_ID] [int] NOT NULL,
	[Score] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Record_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Payment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pupil_ID] [int] NOT NULL,
	[PaymentRate_ID] [int] NOT NULL,
	[Month] [nvarchar](50) NOT NULL,
	[Paid] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Payment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentRate]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentRate](
	[PaymentRate_ID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentRate_type] [nvarchar](50) NOT NULL,
	[Sum] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentRate_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonnelFile]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonnelFile](
	[Pupil_ID] [int] NOT NULL,
	[SNP_father] [nvarchar](150) NOT NULL,
	[SNP_mother] [nvarchar](150) NOT NULL,
	[SNP_custodian] [nvarchar](150) NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pupil_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PointsDistribution]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointsDistribution](
	[Distribution_ID] [int] IDENTITY(1,1) NOT NULL,
	[Place] [nvarchar](50) NOT NULL,
	[Points] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Distribution_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pupil]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pupil](
	[Pupil_ID] [int] IDENTITY(1,1) NOT NULL,
	[SNP] [nvarchar](150) NOT NULL,
	[Gender] [nvarchar](1) NOT NULL,
	[BirthDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pupil_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Subject_abbr] [nvarchar](20) NOT NULL,
	[Subject_name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Subject_abbr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Test_ID] [int] IDENTITY(1,1) NOT NULL,
	[Subject_abbr] [nvarchar](20) NOT NULL,
	[Test_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Test_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12.01.2021 13:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdditionalActivity] ON 

INSERT [dbo].[AdditionalActivity] ([Activity_ID], [Activity_name], [Activity_date]) VALUES (1, N'Волонтерство "Друзі зоопарку"', CAST(N'2020-11-04' AS Date))
INSERT [dbo].[AdditionalActivity] ([Activity_ID], [Activity_name], [Activity_date]) VALUES (2, N'Районна олімпіада з математики', CAST(N'2020-11-12' AS Date))
INSERT [dbo].[AdditionalActivity] ([Activity_ID], [Activity_name], [Activity_date]) VALUES (3, N'Всеукраїнський конкурс "Кенгуру"', CAST(N'2020-11-26' AS Date))
INSERT [dbo].[AdditionalActivity] ([Activity_ID], [Activity_name], [Activity_date]) VALUES (4, N'Міський атлетичний марафон', CAST(N'2020-11-29' AS Date))
SET IDENTITY_INSERT [dbo].[AdditionalActivity] OFF
GO
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (1, 1, 1)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (1, 3, 1)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (2, 1, 1)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (2, 2, 3)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (3, 1, 1)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (3, 2, 1)
INSERT [dbo].[AdditionalParticipation] ([Pupil_ID], [Activity_ID], [Distribution_ID]) VALUES (3, 3, 1)
GO
SET IDENTITY_INSERT [dbo].[JournalRecord] ON 

INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (1, 1, 2, 10)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (2, 1, 3, 11)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (3, 1, 4, 8)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (4, 1, 6, 9)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (5, 1, 7, 11)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (6, 1, 8, 10)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (7, 2, 2, 11)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (8, 2, 3, 12)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (9, 2, 4, 7)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (10, 2, 7, 9)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (11, 2, 8, 9)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (12, 2, 9, 10)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (13, 3, 2, 10)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (14, 3, 5, 11)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (15, 3, 6, 12)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (16, 3, 7, 10)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (17, 3, 8, 9)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (18, 3, 9, 9)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (19, 1, 11, 6)
INSERT [dbo].[JournalRecord] ([Record_ID], [Pupil_ID], [Test_ID], [Score]) VALUES (20, 1, 13, 6)
SET IDENTITY_INSERT [dbo].[JournalRecord] OFF
GO
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (5, 3, 2, N'грудень', 1)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (6, 3, 2, N'листопад', 1)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (20, 1, 4, N'листопад', 1)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (21, 1, 4, N'грудень', 0)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (22, 2, 2, N'листопад', 1)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (23, 2, 3, N'грудень', 0)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (25, 3, 4, N'січень', 0)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (26, 2, 4, N'січень', 0)
INSERT [dbo].[Payment] ([Payment_ID], [Pupil_ID], [PaymentRate_ID], [Month], [Paid]) VALUES (27, 1, 4, N'січень', 0)
SET IDENTITY_INSERT [dbo].[Payment] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentRate] ON 

INSERT [dbo].[PaymentRate] ([PaymentRate_ID], [PaymentRate_type], [Sum]) VALUES (2, N'Зменшений', 390)
INSERT [dbo].[PaymentRate] ([PaymentRate_ID], [PaymentRate_type], [Sum]) VALUES (3, N'Збільшений', 650)
INSERT [dbo].[PaymentRate] ([PaymentRate_ID], [PaymentRate_type], [Sum]) VALUES (4, N'Стандартний', 520)
SET IDENTITY_INSERT [dbo].[PaymentRate] OFF
GO
INSERT [dbo].[PersonnelFile] ([Pupil_ID], [SNP_father], [SNP_mother], [SNP_custodian], [Address], [Phone]) VALUES (1, N'Єгоров Микита Васильович', N'Єгорова Марія Василівна', N'–', N'пр. Гагаріна 49А, кв. 237', N'0677603074')
INSERT [dbo].[PersonnelFile] ([Pupil_ID], [SNP_father], [SNP_mother], [SNP_custodian], [Address], [Phone]) VALUES (2, N'Лукін Іван Іванович', N'Лукіна Олена Робертівна', N'–', N'вул. Першотравнева 55, кв. 17', N'0509568715')
INSERT [dbo].[PersonnelFile] ([Pupil_ID], [SNP_father], [SNP_mother], [SNP_custodian], [Address], [Phone]) VALUES (3, N'Король Сергій Петрович', N'Король Світлана Павлівна', N'–', N'вул. Робітників 10, кв. 20', N'0677514543')
INSERT [dbo].[PersonnelFile] ([Pupil_ID], [SNP_father], [SNP_mother], [SNP_custodian], [Address], [Phone]) VALUES (4, N'Перепелиця Юрій Андрійович', N'Перепелиця Наталя Максимівна', N'–', N'вул. Захисників, 55, кв. 20', N'0988632245')
GO
SET IDENTITY_INSERT [dbo].[PointsDistribution] ON 

INSERT [dbo].[PointsDistribution] ([Distribution_ID], [Place], [Points]) VALUES (1, N'Без місця', 2)
INSERT [dbo].[PointsDistribution] ([Distribution_ID], [Place], [Points]) VALUES (2, N'Перше місце', 4)
INSERT [dbo].[PointsDistribution] ([Distribution_ID], [Place], [Points]) VALUES (3, N'Друге місце', 3)
INSERT [dbo].[PointsDistribution] ([Distribution_ID], [Place], [Points]) VALUES (4, N'Третє місце', 2)
SET IDENTITY_INSERT [dbo].[PointsDistribution] OFF
GO
SET IDENTITY_INSERT [dbo].[Pupil] ON 

INSERT [dbo].[Pupil] ([Pupil_ID], [SNP], [Gender], [BirthDate]) VALUES (1, N'Єгоров Максим Микитович', N'Ч', CAST(N'2008-04-03' AS Date))
INSERT [dbo].[Pupil] ([Pupil_ID], [SNP], [Gender], [BirthDate]) VALUES (2, N'Лукіна Лілія Іванівна', N'Ж', CAST(N'2008-12-22' AS Date))
INSERT [dbo].[Pupil] ([Pupil_ID], [SNP], [Gender], [BirthDate]) VALUES (3, N'Король Анна Сергіївна', N'Ж', CAST(N'2008-01-01' AS Date))
INSERT [dbo].[Pupil] ([Pupil_ID], [SNP], [Gender], [BirthDate]) VALUES (4, N'Перепелиця Кирило Юрійович', N'Ч', CAST(N'2008-07-17' AS Date))
SET IDENTITY_INSERT [dbo].[Pupil] OFF
GO
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'АнглМ', N'Англійська мова')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'Інф', N'Інформатика')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'Іст', N'Історія')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'Матем', N'Математика')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'Мист', N'Мистецтво')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'УкрЛ', N'Українська література')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'УкрМ', N'Українська мова')
INSERT [dbo].[Subject] ([Subject_abbr], [Subject_name]) VALUES (N'Фізра', N'Фізкультура')
GO
SET IDENTITY_INSERT [dbo].[Test] ON 

INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (2, N'АнглМ', CAST(N'2020-11-07' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (3, N'Інф', CAST(N'2020-11-08' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (4, N'Іст', CAST(N'2020-11-08' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (5, N'Матем', CAST(N'2020-11-09' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (6, N'Мист', CAST(N'2020-11-09' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (7, N'УкрЛ', CAST(N'2020-11-10' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (8, N'УкрМ', CAST(N'2020-11-10' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (9, N'Фізра', CAST(N'2020-11-10' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (11, N'АнглМ', CAST(N'2020-11-23' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (12, N'Матем', CAST(N'2020-11-23' AS Date))
INSERT [dbo].[Test] ([Test_ID], [Subject_abbr], [Test_date]) VALUES (13, N'Інф', CAST(N'2020-11-23' AS Date))
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (1, N'Сільченко Галина Володимирівна', N'27031961', N'Класний керівник')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (2, N'Гога Сергій Іванович', N'19031963', N'Директор')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (3, N'Єгоров Микита Васильович', N'1', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (4, N'Єгорова Марія Василівна', N'1', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (5, N'Лукін Іван Іванович', N'2', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (6, N'Лукіна Олена Робертівна', N'2', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (8, N'Король Сергій Петрович', N'3', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (9, N'Король Світлана Павлівна', N'3', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (10, N'Перепелиця Юрій Андрійович', N'4', N'Один з батьків/Опікун')
INSERT [dbo].[User] ([User_ID], [Login], [Password], [Status]) VALUES (11, N'Перепелиця Наталя Максимівна', N'4', N'Один з батьків/Опікун')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  Index [UQ__Addition__5CFE3D4195649B7F]    Script Date: 12.01.2021 13:06:22 ******/
ALTER TABLE [dbo].[AdditionalActivity] ADD UNIQUE NONCLUSTERED 
(
	[Activity_date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Personne__5C7E359E30375F81]    Script Date: 12.01.2021 13:06:22 ******/
ALTER TABLE [dbo].[PersonnelFile] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PersonnelFile] ADD  DEFAULT ('-') FOR [SNP_custodian]
GO
ALTER TABLE [dbo].[AdditionalParticipation]  WITH CHECK ADD FOREIGN KEY([Activity_ID])
REFERENCES [dbo].[AdditionalActivity] ([Activity_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AdditionalParticipation]  WITH CHECK ADD FOREIGN KEY([Distribution_ID])
REFERENCES [dbo].[PointsDistribution] ([Distribution_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AdditionalParticipation]  WITH CHECK ADD FOREIGN KEY([Pupil_ID])
REFERENCES [dbo].[Pupil] ([Pupil_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JournalRecord]  WITH CHECK ADD FOREIGN KEY([Pupil_ID])
REFERENCES [dbo].[Pupil] ([Pupil_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JournalRecord]  WITH CHECK ADD FOREIGN KEY([Test_ID])
REFERENCES [dbo].[Test] ([Test_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([PaymentRate_ID])
REFERENCES [dbo].[PaymentRate] ([PaymentRate_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([Pupil_ID])
REFERENCES [dbo].[Pupil] ([Pupil_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonnelFile]  WITH CHECK ADD FOREIGN KEY([Pupil_ID])
REFERENCES [dbo].[Pupil] ([Pupil_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Test]  WITH CHECK ADD FOREIGN KEY([Subject_abbr])
REFERENCES [dbo].[Subject] ([Subject_abbr])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [SchoolCourse] SET  READ_WRITE 
GO
