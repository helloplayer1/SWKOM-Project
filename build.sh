#!/usr/bin/env bash
#
# Generated by: https://openapi-generator.tech
#

dotnet restore src/PaperlessREST/ && \
    dotnet build src/PaperlessREST/ && \
    echo "Now, run the following to start the project: dotnet run -p src/PaperlessREST/PaperlessREST.csproj --launch-profile web"
