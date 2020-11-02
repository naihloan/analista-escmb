USE [master]
GO
/****** Object:  Database [ConcesionariaImportante]    Script Date: 16/10/2020 01:53:48 ******/
CREATE DATABASE [ConcesionariaImportante] ON  PRIMARY 
( NAME = N'ConcesionariaImportante', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS2008\MSSQL\DATA\ConcesionariaImportante.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ConcesionariaImportante_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS2008\MSSQL\DATA\ConcesionariaImportante_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ConcesionariaImportante] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ConcesionariaImportante].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ConcesionariaImportante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET ARITHABORT OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ConcesionariaImportante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ConcesionariaImportante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ConcesionariaImportante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ConcesionariaImportante] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ConcesionariaImportante] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ConcesionariaImportante] SET  MULTI_USER 
GO
ALTER DATABASE [ConcesionariaImportante] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ConcesionariaImportante] SET DB_CHAINING OFF 
GO
USE [ConcesionariaImportante]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[Codigo_Cargo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Cargo] [varchar](50) NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Codigo_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Sucursal] [int] NULL,
	[Descripción_Nombre] [varchar](50) NULL,
	[Dirección] [varchar](50) NULL,
	[Teléfono] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DesignacionDeEmpleados]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesignacionDeEmpleados](
	[Codigo_Designacion_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Empleado] [int] NULL,
	[Codigo_Sucursal] [int] NULL,
	[Codigo_Cargo] [nvarchar](50) NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Designacion_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Codigo_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Descripción_Nombre] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[CodigoMarca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Marca] [varchar](50) NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[Codigo_Modelo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Modelo] [varchar](50) NULL,
	[Codigo_Marca] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuestos]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuestos](
	[Codigo_Repuestos] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Modelo_Auto] [varchar](50) NULL,
	[Codigo_Sucursal] [int] NULL,
	[Descripcion_Repuesto] [varchar](50) NULL,
	[Presentacion] [varchar](50) NULL,
	[Cantidad_Disponible] [int] NULL,
	[Precio] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Repuestos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiciosTecnicosOfrecidos]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiciosTecnicosOfrecidos](
	[Codigo_Servicio_Tecnico] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Codigo_Sucursal] [int] NULL,
	[Precio] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Servicio_Tecnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Codigo_Sucursal] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Sucursal] [varchar](50) NULL,
	[Fecha_Inicio] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Baja] [date] NULL,
	[Responsable] [text] NULL,
	[Sucursal] [int] NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Mail] [nvarchar](1) NULL,
	[Fax] [nvarchar](1) NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos_Okm]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos_Okm](
	[Codigo_Vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Modelo] [int] NULL,
	[Codigo_Carrocería] [int] NULL,
	[Numero_Chasis] [int] NULL,
	[Numero_Motor] [int] NULL,
	[Codigo_Sucursal] [int] NULL,
	[Fecha_Ingreso] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Venta] [date] NULL,
	[Observaciones] [text] NULL,
	[Patente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos_Usados]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos_Usados](
	[Codigo_Vehiculo_Usado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Modelo] [varchar](50) NULL,
	[Codigo_Carrocería] [int] NULL,
	[Numero_Chasis] [int] NULL,
	[Numero_Motor] [varchar](50) NULL,
	[Patente] [varchar](50) NULL,
	[Año] [int] NULL,
	[Kilometraje] [int] NULL,
	[Fecha_Revision_Tecnica] [date] NULL,
	[Codigo_Empleado] [int] NULL,
	[Codigo_Sucursal] [int] NULL,
	[Fecha_Ingreso] [date] NULL,
	[Estado] [int] NULL,
	[Fecha_Venta] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Vehiculo_Usado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Vehiculos_0km]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Vehiculos_0km](
	[Codigo_Venta_Cero] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Vehiculo] [int] NULL,
	[Codigo_Cliente] [int] NULL,
	[Codigo_Sucursal] [int] NULL,
	[Codigo_Empleado] [int] NULL,
	[Fecha_Inicio_Venta] [date] NULL,
	[Codigo_Estado_Seguimiento] [int] NULL,
	[Fecha_Cierre_Venta] [date] NULL,
	[Observaciones] [text] NULL,
	[Precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Venta_Cero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Vehiculos_Usados]    Script Date: 16/10/2020 01:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Vehiculos_Usados](
	[Codigo_Venta_Usado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Vehiculo] [int] NULL,
	[Codigo_Cliente] [int] NULL,
	[Codigo_Sucursal] [int] NULL,
	[Codigo_Empleado] [int] NULL,
	[Fecha_Inicio_Venta] [date] NULL,
	[Codigo_Estado_Seguimiento] [int] NULL,
	[Fecha_Cierre_Venta] [date] NULL,
	[Observaciones] [text] NULL,
	[Precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Venta_Usado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'Vendedor', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'Vendedor', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'Jefe_de_Ventas', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, N'Gerente de Ventas ', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, N'Mecánico', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, N'Jefe de Taller', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (7, N'Gerente de Sucursal', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Cargos] ([Codigo_Cargo], [Descripcion_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (8, N'Gerente de Mecánica', CAST(N'2020-03-01' AS Date), 1, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, 1, N'Juan Canedo', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, 1, N'Liliana Perz', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, 1, N'Mauro Lopez ', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, 1, N'Erika Lanos', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, 1, N'Pablo Lozada', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, 1, N'Patricia Valverde', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (7, 1, N'Laura Lopez', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (8, 1, N'Esteban Moreno', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Clientes] ([Codigo_Cliente], [Codigo_Sucursal], [Descripción_Nombre], [Dirección], [Teléfono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (9, 1, N'Gabriel Ramirez', NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[DesignacionDeEmpleados] ON 
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, 2, 1, N'1', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, 3, 1, N'2', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, 5, 1, N'3', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, 1, 1, N'4', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, 6, 1, N'5', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DesignacionDeEmpleados] ([Codigo_Designacion_Empleado], [Codigo_Empleado], [Codigo_Sucursal], [Codigo_Cargo], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, 4, 1, N'6', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[DesignacionDeEmpleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'Juan Albornoz ', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'Juan Cruz
Fernandez', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'Claudia Origlia', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, N'Janice Lopez', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, N'Eugenia Moreno', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, N'Carlos Baracena', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (7, N'Guillermo Blanco', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (8, N'Laura Espeleta', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (9, N'Javier Miras', NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Empleados] ([Codigo_Empleado], [Descripción_Nombre], [Direccion], [Telefono], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (10, NULL, NULL, NULL, CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'Renault', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'Fiat', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'Peugeot', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, N'Citroen', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, N'Volkswagen', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, N'Ford', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Marcas] ([CodigoMarca], [Descripcion_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (7, N'Chevrolet', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelos] ON 
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'Logan', 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'Duster', 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'Uno Way', 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, N'Cronos', 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, N'208', 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, N'308', 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (7, N'C3', 4, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (8, N'C3 AirCross', 4, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (9, N'Gol', 5, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (10, N'Up!', 5, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (11, N'Ka', 6, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (12, N'Ka+', 6, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (13, N'Joy Plus', 7, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Modelos] ([Codigo_Modelo], [Descripcion_Modelo], [Codigo_Marca], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (14, N'Nuevo OnixPlus', 7, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Modelos] OFF
GO
SET IDENTITY_INSERT [dbo].[Repuestos] ON 
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'1', 1, N'Tapon Carter', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'1', 1, N'Filtro Aceite', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'2', 1, N'Bujia', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (4, N'2', 1, N'Bujia', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (5, N'3', 1, N'Inyectores', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Repuestos] ([Codigo_Repuestos], [Codigo_Modelo_Auto], [Codigo_Sucursal], [Descripcion_Repuesto], [Presentacion], [Cantidad_Disponible], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (6, N'3', 1, N'Inyectores', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Repuestos] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiciosTecnicosOfrecidos] ON 
GO
INSERT [dbo].[ServiciosTecnicosOfrecidos] ([Codigo_Servicio_Tecnico], [Descripcion], [Codigo_Sucursal], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (1, N'Cambio filtros', 1, 5000, CAST(N'2020-05-01' AS Date), NULL, CAST(N'2021-05-01' AS Date), N'filtro bueno')
GO
INSERT [dbo].[ServiciosTecnicosOfrecidos] ([Codigo_Servicio_Tecnico], [Descripcion], [Codigo_Sucursal], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (2, N'Cambio Bujias', 1, 6000, CAST(N'2020-05-01' AS Date), NULL, CAST(N'2021-05-01' AS Date), N'cambio exitoso')
GO
INSERT [dbo].[ServiciosTecnicosOfrecidos] ([Codigo_Servicio_Tecnico], [Descripcion], [Codigo_Sucursal], [Precio], [Fecha_Inicio], [Estado], [Fecha_Baja], [Observaciones]) VALUES (3, N'Cambio Inyectores', 1, 12000, CAST(N'2020-05-01' AS Date), NULL, CAST(N'2021-05-01' AS Date), N'cambio proximo a los 200000 kms')
GO
SET IDENTITY_INSERT [dbo].[ServiciosTecnicosOfrecidos] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (1, N' Cerro de las Rosas', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (2, N'Alberdi', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (3, N'San Vicente', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (4, N'Villa Allende', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (5, N'Taller Norte', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Sucursal] ([Codigo_Sucursal], [Descripcion_Sucursal], [Fecha_Inicio], [Estado], [Fecha_Baja], [Responsable], [Sucursal], [Direccion], [Telefono], [Mail], [Fax], [Observaciones]) VALUES (6, N'Taller Sur', CAST(N'2020-03-01' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos_Okm] ON 
GO
INSERT [dbo].[Vehiculos_Okm] ([Codigo_Vehiculo], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones], [Patente]) VALUES (2, 10, 2, 10126, 48577, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos_Okm] ([Codigo_Vehiculo], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones], [Patente]) VALUES (3, 12, 1, 11678, 15699, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos_Okm] ([Codigo_Vehiculo], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones], [Patente]) VALUES (4, 13, 1, 13543, 92333, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Vehiculos_Okm] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos_Usados] ON 
GO
INSERT [dbo].[Vehiculos_Usados] ([Codigo_Vehiculo_Usado], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Patente], [Año], [Kilometraje], [Fecha_Revision_Tecnica], [Codigo_Empleado], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones]) VALUES (1, N'1', 1, 10129, N'J85CP', N'JCW345', 2010, 220000, CAST(N'2020-09-02' AS Date), 1, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Vehiculos_Usados] ([Codigo_Vehiculo_Usado], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Patente], [Año], [Kilometraje], [Fecha_Revision_Tecnica], [Codigo_Empleado], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones]) VALUES (2, N'5', 2, 11676, N'B56XX', N'LAA789', 2013, 150000, CAST(N'2020-09-02' AS Date), 1, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL)
GO
INSERT [dbo].[Vehiculos_Usados] ([Codigo_Vehiculo_Usado], [Codigo_Modelo], [Codigo_Carrocería], [Numero_Chasis], [Numero_Motor], [Patente], [Año], [Kilometraje], [Fecha_Revision_Tecnica], [Codigo_Empleado], [Codigo_Sucursal], [Fecha_Ingreso], [Estado], [Fecha_Venta], [Observaciones]) VALUES (3, N'9', 2, 13548, N'P23AD', N'JWD123', 2010, 200000, CAST(N'2020-09-02' AS Date), 1, 1, CAST(N'2020-09-02' AS Date), 1, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Vehiculos_Usados] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas_Vehiculos_0km] ON 
GO
INSERT [dbo].[Ventas_Vehiculos_0km] ([Codigo_Venta_Cero], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (1, 2, 5, 1, 2, CAST(N'2020-09-02' AS Date), 4, CAST(N'2020-09-02' AS Date), NULL, 750000)
GO
INSERT [dbo].[Ventas_Vehiculos_0km] ([Codigo_Venta_Cero], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (2, 1, 6, 1, 2, CAST(N'2020-09-02' AS Date), 4, CAST(N'2020-09-02' AS Date), NULL, 250000)
GO
INSERT [dbo].[Ventas_Vehiculos_0km] ([Codigo_Venta_Cero], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (3, 3, 7, 1, 2, CAST(N'2020-09-02' AS Date), 4, CAST(N'2020-09-02' AS Date), NULL, 285000)
GO
SET IDENTITY_INSERT [dbo].[Ventas_Vehiculos_0km] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas_Vehiculos_Usados] ON 
GO
INSERT [dbo].[Ventas_Vehiculos_Usados] ([Codigo_Venta_Usado], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (1, 3, 9, 1, 2, CAST(N'2020-09-02' AS Date), 2, NULL, NULL, 1115000)
GO
INSERT [dbo].[Ventas_Vehiculos_Usados] ([Codigo_Venta_Usado], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (2, 2, 8, 1, 2, CAST(N'2020-09-02' AS Date), 2, NULL, NULL, 1115000)
GO
INSERT [dbo].[Ventas_Vehiculos_Usados] ([Codigo_Venta_Usado], [Codigo_Vehiculo], [Codigo_Cliente], [Codigo_Sucursal], [Codigo_Empleado], [Fecha_Inicio_Venta], [Codigo_Estado_Seguimiento], [Fecha_Cierre_Venta], [Observaciones], [Precio]) VALUES (3, 1, 7, 1, 2, CAST(N'2020-09-02' AS Date), 2, NULL, NULL, 1015000)
GO
SET IDENTITY_INSERT [dbo].[Ventas_Vehiculos_Usados] OFF
GO
USE [master]
GO
ALTER DATABASE [ConcesionariaImportante] SET  READ_WRITE 
GO
