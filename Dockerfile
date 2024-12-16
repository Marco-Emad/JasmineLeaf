# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["JasmineLeaf.csproj", "./"]
RUN dotnet restore "JasmineLeaf.csproj"
COPY . .
RUN dotnet build "JasmineLeaf.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JasmineLeaf.csproj" -c Release -o /app/publish

# Copy the build files to the base image and set entrypoint
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JasmineLeaf.dll"]
