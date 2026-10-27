FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Arishma.Outreach.Api/Arishma.Outreach.Api.csproj src/Arishma.Outreach.Api/
COPY src/Arishma.Outreach.Application/Arishma.Outreach.Application.csproj src/Arishma.Outreach.Application/
COPY src/Arishma.Outreach.Domain/Arishma.Outreach.Domain.csproj src/Arishma.Outreach.Domain/
COPY src/Arishma.Outreach.Infrastructure/Arishma.Outreach.Infrastructure.csproj src/Arishma.Outreach.Infrastructure/
RUN dotnet restore src/Arishma.Outreach.Api/Arishma.Outreach.Api.csproj
COPY . .
RUN dotnet publish src/Arishma.Outreach.Api/Arishma.Outreach.Api.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://*:5004
ENTRYPOINT ["dotnet", "Arishma.Outreach.Api.dll"]
