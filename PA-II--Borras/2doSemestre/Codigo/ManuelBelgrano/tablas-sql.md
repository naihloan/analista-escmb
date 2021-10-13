Si no la tienes disponible, deberás usar estos scripts:
Crear base:
CREATE TABLE [dbo].[Persona](
	[Edad] [int] NULL,
	[Nombre] [varchar](200) NULL
) ON [PRIMARY]

Popular datos:

INSERT [dbo].[Persona] ([Edad], [Nombre]) VALUES (18, N'Juan')
GO
INSERT [dbo].[Persona] ([Edad], [Nombre]) VALUES (15, N'Juancito')
GO
INSERT [dbo].[Persona] ([Edad], [Nombre]) VALUES (80, N'Félix')
GO
INSERT [dbo].[Persona] ([Edad], [Nombre]) VALUES (40, N'Evelyn')
GO
INSERT [dbo].[Persona] ([Edad], [Nombre]) VALUES (99, N'Hilda')
GO
