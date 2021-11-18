# Instalar los paquetes

`dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0`

`dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0`

instalar el/los paquetes para el engine que vamos a usar

`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.0`

crear el manifest para instalar las herramientas de dontnet localmente

`dotnet new tool-manifest`

installar la herramienta de entityframework

`dotnet tool install dotnet-ef --version=5.0.0`

Desde este paso ya tenemos todo, aca explica como crear las bases de datos https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

`dotnet dotnet-ef migrations add InitialCreate`

Este nos creó una carpeta llamada Migrations donde estan las instrucciones para crear la base de datos. Pero corriendo el siguiente comando se crea la base y las tablas

`dotnet ef database update`

### **Fin.**