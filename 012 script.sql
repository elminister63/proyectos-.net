USE [master]
GO
/****** Object:  Database [BASEMAGBRI]    Script Date: 08/11/2018 9:44:09 ******/
CREATE DATABASE [BASEMAGBRI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BASEMAGBRI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BASEMAGBRI.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BASEMAGBRI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BASEMAGBRI_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BASEMAGBRI] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BASEMAGBRI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BASEMAGBRI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET ARITHABORT OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BASEMAGBRI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BASEMAGBRI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BASEMAGBRI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BASEMAGBRI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BASEMAGBRI] SET  MULTI_USER 
GO
ALTER DATABASE [BASEMAGBRI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BASEMAGBRI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BASEMAGBRI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BASEMAGBRI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BASEMAGBRI] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BASEMAGBRI]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Caja](
	[Id_Caja] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Id_empresa] [int] NULL,
	[PC_Asignada] [varchar](50) NULL,
	[IP] [varchar](50) NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[Id_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[idclientev] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Direccion_para_factura] [varchar](max) NULL,
	[Ruc] [varchar](max) NULL,
	[Facebook] [varchar](max) NULL,
	[DNI] [varchar](50) NULL,
	[direccion_de_envio] [varchar](max) NULL,
	[telefono] [varchar](50) NULL,
	[movil] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Cliente] [varchar](50) NULL,
	[Proveedor] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idclientev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[Id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empresa] [varchar](50) NULL,
	[Logo] [image] NULL,
	[Impuesto] [varchar](50) NULL,
	[Porcentaje_impuesto] [numeric](18, 2) NULL,
	[Moneda] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Trabajas_con_impuestos] [varchar](50) NULL,
	[Modo_de_busqueda] [varchar](50) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[Id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto1]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto1](
	[Id_producto1] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Linea] [varchar](50) NULL,
	[Usa_inventarios] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Precio_de_compra] [numeric](18, 2) NULL,
	[Fecha_de_vencimiento] [varchar](50) NULL,
	[Precio_de_venta] [numeric](18, 2) NULL,
	[Codigo] [varchar](50) NULL,
	[Se_vende_a] [varchar](50) NULL,
	[Impuesto] [varchar](50) NULL,
	[Stock_minimo] [numeric](18, 2) NULL,
	[Precio_mayoreo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Producto1] PRIMARY KEY CLUSTERED 
(
	[Id_producto1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Serializacion]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Serializacion](
	[Id_serializacion] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](50) NULL,
	[numeroinicio] [varchar](50) NULL,
	[numerofin] [varchar](50) NULL,
	[Destino] [varchar](50) NULL,
	[Id_tipodoc] [varchar](50) NULL,
 CONSTRAINT [PK_Serializacion] PRIMARY KEY CLUSTERED 
(
	[Id_serializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO2]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO2](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_y_Apellidos] [varchar](50) NULL,
	[DNI] [varchar](50) NULL,
	[Telefono] [nchar](9) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Vendedor] [varchar](50) NULL,
	[Id_cargo] [int] NULL,
 CONSTRAINT [PK_USUARIO2] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idclientev] [int] NULL,
	[fecha_venta] [datetime] NULL,
	[Numero_de_doc] [varchar](50) NULL,
	[Monto_total] [numeric](18, 1) NULL,
	[Tipo_de_pago] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[IGV] [numeric](18, 1) NULL,
	[Guia_de_remision] [varchar](50) NULL,
	[Id_series] [varchar](50) NULL,
	[Id_usuario] [int] NULL,
	[Fecha_de_pago] [varchar](50) NULL,
	[ACCION] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [FK_Caja_EMPRESA] FOREIGN KEY([Id_empresa])
