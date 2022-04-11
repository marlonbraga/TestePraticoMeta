#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TestePraticoMeta.API/TestePraticoMeta.API.csproj", "TestePraticoMeta.API/"]
RUN dotnet restore "TestePraticoMeta.API/TestePraticoMeta.API.csproj"
COPY . .
WORKDIR "/src/TestePraticoMeta.API"
RUN dotnet build "TestePraticoMeta.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestePraticoMeta.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestePraticoMeta.API.dll"]