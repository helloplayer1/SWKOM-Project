<<<<<<< HEAD
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
=======
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/PaperlessREST/PaperlessREST.csproj", "PaperlessREST/"]

# NuGet restore
RUN dotnet restore "PaperlessREST/PaperlessREST.csproj"
COPY ["src/PaperlessREST", "PaperlessREST/"]

#Copy All
COPY ["src/PaperlessREST.Entities","./PaperlessREST.Entities"]
COPY ["src/PaperlessREST.BusinessLogic.Entities","./PaperlessREST.BusinessLogic.Entities"]
COPY ["src/PaperlessREST.BusinessLogic","./PaperlessREST.BusinessLogic"]
COPY ["src/PaperlessREST.BusinessLogic.Interfaces","./PaperlessREST.BusinessLogic.Interfaces"]

# Build the API
WORKDIR "/src/PaperlessREST"
RUN dotnet build "PaperlessREST.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "PaperlessREST.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaperlessREST.dll"]

#FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
#
#ENV ASPNETCORE_URLS=http://*:8080
#
#WORKDIR /app/src
#COPY ./src/PaperlessREST/ ./
#
#RUN dotnet restore
#
#WORKDIR /app/src/PaperlessREST
#ENTRYPOINT dotnet watch run
>>>>>>> dev
