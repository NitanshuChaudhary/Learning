# Use the official .NET 8.0 SDK as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory in the container
WORKDIR /src

# Copy the project file and restore any dependencies
COPY ["ConsoleTest.csproj", "ConsoleTest/"]
RUN dotnet restore "ConsoleTest/ConsoleTest.csproj"

# Copy the rest of the application source code
COPY . .

# Build the application in Release mode and output to /app/build
WORKDIR "/src/ConsoleTest"
RUN dotnet build "ConsoleTest.csproj" -c Release -o /app/build

# Publish the app to a folder named /app/publish
RUN dotnet publish "ConsoleTest.csproj" -c Release -o /app/publish

# Use the official .NET runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory for the runtime container
WORKDIR /app

# Copy the published app from the build container
COPY --from=build /app/publish .

# Define the entry point for the application
ENTRYPOINT ["dotnet", "ConsoleTest.dll"]