REFERENCES [dbo].[EMPRESA] ([Id_empresa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [FK_Caja_EMPRESA]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_USUARIO2]
GO
/****** Object:  StoredProcedure [dbo].[editar_caja]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[editar_caja]
@idcaja int,
@descripcion varchar(50)
as
update Caja  SET Descripcion=@descripcion 
wHERE Id_Caja =@idcaja 
GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[editar_Empresa]
 @Id_empresa int,
@Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,2),
@Moneda varchar(50),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50)
as
update  EMPRESA set Nombre_Empresa=@Nombre_Empresa,Logo=@logo ,Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,Moneda=@Moneda,Trabajas_con_impuestos=@Trabajas_con_impuestos
,Modo_de_busqueda=@Modo_de_busqueda 

where Id_empresa=@Id_empresa 
GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[editar_usuario]
@idusuario int,
@Nombre_y_Apellidos  varchar(50),
@DNI  varchar(50),
@Telefono  nchar(9),
@Login varchar(50),
@Password  varchar(50),
@Vendedor  varchar(50)

as
update USUARIO2 SET Nombre_y_Apellidos =@Nombre_y_Apellidos ,DNI=@DNI , Telefono=@Telefono ,Login =@Login ,
Password =@Password , Vendedor =@Vendedor 
wHERE idUsuario =@idusuario 
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Empresa]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[eliminar_Empresa]
@id_Empresa int
as
delete from EMPRESA 
where Id_empresa =@id_Empresa 


GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_usuario]
@idusuario int
as
delete from USUARIO2 where idUsuario =@idUsuario 
GO
/****** Object:  StoredProcedure [dbo].[Insertar_caja]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_caja]

	
	@descripcion varchar(50),
	@saldo numeric(18,2),
	@Id_empresa int,
	 @PC_Asignada varchar(50),
	 @IP as varchar(50)
	   
    as
	BEGIN
if EXISTS (SELECT Id_empresa,Descripcion     FROM Caja    where Id_empresa    = @Id_empresa and Descripcion=@descripcion   )
RAISERROR ('YA EXISTE UNA CAJA REGISTRADA CON ESE NOMBRE, Ingrese un nombre diferente', 16,1)
else
BEGIN
    INSERT INTO Caja values 
	(@descripcion,@saldo,@Id_empresa,@PC_Asignada ,@IP )

	end
	end
GO
/****** Object:  StoredProcedure [dbo].[insertar_Empresa]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertar_Empresa]                
          @Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,2),
@Moneda varchar(50),
@Saldo numeric(18,2),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50)
as 
 BEGIN
if EXISTS (SELECT Nombre_Empresa   FROM EMPRESA   where Nombre_Empresa  = @Nombre_Empresa   )
RAISERROR ('YA EXISTE UNA EMPRESA CON ESE NOMBRE, Ingrese un nombre diferente', 16,1)
else
BEGIN
insert into EMPRESA  
values (@Nombre_Empresa,@logo,@Impuesto,@Porcentaje_impuesto,@Moneda,@Saldo ,@Trabajas_con_impuestos,@Modo_de_busqueda)

END
END

GO
/****** Object:  StoredProcedure [dbo].[insertar_Producto]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertar_Producto]                
           @Descripcion varchar(50),
				         
         
          @Linea as varchar(50)	,
		  @Usa_inventarios varchar(50),
		   @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Impuesto varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
	
		   AS 
		   BEGIN
if EXISTS (SELECT Descripcion,Codigo  FROM Producto1  where Descripcion = @Descripcion OR Codigo=@Codigo  )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE/CODIGO, POR FAVOR INGRESE DE NUEVO/ SE GENERARA CODIGO AUTOMATICO', 16,1)
else
BEGIN
		   INSERT INTO Producto1
     VALUES
		    (

           @Descripcion
  
       		
		  
		    ,@Linea 
		,@Usa_inventarios	,


		@Stock ,
           @Precio_de_compra ,
           @Fecha_de_vencimiento ,
           @Precio_de_venta ,
           @Codigo ,
           @Se_vende_a ,
           @Impuesto ,
           @Stock_minimo ,
           @Precio_mayoreo
		 )
		    --RAISERROR ('Registrado correctamente', 16,1)
END
END

GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[insertar_usuario]
@Nombre_y_Apellidos  varchar(50),
@DNI  varchar(50),
@Telefono  nchar(9),
@Login varchar(50),
@Password  varchar(50),
@Vendedor  varchar(50),
@Id_cargo  int


as
if exists (select Login From USUARIO2 Where Login=@Login)
RAISERROR ('YA EXISTE UN USUARIO CON ESE LOGIN, POR FAVOR INGRESE DE NUEVO',16,1)
else
insert into USUARIO2 (Nombre_y_Apellidos,DNI ,Telefono,Login ,Password ,Vendedor,Id_cargo )
values(@Nombre_y_Apellidos,@DNI,@Telefono,@Login,@Password,@Vendedor,@Id_cargo )
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa_sin_ip]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_empresa_sin_ip]
@empresa varchar(50)
as
select Caja.Id_Caja ,Caja.Descripcion ,Caja.PC_Asignada, Caja.IP FROM Caja 
INNER JOIN EMPRESA ON Caja.Id_empresa=EMPRESA.Id_empresa 
where EMPRESA.Nombre_Empresa =@empresa 

GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  proc [dbo].[mostrar_Empresa]
as
select LOGO, Nombre_Empresa as Empresa ,
(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto 
,Moneda , Saldo ,Id_empresa  
,Porcentaje_impuesto  ,Impuesto ,Modo_de_busqueda 
from Empresa



GO
/****** Object:  StoredProcedure [dbo].[mostrar_Producto1]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_Producto1] 
as
select Id_Producto1,Codigo ,Linea as Categoria,Descripcion ,
Impuesto,Usa_inventarios ,Precio_de_compra AS P_Compra,Precio_mayoreo as P_mayoreo,
Se_vende_a as Se_vende_por,Stock_minimo ,Fecha_de_vencimiento as F_vencimiento ,
Stock,Precio_de_venta as P_venta  from Producto1 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_usuario] 
as
select *from USUARIO2 
GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 08/11/2018 9:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[validar_usuario]
@login varchar(50),
@password varchar(50)
as
select*from USUARIO2 
where Login=@login and Password=@password 
GO
USE [master]
GO
ALTER DATABASE [BASEMAGBRI] SET  READ_WRITE 
GO
