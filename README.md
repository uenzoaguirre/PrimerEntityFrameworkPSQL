No necesitamos crear ninguna base de datos, solo necesitamos que postgresql server este ejecutandose.

En AgendaContext se detalla la cadena para conectarse al servidor,

`Server=localhost;Port=5432;Database=ej1t;Username=admin;Password=admin`

de ahi se puede cambiar el servidor si es remoto, el puerto pero gralmente es 5432 por defecto. El nombre de la base de datos donde van a estar las tablas, usuario y contraseña para conectarse al server y la bd.

# Instalar los paquetes

`dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0`

`dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0`

instalar el/los paquetes para el engine que vamos a usar

`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.0`

crear el manifest para instalar las herramientas de dontnet localmente

`dotnet new tool-manifest`

installar la herramienta de entityframework

`dotnet tool install dotnet-ef --version=5.0.0`

Desde este paso ya tenemos todo, procedemos a crear todas las tablas [mas info](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

`dotnet dotnet-ef migrations add InitialCreate`

Este nos creó una carpeta llamada Migrations donde estan las instrucciones para crear la base de datos. Pero corriendo el siguiente comando se crea la base y las tablas

`dotnet ef database update`

### **Fin.**