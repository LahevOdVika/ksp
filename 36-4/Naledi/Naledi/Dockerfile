FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Naledi/Naledi.csproj", "Naledi/"]
RUN dotnet restore "Naledi/Naledi.csproj"
COPY . .
WORKDIR "/src/Naledi"
RUN dotnet build "Naledi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Naledi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Naledi.dll"]
