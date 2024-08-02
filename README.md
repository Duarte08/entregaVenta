## Instalación

Instrucciones para instalar y configurar el proyecto. Incluye requisitos previos y pasos detallados.

```bash
# Ejemplo de comandos para la instalación
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.Tools


```bash
# Ejemplo de comandos para la instalación CODE FIRST
Enable-Migrations
Add-Migration InitialCreate
Update-Database


Endpoints Disponibles
Account

    Inicio de Sesión
        Ruta: /Account/Login
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Cerrar Sesión
        Ruta: /Account/Logout
        Método HTTP: GET
    Página de Inicio
        Ruta: /Account/Index
        Método HTTP: GET
    Cargar Ventas (para Accountant)
        Ruta: /Account/LoadSales
        Método HTTP: GET
    Cargar Ventas (para Contador)
        Ruta: /Account/LoadSalesContador
        Método HTTP: GET

Home

    Página Principal
        Ruta: /Home/Index
        Método HTTP: GET
    Acerca de
        Ruta: /Home/About
        Método HTTP: GET
    Contacto
        Ruta: /Home/Contact
        Método HTTP: GET
    Página de Inicio para Vendedores
        Ruta: /Home/SellerHome
        Método HTTP: GET
    Página de Inicio para Contadores
        Ruta: /Home/AccountantHome
        Método HTTP: GET

Products

    Lista de Productos
        Ruta: /Products/Index
        Método HTTP: GET
    Cargar Productos
        Ruta: /Products/LoadProducts
        Método HTTP: GET
    Detalles del Producto
        Ruta: /Products/Details/{id}
        Método HTTP: GET
    Crear Producto
        Ruta: /Products/Create
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Editar Producto
        Ruta: /Products/Edit/{id}
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Eliminar Producto
        Ruta: /Products/Delete/{id}
        Método HTTP: GET (mostrar confirmación) y POST (confirmar eliminación)

Sales

    Lista de Ventas
        Ruta: /Sales/Index
        Método HTTP: GET
    Cargar Ventas
        Ruta: /Sales/LoadSales
        Método HTTP: GET
    Detalles de la Venta
        Ruta: /Sales/Details/{id}
        Método HTTP: GET
    Crear Venta
        Ruta: /Sales/Create
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Editar Venta
        Ruta: /Sales/Edit/{id}
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Eliminar Venta
        Ruta: /Sales/Delete/{id}
        Método HTTP: GET (mostrar confirmación) y POST (confirmar eliminación)

Users

    Lista de Usuarios
        Ruta: /Users/Index
        Método HTTP: GET
    Detalles del Usuario
        Ruta: /Users/Details/{id}
        Método HTTP: GET
    Crear Usuario
        Ruta: /Users/Create
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Editar Usuario
        Ruta: /Users/Edit/{id}
        Método HTTP: GET (mostrar formulario) y POST (procesar datos del formulario)
    Eliminar Usuario
        Ruta: /Users/Delete/{id}
        Método HTTP: GET (mostrar confirmación) y POST (confirmar eliminación)
