FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Nucleos.API/Nucleos.API.csproj", "Nucleos.API/"]
RUN dotnet restore "src/Nucleos.API/Nucleos.API.csproj"
COPY . .
WORKDIR "/src/Nucleos.API"
RUN dotnet build "Nucleos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nucleos.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nucleos.API.dll"]
