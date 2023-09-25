FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Koszalka.WebAPI/Koszalka.WebAPI.csproj", "Koszalka.WebAPI/"]
RUN dotnet restore "Koszalka.WebAPI/Koszalka.WebAPI.csproj"
COPY . .
WORKDIR "/src/Koszalka.WebAPI"
RUN dotnet build "Koszalka.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Koszalka.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Koszalka.WebAPI.dll"]