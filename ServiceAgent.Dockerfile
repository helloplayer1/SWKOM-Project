#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Build container
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/PaperlessREST.ServiceAgents/PaperlessREST.ServiceAgents.csproj", "PaperlessREST.ServiceAgents/"]


# NuGet restore
RUN dotnet restore "PaperlessREST.ServiceAgents/PaperlessREST.ServiceAgents.csproj"
COPY ["src/PaperlessREST.ServiceAgents", "PaperlessREST.ServiceAgents/"]

#Copy All
COPY ["src/PaperlessREST","./PaperlessREST"]
COPY ["src/PaperlessREST.Entities","./PaperlessREST.Entities"]
COPY ["src/PaperlessREST.BusinessLogic.Entities","./PaperlessREST.BusinessLogic.Entities"]
COPY ["src/PaperlessREST.BusinessLogic","./PaperlessREST.BusinessLogic"]
COPY ["src/PaperlessREST.BusinessLogic.Interfaces","./PaperlessREST.BusinessLogic.Interfaces"]
COPY ["src/PaperlessREST.DataAccess.Sql","./PaperlessREST.DataAccess.Sql"]
COPY ["src/PaperlessREST.DataAccess.Entities","./PaperlessREST.DataAccess.Entities"]
COPY ["src/PaperlessREST.DataAccess.Interfaces","./PaperlessREST.DataAccess.Interfaces"]
COPY ["src/PaperlessREST.ServiceAgents.Interfaces","./PaperlessREST.ServiceAgents.Interfaces"]

# Build the ServiceAgent
WORKDIR "/src/PaperlessREST.ServiceAgents"
RUN dotnet build "PaperlessREST.ServiceAgents.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "PaperlessREST.ServiceAgents.csproj" -c Release -o /app/publish 


# Make the final image for publishing
FROM build AS final
WORKDIR /app
COPY --from=publish /app/publish .

WORKDIR /app
ENTRYPOINT ["dotnet", "PaperlessREST.ServiceAgents.dll"]