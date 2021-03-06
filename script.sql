USE [bd_tramite_documentario]
GO
/****** Object:  Table [dbo].[adm_sistema]    Script Date: 08/12/2018 9:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adm_sistema]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[adm_sistema](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](200) NULL,
	[apellidos] [varchar](200) NULL,
	[correo_electronico] [varchar](200) NULL,
	[usuario] [varchar](100) NOT NULL,
	[contraseña] [varchar](100) NOT NULL,
	[tipo_administrador] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[areas]    Script Date: 08/12/2018 9:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areas](
	[id_area] [int] IDENTITY(1,1) NOT NULL,
	[codigo]  AS ('AREA-'+replace(str([id_area],(5)),' ','0')),
	[nombre_area] [varchar](100) NULL,
	[encargardo_area] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_documento_externo]    Script Date: 08/12/2018 9:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalle_documento_externo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalle_documento_externo](
	[numero_respuesta_ext] [int] IDENTITY(1,1) NOT NULL,
	[numero_correlativo] [int] NULL,
	[asunto] [varchar](500) NULL,
	[derivar_area] [varchar](200) NULL,
	[fecha_salida] [datetime] NULL,
	[descripcion] [varchar](500) NULL,
	[estado] [varchar](20) NULL,
	[observacion] [varchar](8000) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_documento_interno]    Script Date: 08/12/2018 9:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalle_documento_interno]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalle_documento_interno](
	[numero_respuesta_int] [int] IDENTITY(1,1) NOT NULL,
	[numero_correlativo] [int] NULL,
	[asunto] [varchar](500) NULL,
	[derivar_area] [varchar](200) NULL,
	[fecha_salida] [datetime] NULL,
	[descripcion] [varchar](500) NULL,
	[estado] [varchar](20) NULL,
	[observacion] [varchar](8000) NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_respuesta_int] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[documento_externo]    Script Date: 08/12/2018 9:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[documento_externo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[documento_externo](
	[numero_correlativo] [int] IDENTITY(1,1) NOT NULL,
	[numero_registro_MP] [text] NULL,
	[tipo_documento] [text] NULL,
	[numero_folio] [int] NULL,
	[nombre_tramitante] [varchar](50) NULL,
	[dni_tramitante] [varchar](8) NULL,
	[asunto_tramitante] [varchar](500) NULL,
	[id_area] [int] NULL,
	[nombre_area] [varchar](100) NULL,
	[fecha_registro] [datetime] NULL,
	[estado] [varchar](20) NULL,
	[observacion] [varchar](8000) NULL,
	[imagen] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_correlativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[documento_interno]    Script Date: 08/12/2018 9:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[documento_interno]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[documento_interno](
	[numero_correlativo] [int] IDENTITY(1,1) NOT NULL,
	[numero_registro_MP] [text] NULL,
	[tipo_documento] [text] NULL,
	[numero_folio] [int] NULL,
	[nombre_tramitante] [varchar](50) NULL,
	[dni_tramitante] [varchar](8) NULL,
	[asunto_tramitante] [varchar](500) NULL,
	[id_area] [int] NULL,
	[nombre_area] [varchar](100) NULL,
	[fecha_registro] [datetime] NULL,
	[estado] [varchar](20) NULL,
	[observacion] [varchar](8000) NULL,
	[imagen] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_correlativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__detalle_d__numer__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalle_documento_externo]'))
ALTER TABLE [dbo].[detalle_documento_externo]  WITH CHECK ADD FOREIGN KEY([numero_correlativo])
REFERENCES [dbo].[documento_externo] ([numero_correlativo])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__detalle_d__numer__267ABA7A]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalle_documento_interno]'))
ALTER TABLE [dbo].[detalle_documento_interno]  WITH CHECK ADD FOREIGN KEY([numero_correlativo])
REFERENCES [dbo].[documento_interno] ([numero_correlativo])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__documento__id_ar__145C0A3F]') AND parent_object_id = OBJECT_ID(N'[dbo].[documento_externo]'))
ALTER TABLE [dbo].[documento_externo]  WITH CHECK ADD FOREIGN KEY([id_area])
REFERENCES [dbo].[areas] ([id_area])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__documento__id_ar__1920BF5C]') AND parent_object_id = OBJECT_ID(N'[dbo].[documento_interno]'))
ALTER TABLE [dbo].[documento_interno]  WITH CHECK ADD FOREIGN KEY([id_area])
REFERENCES [dbo].[areas] ([id_area])
GO
