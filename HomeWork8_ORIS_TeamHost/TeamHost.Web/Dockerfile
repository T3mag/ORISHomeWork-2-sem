FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["hw8/hw8.csproj", "hw8/"]
RUN dotnet restore "hw8/hw8.csproj"
COPY . .
WORKDIR "/src/hw8"
RUN dotnet build "hw8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hw8.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hw8.dll"]
