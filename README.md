# blazor-wasm-pwa-sample
sample blazor app with sqlite

Install dotnet ef as global :

dotnet tool install --global dotnet-ef

project creation - template :

dotnet new -i Microsoft.AspNetCore.Components.WebAssembly.Templates::3.2.0-rc1.20223.4


For database creation :

dotnet ef migrations add InitialCreate
dotnet ef database update
