FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["hw9/hw9.csproj", "hw9/"]
RUN dotnet restore "hw9/hw9.csproj"
COPY . .
WORKDIR "/src/TeamHost"
RUN dotnet build "hw9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hw9.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hw9.dll"]
