#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Visits.Web/Visits.Web.csproj", "Visits.Web/"]
COPY ["Visits.Infrastructure/Visits.Infrastructure.csproj", "Visits.Infrastructure/"]
COPY ["Visits.Domain/Visits.Domain.csproj", "Visits.Domain/"]
RUN dotnet restore "Visits.Web/Visits.Web.csproj"
COPY . .
WORKDIR "/src/Visits.Web"
RUN dotnet build "Visits.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Visits.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Visits.Web.dll"]