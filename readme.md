dotnet new webapi -o NombreDelProyecto
dotnet tool install --global dotnet-ef
dotnet ef migrations add NombreDeLaMigracion
dotnet ef database update