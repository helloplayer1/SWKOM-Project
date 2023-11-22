# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# ENV ASPNETCORE_URLS=http://*:8080

# WORKDIR /app/src
# COPY src/PaperlessREST/*.csproj ./src/PaperlessREST/
# COPY src/PaperlessREST.BusinessLogic/*.csproj ./src/PaperlessREST.BusinessLogic/
# COPY src/PaperlessREST.BusinessLogic.Entities/*.csproj ./src/PaperlessREST.BusinessLogic.Entities/
# COPY src/PaperlessREST.BusinessLogic.Interfaces/*.csproj ./src/PaperlessREST.BusinessLogic.Interfaces/
# COPY src/PaperlessREST.BusinessLogic.Tests/*.csproj ./src/PaperlessREST.BusinessLogic.Tests/
# COPY src/PaperlessREST.DataAccess.Tests/*.csproj ./src/PaperlessREST.DataAccess.Tests/
# COPY src/PaperlessREST.DataAccess.Entities/*.csproj ./src/PaperlessREST.DataAccess.Entities/
# COPY src/PaperlessREST.DataAccess.Interfaces/*.csproj ./src/PaperlessREST.DataAccess.Interfaces/
# COPY src/PaperlessREST.DataAccess.Sql/*.csproj ./src/PaperlessREST.DataAccess.Sql/
# COPY src/PaperlessREST.Entities/*.csproj ./src/PaperlessREST.Entities/

# RUN dotnet restore

# ENTRYPOINT dotnet watch run