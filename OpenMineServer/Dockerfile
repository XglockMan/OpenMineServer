FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OpenMineServer/OpenMineServer.csproj", "OpenMineServer/"]
RUN dotnet restore "OpenMineServer/OpenMineServer.csproj"
COPY . .
WORKDIR "/src/OpenMineServer"
RUN dotnet build "OpenMineServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenMineServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenMineServer.dll"]
