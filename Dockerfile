# ---- Build image ----
FROM mcr.microsoft.com/dotnet/sdk:8.0 as build

WORKDIR /src

ENV ASPNETCORE_ENVIRONMENT=Production
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true

# Restore
COPY ./Knights.Challenge.Api/Knights.Challenge.API.csproj ./Knights.Challenge.Api/
RUN dotnet restore Knights.Challenge.Api/Knights.Challenge.API.csproj

# Sources
COPY . .

# Build
RUN dotnet publish ./Knights.Challenge.Api/*.csproj -c Release -o /app

# ---- Runtime image ----
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app


# SOURCES
COPY --from=build /app .

CMD ["dotnet", "Knights.Challenge.API.dll"]