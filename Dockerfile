FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Items/Items.csproj", "Items/"]
RUN dotnet restore "Items/Items.csproj"
COPY . .
WORKDIR "/src/Items"
RUN dotnet build "Items.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Items.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Items.dll"]