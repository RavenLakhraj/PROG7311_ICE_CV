FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./CV_PROG7311_ST1029651.csproj"
RUN dotnet build "./CV_PROG7311_ST1029651.csproj" -c Release -o /app/build
RUN dotnet publish "./CV_PROG7311_ST1029651.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CV_PROG7311_ST1029651.dll"]
