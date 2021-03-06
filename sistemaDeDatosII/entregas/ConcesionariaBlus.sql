USE [master]
GO
/****** Object:  Database [ConcesionariaBlus]    Script Date: 27/05/2020 17:22:26 ******/
CREATE DATABASE [ConcesionariaBlus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ConcesionariaBlus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ConcesionariaBlus.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ConcesionariaBlus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ConcesionariaBlus_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ConcesionariaBlus] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ConcesionariaBlus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ConcesionariaBlus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET ARITHABORT OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ConcesionariaBlus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ConcesionariaBlus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ConcesionariaBlus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ConcesionariaBlus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ConcesionariaBlus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ConcesionariaBlus] SET  MULTI_USER 
GO
ALTER DATABASE [ConcesionariaBlus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ConcesionariaBlus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ConcesionariaBlus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ConcesionariaBlus] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ConcesionariaBlus] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ConcesionariaBlus]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_Cod_Cliente] [int] NOT NULL,
	[Documento] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Ciudad] [varchar](50) NULL,
	[Telefono] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Cod_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Control]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Control](
	[id_Vehiculo_U] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Calificacion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Vehiculo_U] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_Empleado] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [varchar](100) NULL,
	[DNI] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[id_Concesionaria] [varchar](50) NOT NULL,
	[Sucursal] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Concesionaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormaDePago]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaDePago](
	[id_Forma_de_pago] [int] NOT NULL,
	[id_Vehiculo_U] [int] NOT NULL,
	[Efectivo] [decimal](18, 0) NULL,
	[Cheque] [decimal](18, 0) NULL,
	[Debito] [decimal](18, 0) NULL,
	[Credito] [decimal](18, 0) NULL,
	[Transferencia_Bancaria] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Forma_de_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mecanico]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mecanico](
	[id_Mecanico] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Empresa] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [varchar](50) NULL,
	[Dni] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Mecanico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id_Producto] [varchar](50) NOT NULL,
	[id_Vehiculo] [int] NULL,
	[id_Repuesto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Repuesto]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Repuesto](
	[id_Repuesto] [int] NOT NULL,
	[Categoria] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
	[Fabricante] [varchar](50) NULL,
	[Precio_de_Venta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Repuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServicioTecnico]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServicioTecnico](
	[id_Servicio_Tecnico] [int] NOT NULL,
	[id_Vehiculo] [int] NOT NULL,
	[id_Cod_Cliente] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Grua] [varchar](50) NULL,
	[Tarea] [varchar](100) NULL,
	[Estado] [varchar](50) NULL,
	[MecanicaPesada] [varchar](50) NULL,
	[MecanicaLigera] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Servicio_Tecnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUCURSAL]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUCURSAL](
	[id_Sucursal] [varchar](50) NOT NULL,
	[id_Vehiculo] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[Dirección] [varchar](50) NULL,
	[Telefono] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[id_Vehiculo] [int] NOT NULL,
	[Usado] [tinyint] NOT NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Motor] [tinyint] NULL,
	[Color] [varchar](50) NULL,
	[Chasis] [varchar](30) NULL,
	[Precio] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehiculoUsado]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiculoUsado](
	[id_Vehiculo_U] [int] NOT NULL,
	[id_Cod_Cliente] [int] NOT NULL,
	[Matricula] [int] NULL,
	[Kilometraje] [int] NULL,
	[Precio] [decimal](18, 0) NULL,
	[Estado] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Vehiculo_U] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 27/05/2020 17:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[id_Venta] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[id_Producto] [varchar](50) NOT NULL,
	[id_Mecanico] [int] NOT NULL,
	[id_Forma_de_pago] [int] NOT NULL,
	[id_Cod_Cliente] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Garantia] [varchar](50) NULL,
	[Condicion] [varchar](50) NULL,
	[Total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Control]  WITH CHECK ADD  CONSTRAINT [FK_Control_VehiculoUsado] FOREIGN KEY([id_Vehiculo_U])
REFERENCES [dbo].[VehiculoUsado] ([id_Vehiculo_U])
GO
ALTER TABLE [dbo].[Control] CHECK CONSTRAINT [FK_Control_VehiculoUsado]
GO
ALTER TABLE [dbo].[FormaDePago]  WITH CHECK ADD  CONSTRAINT [FK_FormaDePago_VehiculoUsado] FOREIGN KEY([id_Vehiculo_U])
REFERENCES [dbo].[VehiculoUsado] ([id_Vehiculo_U])
GO
ALTER TABLE [dbo].[FormaDePago] CHECK CONSTRAINT [FK_FormaDePago_VehiculoUsado]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_ID_Repuesto] FOREIGN KEY([id_Repuesto])
REFERENCES [dbo].[Repuesto] ([id_Repuesto])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_ID_Repuesto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Vehiculo] FOREIGN KEY([id_Vehiculo])
REFERENCES [dbo].[Vehiculo] ([id_Vehiculo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Vehiculo]
GO
ALTER TABLE [dbo].[ServicioTecnico]  WITH CHECK ADD  CONSTRAINT [FK_ServicioTecnico_Cliente] FOREIGN KEY([id_Cod_Cliente])
REFERENCES [dbo].[Cliente] ([id_Cod_Cliente])
GO
ALTER TABLE [dbo].[ServicioTecnico] CHECK CONSTRAINT [FK_ServicioTecnico_Cliente]
GO
ALTER TABLE [dbo].[ServicioTecnico]  WITH CHECK ADD  CONSTRAINT [FK_ServicioTecnico_Vehiculo] FOREIGN KEY([id_Vehiculo])
REFERENCES [dbo].[Vehiculo] ([id_Vehiculo])
GO
ALTER TABLE [dbo].[ServicioTecnico] CHECK CONSTRAINT [FK_ServicioTecnico_Vehiculo]
GO
ALTER TABLE [dbo].[SUCURSAL]  WITH CHECK ADD  CONSTRAINT [FK_SUCURSAL_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([id_Empleado])
GO
ALTER TABLE [dbo].[SUCURSAL] CHECK CONSTRAINT [FK_SUCURSAL_Empleado]
GO
ALTER TABLE [dbo].[SUCURSAL]  WITH CHECK ADD  CONSTRAINT [FK_SUCURSAL_Producto] FOREIGN KEY([id_Vehiculo])
REFERENCES [dbo].[Vehiculo] ([id_Vehiculo])
GO
ALTER TABLE [dbo].[SUCURSAL] CHECK CONSTRAINT [FK_SUCURSAL_Producto]
GO
ALTER TABLE [dbo].[VehiculoUsado]  WITH CHECK ADD  CONSTRAINT [FK_VehiculoUsado_Cliente] FOREIGN KEY([id_Cod_Cliente])
REFERENCES [dbo].[Cliente] ([id_Cod_Cliente])
GO
ALTER TABLE [dbo].[VehiculoUsado] CHECK CONSTRAINT [FK_VehiculoUsado_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([id_Cod_Cliente])
REFERENCES [dbo].[Cliente] ([id_Cod_Cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([id_Empleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_FormaDePago] FOREIGN KEY([id_Forma_de_pago])
REFERENCES [dbo].[FormaDePago] ([id_Forma_de_pago])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_FormaDePago]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Mecanico] FOREIGN KEY([id_Mecanico])
REFERENCES [dbo].[Mecanico] ([id_Mecanico])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Mecanico]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([id_Producto])
REFERENCES [dbo].[Producto] ([id_Producto])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
USE [master]
GO
ALTER DATABASE [ConcesionariaBlus] SET  READ_WRITE 
GO
