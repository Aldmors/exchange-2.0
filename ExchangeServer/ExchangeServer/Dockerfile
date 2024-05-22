#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ExchangeServer/ExchangeServer.csproj", "ExchangeServer/"]
RUN dotnet restore "./ExchangeServer/ExchangeServer.csproj"
COPY . .
WORKDIR "/src/ExchangeServer"
RUN dotnet build "./ExchangeServer.csproj" -c $BUILD_CONFIGURATION -o /app/build
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef database update

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ExchangeServer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExchangeServer.dll"]