#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/FormBizz.Migrator/FormBizz.Migrator.csproj", "src/FormBizz.Migrator/"]
COPY ["src/FormBizz.EntityFrameworkCore/FormBizz.EntityFrameworkCore.csproj", "src/FormBizz.EntityFrameworkCore/"]
COPY ["src/FormBizz.Core/FormBizz.Core.csproj", "src/FormBizz.Core/"]
COPY ["src/FormBizz.Core.Shared/FormBizz.Core.Shared.csproj", "src/FormBizz.Core.Shared/"]
RUN dotnet restore "src/FormBizz.Migrator/FormBizz.Migrator.csproj"
COPY . .
WORKDIR "/src/src/FormBizz.Migrator"
RUN dotnet build "FormBizz.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FormBizz.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FormBizz.Migrator.dll", "-s"]
