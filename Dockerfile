FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dotnet-build
WORKDIR /build

COPY server .

RUN dotnet restore Server.csproj
RUN dotnet build Server.csproj --no-restore -c Release
RUN dotnet publish Server.csproj --no-restore --no-build -c Release -o /publish

FROM node AS node-build
WORKDIR /build

COPY client .

RUN npm ci
RUN npm run build

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env
WORKDIR /app

COPY --from=dotnet-build /publish .
COPY --from=node-build /build/dist ./wwwroot

ENTRYPOINT [ "dotnet", "Server.dll" ]
