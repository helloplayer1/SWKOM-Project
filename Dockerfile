FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

ENV ASPNETCORE_URLS=http://*:8080

WORKDIR /app/src
COPY ./src/PaperlessREST/ ./

RUN dotnet restore

WORKDIR /app/src/PaperlessREST
ENTRYPOINT dotnet watch run