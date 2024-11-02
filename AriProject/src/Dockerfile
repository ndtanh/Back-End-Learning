# Use the official image as a parent image.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory.
WORKDIR /src

# Copy csproj and restore dependencies
COPY *.sln ./
COPY AriProject.API/*.csproj ./AriProject.API/
COPY AriProject.Application/*.csproj ./AriProject.Application/
COPY AriProject.Domain/*.csproj ./AriProject.Domain/
COPY AriProject.Infrastructure/*.csproj ./AriProject.Infrastructure/
COPY . ./

# Copy everything else and build the project.
WORKDIR /src/AriProject.API
RUN dotnet restore
RUN dotnet publish -o Publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /src
COPY --from=build-env /src/AriProject.API/Publish . 

EXPOSE 5000
ENTRYPOINT ["dotnet", "AriProject.API.dll"]