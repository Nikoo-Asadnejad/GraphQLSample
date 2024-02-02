FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Sample.GraphQL/Sample.GraphQL.csproj", "Sample.GraphQL/"]
RUN dotnet restore "Sample.GraphQL/Sample.GraphQL.csproj"
COPY . .
WORKDIR "/src/Sample.GraphQL"
RUN dotnet build "Sample.GraphQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample.GraphQL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample.GraphQL.dll"]
