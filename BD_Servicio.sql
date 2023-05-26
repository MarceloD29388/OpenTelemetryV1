/****** CREAR UNA BD CON EL NOMBRE CURSO Y LUEGO CORRER ESTE SCRIPT ******/
USE [Curso]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[cuil] [nvarchar](50) NULL,
	[tipoDocumento] [nchar](10) NULL,
	[nroDocuemnto] [int] NULL,
	[esEmpleado] [bit] NULL,
	[paisOrigen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


