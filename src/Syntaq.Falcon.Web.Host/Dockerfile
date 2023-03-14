#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/FormBizz.Web.Host/FormBizz.Web.Host.csproj", "src/FormBizz.Web.Host/"]
COPY ["src/FormBizz.Web.Core/FormBizz.Web.Core.csproj", "src/FormBizz.Web.Core/"]
COPY ["src/FormBizz.Application/FormBizz.Application.csproj", "src/FormBizz.Application/"]
COPY ["src/FormBizz.Application.Shared/FormBizz.Application.Shared.csproj", "src/FormBizz.Application.Shared/"]
COPY ["src/FormBizz.Core.Shared/FormBizz.Core.Shared.csproj", "src/FormBizz.Core.Shared/"]
COPY ["src/FormBizz.Core/FormBizz.Core.csproj", "src/FormBizz.Core/"]
COPY ["src/FormBizz.EntityFrameworkCore/FormBizz.EntityFrameworkCore.csproj", "src/FormBizz.EntityFrameworkCore/"]
COPY ["src/FormBizz.GraphQL/FormBizz.GraphQL.csproj", "src/FormBizz.GraphQL/"]
RUN dotnet restore "src/FormBizz.Web.Host/FormBizz.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/FormBizz.Web.Host"
RUN dotnet build "FormBizz.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FormBizz.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FormBizz.Web.Host.dll"]
