# Use the official .NET SDK to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore
COPY *.sln .
COPY API/*.csproj ./API/
RUN dotnet restore

# Copy the rest of the files and build
COPY . .
WORKDIR /app/API
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/API/out ./   
ENTRYPOINT ["dotnet", "API.dll"]    
