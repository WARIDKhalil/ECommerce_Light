#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ECommerce_Light_API/ECommerce_Light_API.csproj", "ECommerce_Light_API/"]
RUN dotnet restore "ECommerce_Light_API/ECommerce_Light_API.csproj"
COPY . .
WORKDIR "/src/ECommerce_Light_API"
RUN dotnet build "ECommerce_Light_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECommerce_Light_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECommerce_Light_API.dll"]