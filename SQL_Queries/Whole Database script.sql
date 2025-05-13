USE [master]
GO
/****** Object:  Database [flex_trainer]    Script Date: 12/05/2024 11:46:56 pm ******/
CREATE DATABASE [flex_trainer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'flex_trainer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\flex_trainer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'flex_trainer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\flex_trainer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [flex_trainer] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [flex_trainer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [flex_trainer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [flex_trainer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [flex_trainer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [flex_trainer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [flex_trainer] SET ARITHABORT OFF 
GO
ALTER DATABASE [flex_trainer] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [flex_trainer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [flex_trainer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [flex_trainer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [flex_trainer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [flex_trainer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [flex_trainer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [flex_trainer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [flex_trainer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [flex_trainer] SET  ENABLE_BROKER 
GO
ALTER DATABASE [flex_trainer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [flex_trainer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [flex_trainer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [flex_trainer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [flex_trainer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [flex_trainer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [flex_trainer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [flex_trainer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [flex_trainer] SET  MULTI_USER 
GO
ALTER DATABASE [flex_trainer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [flex_trainer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [flex_trainer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [flex_trainer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [flex_trainer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [flex_trainer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [flex_trainer] SET QUERY_STORE = ON
GO
ALTER DATABASE [flex_trainer] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [flex_trainer]
GO
/****** Object:  Table [dbo].[account]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[email] [varchar](30) NULL,
	[password] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[firstname] [varchar](20) NULL,
	[lastname] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[gender] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[appointment_id] [int] IDENTITY(1,1) NOT NULL,
	[appointment_date] [date] NULL,
	[member_id] [int] NULL,
	[trainer_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diet_plan]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diet_plan](
	[plan_id] [int] IDENTITY(1,1) NOT NULL,
	[plan_name] [varchar](20) NULL,
	[details] [varchar](100) NULL,
	[creator] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exercise]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exercise](
	[exercise_id] [int] IDENTITY(1,1) NOT NULL,
	[plan_id] [int] NULL,
	[details] [varchar](50) NULL,
	[name] [varchar](20) NULL,
	[e_sets] [int] NULL,
	[rest_interval] [int] NULL,
	[target_muscle] [varchar](20) NULL,
	[reps] [int] NULL,
	[machine] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[exercise_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[feedback_id] [int] IDENTITY(1,1) NOT NULL,
	[fdate] [date] NULL,
	[details] [varchar](100) NULL,
	[username] [varchar](20) NULL,
	[trainer_name] [varchar](20) NULL,
	[rating] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[feedback_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gym]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gym](
	[gymid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NULL,
	[address] [varchar](50) NULL,
	[owner_id] [int] NULL,
	[membership_price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[gymid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gym_owner]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gym_owner](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[firstname] [varchar](20) NULL,
	[lastname] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[gender] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gym_owner_request]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gym_owner_request](
	[member_id] [int] NULL,
	[name] [varchar](20) NULL,
	[address] [varchar](50) NULL,
	[membership_price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gym_review]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gym_review](
	[review_id] [int] IDENTITY(1,1) NOT NULL,
	[gym_id] [int] NULL,
	[Username] [varchar](20) NULL,
	[rating] [int] NULL,
	[details] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[review_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logs]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logs](
	[logid] [int] IDENTITY(1,1) NOT NULL,
	[information] [varchar](50) NULL,
	[affected] [varchar](50) NULL,
	[Event_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[logid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[meals]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meals](
	[meal_id] [int] IDENTITY(1,1) NOT NULL,
	[plan_id] [int] NULL,
	[name] [varchar](50) NULL,
	[proteins] [decimal](10, 2) NULL,
	[fats] [decimal](10, 2) NULL,
	[fibre] [decimal](10, 2) NULL,
	[carbs] [decimal](10, 2) NULL,
	[details] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[meal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[firstname] [varchar](20) NULL,
	[lastname] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[gender] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member_diet]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member_diet](
	[member_id] [int] NULL,
	[diet_plan_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member_workout]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member_workout](
	[member_id] [int] NULL,
	[workout_plan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[membership]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[membership](
	[membership_id] [int] IDENTITY(1,1) NOT NULL,
	[duration] [varchar](20) NULL,
	[member_id] [int] NULL,
	[gym_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[membership_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trainer]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trainer](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[firstname] [varchar](20) NULL,
	[lastname] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[gender] [varchar](10) NULL,
	[specialization] [varchar](50) NULL,
	[gym_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trainer_request]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trainer_request](
	[member_id] [int] NULL,
	[specialization] [varchar](20) NULL,
	[gym_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trainers_old_gym]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trainers_old_gym](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[trainer_name] [varchar](20) NULL,
	[gymname] [varchar](20) NULL,
	[time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[workout_plan]    Script Date: 12/05/2024 11:46:56 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[workout_plan](
	[plan_id] [int] IDENTITY(1,1) NOT NULL,
	[plan_name] [varchar](20) NULL,
	[details] [varchar](100) NULL,
	[creator] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (1, N'hasssaan', N'hassaan.234@gmail.com', N'i22-0890')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (2, N'saima_k', N'saima.k@hotmail.com', N'786Saima!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (3, N'rafiq_ali', N'rafiq.ali@gmail.com', N'aliRafiq123')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (4, N'anwar123', N'anwar123@example.com', N'anwar786!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (5, N'nida_khan', N'nida.khan@yahoo.com', N'kh@nNida456')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (6, N'tariq_007', N'tariq_007@hotmail.com', N'007Tariq!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (7, N'zain786', N'zain786@gmail.com', N'zainK786')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (8, N'asma123', N'asma123@example.com', N'A$ma456!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (9, N'umar_khan', N'umar.khan@yahoo.com', N'um@r789!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (10, N'nadia786', N'nadia786@hotmail.com', N'n@d1@786!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (11, N'sara_khan', N'sara.khan@example.com', N'khanSara789')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (12, N'usman123', N'usman123@gmail.com', N'123usman!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (13, N'farah_malik', N'farah.malik@hotmail.com', N'malikFarah456')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (14, N'ahmad_ali', N'ahmad.ali@yahoo.com', N'ahmad123_ali')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (15, N'Dalman', N'dalman.yaqoob@yahoo.com', N'chocopie')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (16, N'irfan khan', N'khan.irfan@yahoo.com', N'123987')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (17, N'ali782', N'ali.ullah@gmail.com', N'2dj29s1')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (18, N'wajid31', N'wajid.ali@gmail.com', N'12er21')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (19, N'ahmedKhan786', N'ahmed.khan@example.com', N'Khan786@!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (20, N'aliMalik92', N'ali.malik@example.com', N'Malik@456!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (21, N'zainabAziz33', N'zainab.aziz@example.com', N'Az!z2022@')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (22, N'sadiaBaig55', N'sadia.baig@example.com', N'Baig_Sadia2022')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (23, N'farhanIqbal12', N'farhan.iqbal@example.com', N'Iqb@l#987')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (24, N'sanaAslam21', N'sana.aslam@example.com', N'Asl@m21*')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (25, N'usmanRana89', N'usman.rana@example.com', N'Rana@89_Us')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (26, N'aishaZafar44', N'aisha.zafar@example.com', N'Zafar!2023')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (27, N'amirAli78', N'amir.ali@example.com', N'Al!78_amir')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (28, N'nadiaAkhtar67', N'nadia.akhtar@example.com', N'Akht@r67$')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (29, N'saadHussain23', N'saad.hussain@example.com', N'Hussain23!')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (30, N'asmaJaved89', N'asma.javed@example.com', N'J@v3d_A$ma')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (31, N'hamzaSaeed45', N'hamza.saeed@example.com', N'Sae3d45@')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (32, N'ayeshaKhalid56', N'ayesha.khalid@example.com', N'Kh@l!d_56')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (33, N'imranMalik90', N'imran.malik@example.com', N'M@lik_90Imr@n')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (34, N'saimaIqbal34', N'saima.iqbal@example.com', N'Iqbal34!Sa')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (35, N'razaAbbasi01', N'raza.abbasi@example.com', N'Abbasi_1R@z@')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (36, N'asimRaza22', N'asim.raza@example.com', N'R@za_@sim22')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (37, N'nailaKhan87', N'naila.khan@example.com', N'Kh@n87_Naila')
GO
INSERT [dbo].[account] ([userid], [username], [email], [password]) VALUES (38, N'bilalHussain99', N'bilal.hussain@example.com', N'Huss@in99!')
GO
SET IDENTITY_INSERT [dbo].[account] OFF
GO
SET IDENTITY_INSERT [dbo].[admin] ON 
GO
INSERT [dbo].[admin] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (1, N'hasssaan', N'hassaan', N'anwar', N'03002326776', N'Male')
GO
SET IDENTITY_INSERT [dbo].[admin] OFF
GO
SET IDENTITY_INSERT [dbo].[appointment] ON 
GO
INSERT [dbo].[appointment] ([appointment_id], [appointment_date], [member_id], [trainer_id]) VALUES (1, CAST(N'2024-06-10' AS Date), 3, 2)
GO
INSERT [dbo].[appointment] ([appointment_id], [appointment_date], [member_id], [trainer_id]) VALUES (2, CAST(N'2024-05-20' AS Date), 4, 2)
GO
INSERT [dbo].[appointment] ([appointment_id], [appointment_date], [member_id], [trainer_id]) VALUES (3, CAST(N'2024-05-10' AS Date), 6, 1)
GO
INSERT [dbo].[appointment] ([appointment_id], [appointment_date], [member_id], [trainer_id]) VALUES (4, CAST(N'2024-07-20' AS Date), 7, 1)
GO
INSERT [dbo].[appointment] ([appointment_id], [appointment_date], [member_id], [trainer_id]) VALUES (5, CAST(N'2024-05-25' AS Date), 8, 1)
GO
SET IDENTITY_INSERT [dbo].[appointment] OFF
GO
SET IDENTITY_INSERT [dbo].[diet_plan] ON 
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (1, N'Weight loss', N'A Simple 3 time meal prep for weightloss', N'nida_khan')
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (2, N'Bulking', N'A meal plan if you want to bulk in healty manner', N'anwar123')
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (3, N'My diet', N'What i eat as a lean adult', N'usman123')
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (4, N'Dirty Bulk', N'Diet plan to dirty bulk', N'tariq_007')
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (5, N'basics', N'A basic diet plan to have', N'anwar123')
GO
INSERT [dbo].[diet_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (6, N'my diet', N'My personal diet plan', N'nadia786')
GO
SET IDENTITY_INSERT [dbo].[diet_plan] OFF
GO
SET IDENTITY_INSERT [dbo].[exercise] ON 
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (1, 2, N'Normal Pushups', N'Pushups', 5, 10, N'Chest', 10, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (2, 2, N'Start with a weight that comfortable', N'Bench Press', 4, 90, N'Chest', 10, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (3, 2, N'Start Low and slowly go up the weights', N'Deadlifts', 4, 120, N'Back', 8, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (4, 2, N'Pull-Ups', N'Pull-Ups', 4, 90, N'Back', 8, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (5, 2, N'Hold as long as you can', N'Plank', 3, 60, N'Core', NULL, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (6, 1, N'Run at a comfortable speed for 5km', N'Running', 1, 0, N'Cardio', NULL, N'Tredmil')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (7, 1, N'Jump Rope', N'Jump Rope', 3, 30, N'Cardio', NULL, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (8, 1, N'An actual cycle or a gym one', N'Cycling', 3, 0, N'Cardio', NULL, N'Cycling')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (9, 1, N'Basic Burpees', N'Burpees', 3, 30, N'Full Body', NULL, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (10, 1, N'High-Intensity Interval Training (HIIT)', N'HIIT', 3, 30, N'Cardio', NULL, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (11, 4, N'Heavy Bench Press: Flat bench, barbell exercise.', N'Bench Press', 4, 90, N'Chest', 10, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (12, 4, N'Power Deadlifts: Compound lift, heavy barbell.', N'Deadlift', 4, 120, N'Back', 8, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (13, 4, N'Squat Strength: Compound lift, heavy barbell.', N'Squats', 5, 120, N'Legs', 10, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (14, 4, N'Barbell Rows: Upper back, heavy weights.', N'Barbell Rows', 4, 90, N'Back', 8, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (15, 4, N'Military Press: Heavy barbell, shoulder focus.', N'Military Press', 4, 90, N'Shoulders', 10, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (20, 3, N'Push-Ups: Upper body, bodyweight exercise.', N'Push-Ups', 4, 60, N'Chest', 12, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (21, 3, N'Bodyweight Squats: Lower body, no equipment.', N'Squat', 3, 60, N'Legs', 15, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (22, 3, N'Lat Pulldowns: Back exercise, machine.', N'Lat Pulldowns', 4, 90, N'Back', 10, N'Lats Machine')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (23, 3, N'Dumbbell Shoulder Press: Shoulder exercise', N'Shoulder Press', 4, 60, N'Shoulders', 12, N'Shoulder Machine')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (24, 3, N'Plank: Core exercise, static hold.', N'Planks', 3, NULL, N'Core', 60, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (25, 5, N'use normal form', N'Plank', 4, 30, N'Core', 2, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (26, 5, N'Basic Pushups', N'Pushups', 3, 90, N'Chest', 15, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (27, 5, N'Basic Pullups', N'Pull-ups', 4, 30, N'Upper', 5, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (28, 6, N'Cycling for 5k', N'Cycling', 1, 30, N'legs', NULL, N'Cycling')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (29, 6, N'Jumping Rope', N'Jump Rope', 3, 90, N'Cardio', 15, N'N/A')
GO
INSERT [dbo].[exercise] ([exercise_id], [plan_id], [details], [name], [e_sets], [rest_interval], [target_muscle], [reps], [machine]) VALUES (30, 6, N'Bodyweight Squats', N'Squats', 5, 45, N'Legs', 10, N'N/A')
GO
SET IDENTITY_INSERT [dbo].[exercise] OFF
GO
SET IDENTITY_INSERT [dbo].[feedback] ON 
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (1, CAST(N'2024-05-01' AS Date), N'Very Good Trainer', N'zain786', N'anwar123', 7)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (2, CAST(N'2024-05-01' AS Date), N'Experienced and very helpful', N'tariq_007', N'anwar123', 8)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (3, CAST(N'2024-05-12' AS Date), N'Was okay, nothing special', N'sara_khan', N'anwar123', 5)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (4, CAST(N'2024-05-12' AS Date), N'Very helpful', N'usman123', N'anwar123', 7)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (5, CAST(N'2024-05-12' AS Date), N'Experienced, worth the price', N'farah_malik', N'anwar123', 7)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (6, CAST(N'2024-05-12' AS Date), N'Very Average', N'asma123', N'nida_khan', 5)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (7, CAST(N'2024-05-12' AS Date), N'helped me alot at start', N'zain786', N'nida_khan', 9)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (8, CAST(N'2024-05-12' AS Date), N'Loved their energy', N'ahmad_ali', N'nida_khan', 7)
GO
INSERT [dbo].[feedback] ([feedback_id], [fdate], [details], [username], [trainer_name], [rating]) VALUES (9, CAST(N'2024-05-12' AS Date), N'Very well trained', N'irfan khan', N'nida_khan', 8)
GO
SET IDENTITY_INSERT [dbo].[feedback] OFF
GO
SET IDENTITY_INSERT [dbo].[Gym] ON 
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (1, N'Max Trainer', N'F-10 Markaz Islamabad', 1, 1000)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (2, N'Get Strong', N'G-6/4 Islamabad', 2, 750)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (3, N'Planet Fitness', N'Gulzar-e-Quaid', 3, 4000)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (4, N'Height Maxxing', N'Kamra', 4, 3000)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (7, N'Iron Haven Gym', N'23-B, Gulberg III, Lahore', 5, 5000)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (8, N'FlexFit Fitness', N'15-C, F-7 Markaz, Islamabad', 6, 500)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (9, N'Muscle Forge Gym', N'7th Floor, Ocean Tower, Karachi', 7, 2500)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (10, N'Powerhouse Fitness', N'10-D, Model Town, Lahore', 8, 3800)
GO
INSERT [dbo].[Gym] ([gymid], [name], [address], [owner_id], [membership_price]) VALUES (11, N'FitNation Gym & Spa', N'2nd Floor, Mega Mall, Islamabad', 9, 4000)
GO
SET IDENTITY_INSERT [dbo].[Gym] OFF
GO
SET IDENTITY_INSERT [dbo].[gym_owner] ON 
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (1, N'saima_k', N'saima', N'kamran', N'03225322773', N'Female')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (2, N'rafiq_ali', N'rafiq', N'ali', N'03216345842', N'Male')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (3, N'Dalman', N'Salman', N'Yaqoob', N'03216743864', N'Male')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (4, N'Ahmad_lassan', N'Ahmad', N'Hassan', N'03086732954', N'Male')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (5, N'saadHussain23', N'Saad', N'Hussain', N'03051234567', N'Male')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (6, N'asmaJaved89', N'Asma', N'Javed', N'03151234567', N'Female')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (7, N'hamzaSaeed45', N'Hamza', N'Saeed', N'03251234567', N'Male')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (8, N'ayeshaKhalid56', N'Ayesha', N'Khalid', N'03351234567', N'Female')
GO
INSERT [dbo].[gym_owner] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (9, N'imranMalik90', N'Imran', N'Malik', N'03451234567', N'Male')
GO
SET IDENTITY_INSERT [dbo].[gym_owner] OFF
GO
INSERT [dbo].[gym_owner_request] ([member_id], [name], [address], [membership_price]) VALUES (7, N'The Gym', N'F-8/2 Islamabad', 500)
GO
INSERT [dbo].[gym_owner_request] ([member_id], [name], [address], [membership_price]) VALUES (8, N'Gym Better', N'H-11 Markaz', 550)
GO
INSERT [dbo].[gym_owner_request] ([member_id], [name], [address], [membership_price]) VALUES (11, N'Stronger Better', N'F-6 Islamabad', 7000)
GO
SET IDENTITY_INSERT [dbo].[gym_review] ON 
GO
INSERT [dbo].[gym_review] ([review_id], [gym_id], [Username], [rating], [details]) VALUES (1, 1, N'umar_khan', 8, N'Very Good and clean gym, good equipment too')
GO
INSERT [dbo].[gym_review] ([review_id], [gym_id], [Username], [rating], [details]) VALUES (2, 1, N'asma123', 7, N'Nice gym, location is a bit too unsafe')
GO
INSERT [dbo].[gym_review] ([review_id], [gym_id], [Username], [rating], [details]) VALUES (3, 1, N'zain786', 5, N'Too expensive')
GO
INSERT [dbo].[gym_review] ([review_id], [gym_id], [Username], [rating], [details]) VALUES (4, 1, N'usman123', 8, N'Good and professional staff and very clean')
GO
SET IDENTITY_INSERT [dbo].[gym_review] OFF
GO
SET IDENTITY_INSERT [dbo].[meals] ON 
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (3, 1, N'Grilled Chicken Salad', CAST(30.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), N'Healthy salad with chicken, greens, veggies, vinaigrette.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (4, 1, N'Quinoa and Vegetable Stir-Fry', CAST(10.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'Nutritious stir-fry with quinoa, veggies, soy sauce.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (5, 1, N'Salmon and Asparagus', CAST(25.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'Baked salmon with asparagus, lemon, herbs.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (6, 2, N'Beef and Rice Bowl', CAST(40.50 AS Decimal(10, 2)), CAST(15.20 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), CAST(50.80 AS Decimal(10, 2)), N'Hearty bowl with beef, rice, veggies, teriyaki.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (7, 2, N'Chicken and Sweet Potato Mash', CAST(35.70 AS Decimal(10, 2)), CAST(10.40 AS Decimal(10, 2)), CAST(6.10 AS Decimal(10, 2)), CAST(40.90 AS Decimal(10, 2)), N'Grilled chicken with sweet potatoes, broccoli, Parmesan.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (8, 2, N'Fried Eggs', CAST(30.90 AS Decimal(10, 2)), CAST(12.60 AS Decimal(10, 2)), CAST(5.20 AS Decimal(10, 2)), CAST(40.30 AS Decimal(10, 2)), N'Basic Fried Eggs with seasoning, ideal for bulking.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (9, 3, N'Shrimp Tacos', CAST(20.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)), N'Grilled shrimp, corn tortillas, cabbage slaw, salsa.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (10, 3, N'Greek Salad with Hummus', CAST(15.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'Mixed greens, cucumber, tomato, feta, hummus.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (11, 3, N'Turkey and Avocado Wrap', CAST(25.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'Turkey, avocado, lettuce, tomato, whole-grain wrap.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (12, 4, N'Double Cheeseburger with Fries', CAST(30.00 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Double beef patties, cheese, fries, mayo.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (13, 4, N'Loaded Nachos with Beef and Cheese', CAST(20.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'Tortilla chips, beef, cheese, guacamole, sour cream.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (14, 4, N'Deep Dish Meat Lovers Pizza', CAST(35.00 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'Thick crust, pepperoni, sausage, bacon, cheese.')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (15, 5, N'Fried eggs', CAST(30.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'2 Fried eggs for a refreshing breakfast')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (16, 5, N'Salmon fillet', CAST(20.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), N'Tender salmon fillet served with a side of vegetables')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (17, 5, N'Turkey wrap', CAST(15.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'wrap with lettuce, tomato, and whole wheat tortilla')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (18, 6, N'Vegetarian chili', CAST(12.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'Hearty vegetarian chili with beans and spices')
GO
INSERT [dbo].[meals] ([meal_id], [plan_id], [name], [proteins], [fats], [fibre], [carbs], [details]) VALUES (19, 6, N'Sushi roll', CAST(15.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(35.00 AS Decimal(10, 2)), N'Assorted sushi rolls with wasabi and soy sauce')
GO
SET IDENTITY_INSERT [dbo].[meals] OFF
GO
SET IDENTITY_INSERT [dbo].[member] ON 
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (1, N'nadia786', N'nadia', N'malik', N'03007486532', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (2, N'umar_khan', N'umar', N'khan', N'03002576432', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (3, N'asma123', N'asma', N'tariq', N'03214735672', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (4, N'zain786', N'zain', N'tahir', N'03331975433', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (5, N'tariq_007', N'tariq', N'ali', N'03227829432', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (6, N'sara_khan', N'sara', N'khan', N'03017826462', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (7, N'usman123', N'usman', N'arshad', N'03026748526', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (8, N'farah_malik', N'farah', N'malik', N'03013526462', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (9, N'ahmad_ali', N'ahmad', N'ali', N'03015109234', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (10, N'irfan khan', N'irfan', N'khan', N'03117381932', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (11, N'ali782', N'ali', N'ullah', N'0312723932', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (12, N'ahmedKhan786', N'Ahmed', N'Khan', N'03011223344', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (13, N'aliMalik92', N'Ali', N'Malik', N'03111223355', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (14, N'zainabAziz33', N'Zainab', N'Aziz', N'03211223366', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (15, N'sadiaBaig55', N'Sadia', N'Baig', N'03311223377', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (16, N'farhanIqbal12', N'Farhan', N'Iqbal', N'03411223388', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (17, N'sanaAslam21', N'Sana', N'Aslam', N'03511223399', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (18, N'usmanRana89', N'Usman', N'Rana', N'03611223300', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (19, N'aishaZafar44', N'Aisha', N'Zafar', N'03711223311', N'Female')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (20, N'amirAli78', N'Amir', N'Ali', N'03811223322', N'Male')
GO
INSERT [dbo].[member] ([userid], [username], [firstname], [lastname], [phone], [gender]) VALUES (21, N'nadiaAkhtar67', N'Nadia', N'Akhtar', N'03911223333', N'Female')
GO
SET IDENTITY_INSERT [dbo].[member] OFF
GO
INSERT [dbo].[member_diet] ([member_id], [diet_plan_id]) VALUES (5, 1)
GO
INSERT [dbo].[member_diet] ([member_id], [diet_plan_id]) VALUES (3, 1)
GO
INSERT [dbo].[member_diet] ([member_id], [diet_plan_id]) VALUES (2, 2)
GO
INSERT [dbo].[member_workout] ([member_id], [workout_plan]) VALUES (1, 2)
GO
INSERT [dbo].[member_workout] ([member_id], [workout_plan]) VALUES (3, 1)
GO
INSERT [dbo].[member_workout] ([member_id], [workout_plan]) VALUES (4, 1)
GO
SET IDENTITY_INSERT [dbo].[membership] ON 
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (1, N'2 Months', 1, 1)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (2, N'3 Months', 2, 1)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (3, N'1 Month', 3, 2)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (4, N'6 Months', 4, 2)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (5, N'4 Months', 5, 1)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (6, N'1 Month', 6, 3)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (7, N'1 Month', 7, 3)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (8, N'2 Months', 8, 3)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (9, N'2 Months', 9, 2)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (10, N'5 Months', 10, 2)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (11, N'4 Months', 11, 1)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (13, N'1 Month', 12, 11)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (14, N'2 Months', 13, 7)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (15, N'5 Months', 14, 8)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (16, N'2 Months', 15, 10)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (17, N'4 Months', 16, 10)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (18, N'6 Months', 17, 11)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (19, N'1 Month', 18, 7)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (20, N'6 Months', 19, 9)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (21, N'3 Months', 20, 9)
GO
INSERT [dbo].[membership] ([membership_id], [duration], [member_id], [gym_id]) VALUES (22, N'6 Months', 21, 7)
GO
SET IDENTITY_INSERT [dbo].[membership] OFF
GO
SET IDENTITY_INSERT [dbo].[trainer] ON 
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (1, N'anwar123', N'anwar', N'iqbal', N'03086329343', N'Male', N'Cardiovascular Training', 3)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (2, N'nida_khan', N'nida', N'khan', N'03013879654', N'Female', N'Group Fitness Classes', 2)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (3, N'razaAbbasi01', N'Raza', N'Abbasi', N'03651234567', N'Male', N'Strength training', 7)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (4, N'asimRaza22', N'Asim', N'Raza', N'03751234567', N'Male', N'HIIT workouts', 9)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (5, N'nailaKhan87', N'Naila', N'Khan', N'03851234567', N'Female', N'Yoga and meditation', 11)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (6, N'bilalHussain99', N'Bilal', N'Hussain', N'03951234567', N'Male', N'CrossFit training', 10)
GO
INSERT [dbo].[trainer] ([userid], [username], [firstname], [lastname], [phone], [gender], [specialization], [gym_id]) VALUES (7, N'saimaIqbal34', N'Saima', N'Iqbal', N'03551234567', N'Female', N'Cardiovascular training', 10)
GO
SET IDENTITY_INSERT [dbo].[trainer] OFF
GO
INSERT [dbo].[trainer_request] ([member_id], [specialization], [gym_id]) VALUES (6, N'Calisthenics', 2)
GO
INSERT [dbo].[trainer_request] ([member_id], [specialization], [gym_id]) VALUES (9, N'Weight Lifting', 1)
GO
INSERT [dbo].[trainer_request] ([member_id], [specialization], [gym_id]) VALUES (10, N'Cardio', 4)
GO
SET IDENTITY_INSERT [dbo].[trainers_old_gym] ON 
GO
INSERT [dbo].[trainers_old_gym] ([id], [trainer_name], [gymname], [time]) VALUES (4, N'anwar123', N'Max Trainer', CAST(N'2024-05-02T23:13:11.430' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[trainers_old_gym] OFF
GO
SET IDENTITY_INSERT [dbo].[workout_plan] ON 
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (1, N'Lose Weight', N'Quickly Lose Weight with this easy to do routine', N'anwar123')
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (2, N'Beginners', N'A simple start to your workout journey', N'nida_khan')
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (3, N'My workout', N'Just a workout i do as a lean adult', N'usman123')
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (4, N'Get Strong', N'A hard weight-lifting plan', N'tariq_007')
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (5, N'starter', N'A starter workout for students', N'anwar123')
GO
INSERT [dbo].[workout_plan] ([plan_id], [plan_name], [details], [creator]) VALUES (6, N'workbest', N'My own personal workout routine', N'nadia786')
GO
SET IDENTITY_INSERT [dbo].[workout_plan] OFF
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD FOREIGN KEY([trainer_id])
REFERENCES [dbo].[trainer] ([userid])
GO
ALTER TABLE [dbo].[Gym]  WITH CHECK ADD FOREIGN KEY([owner_id])
REFERENCES [dbo].[gym_owner] ([userid])
GO
ALTER TABLE [dbo].[gym_owner_request]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
ALTER TABLE [dbo].[gym_review]  WITH CHECK ADD FOREIGN KEY([gym_id])
REFERENCES [dbo].[Gym] ([gymid])
GO
ALTER TABLE [dbo].[member_diet]  WITH CHECK ADD FOREIGN KEY([diet_plan_id])
REFERENCES [dbo].[diet_plan] ([plan_id])
GO
ALTER TABLE [dbo].[member_diet]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
ALTER TABLE [dbo].[member_workout]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
ALTER TABLE [dbo].[member_workout]  WITH CHECK ADD FOREIGN KEY([workout_plan])
REFERENCES [dbo].[workout_plan] ([plan_id])
GO
ALTER TABLE [dbo].[membership]  WITH CHECK ADD FOREIGN KEY([gym_id])
REFERENCES [dbo].[Gym] ([gymid])
GO
ALTER TABLE [dbo].[membership]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
ALTER TABLE [dbo].[trainer]  WITH CHECK ADD FOREIGN KEY([gym_id])
REFERENCES [dbo].[Gym] ([gymid])
GO
ALTER TABLE [dbo].[trainer_request]  WITH CHECK ADD FOREIGN KEY([gym_id])
REFERENCES [dbo].[Gym] ([gymid])
GO
ALTER TABLE [dbo].[trainer_request]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([userid])
GO
USE [master]
GO
ALTER DATABASE [flex_trainer] SET  READ_WRITE 
GO
