# TIA1 - Windows Forms Three Tier Project

Aplicación de escritorio C# Windows Forms en .NET 9 adaptada al patrón de tres capas del proyecto de referencia `ThreeTierPattern`.

## Arquitectura

```text
TIA1.sln
├── TIA1.csproj    Presentación: formularios Windows Forms existentes en la raíz
├── CapaNegocio/   Reglas de negocio y validaciones
└── CapaDatos/     Acceso a SQL Server mediante procedimientos almacenados
```

Dependencias:

```text
TIA1 -> CapaNegocio -> CapaDatos -> SQL Server
```

La capa de presentación no se conecta directamente a SQL Server.

## Base de datos

La base usada es `BD_TEST` en SQL Server. El script está en:

```text
Database/BD_TEST.sql
```

Incluye:

- Creación de base `BD_TEST`.
- Tablas:
  - `USUARIO`
  - `CATEGORIA`
  - `PRODUCTO`
- Procedimientos almacenados de usuarios:
  - `SP_INSERTAR_USUARIO`
  - `SP_SELECCIONAR_USUARIO`
  - `SP_ACTUALIZAR_USUARIO`
  - `SP_ELIMINAR_USUARIO`
  - `SP_SELECCIONAR_ALL_USUARIO`
  - `SP_VALIDAR_USUARIO`
- Procedimientos almacenados de categorías:
  - `SP_INSERTAR_CATEGORIA`
  - `SP_SELECCIONAR_CATEGORIA`
  - `SP_ACTUALIZAR_CATEGORIA`
  - `SP_ELIMINAR_CATEGORIA`
  - `SP_SELECCIONAR_ALL_CATEGORIA`
- Procedimientos almacenados de productos:
  - `SP_INSERTAR_PRODUCTO`
  - `SP_SELECCIONAR_PRODUCTO`
  - `SP_ACTUALIZAR_PRODUCTO`
  - `SP_ELIMINAR_PRODUCTO`
  - `SP_SELECCIONAR_ALL_PRODUCTO`
- Usuario inicial:
  - Usuario: `admin`
  - Contraseña: `1234`
- Datos iniciales de prueba:
  - Categoría: `General`
  - Producto: `Producto de prueba`

## Conexión SQL Server

Por defecto la aplicación usa:

```text
Data Source=localhost\SQLEXPRESS;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;
```

Si tu servidor SQL usa otro nombre, podés sobrescribir la conexión con la variable de entorno:

```powershell
$env:TIA1_CONNECTION_STRING="Data Source=TU_SERVIDOR;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
```

## Ejecución inicial

1. Ejecutar el script `Database/BD_TEST.sql` en SQL Server.
2. Compilar la solución.
3. Iniciar la app.
4. Ingresar con:

```text
Usuario: admin
Contraseña: 1234
```

## Funcionalidad implementada

- Login real contra SQL Server.
- Formulario principal MDI.
- Formulario `Seguridad` con CRUD de usuarios.
- Formulario `Categorías` con CRUD de categorías.
- Formulario `Productos` con CRUD de productos.
- Capa de datos separada con `Microsoft.Data.SqlClient`.
- Capa de negocio separada con validaciones básicas.
