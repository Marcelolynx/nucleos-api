FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Nucleos.Services/Nucleos.Services.csproj", "Nucleos.Services/"]
RUN dotnet restore "src/Nucleos.Services/Nucleos.Services.csproj"
COPY . .
WORKDIR "/src/Nucleos.Services"
RUN dotnet build "Nucleos.Services.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nucleos.Services.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nucleos.Services.dll"]
