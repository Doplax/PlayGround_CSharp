# Use the official .NET SDK to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore
COPY ../*.sln .                        
COPY *.csproj ./                      
RUN dotnet restore

# Copy the rest and build
COPY . .                              
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "API.dll"]
