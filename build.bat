:: Generated by: https://openapi-generator.tech
::

@echo off

dotnet restore src\PaperlessREST
dotnet build src\PaperlessREST
echo Now, run the following to start the project: dotnet run -p src\PaperlessREST\PaperlessREST.csproj --launch-profile web.
echo.
