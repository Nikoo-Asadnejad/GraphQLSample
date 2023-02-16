FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GraphQl.Api/GraphQl.Api.csproj", "GraphQl.Api/"]
RUN dotnet restore "GraphQl.Api/GraphQl.Api.csproj"
COPY . .
WORKDIR "/src/GraphQl.Api"
RUN dotnet build "GraphQl.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GraphQl.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphQl.Api.dll"]
