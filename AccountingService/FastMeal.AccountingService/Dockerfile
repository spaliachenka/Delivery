#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FastMeal.AccountingService/FastMeal.AccountingService.csproj", "FastMeal.AccountingService/"]
RUN dotnet restore "FastMeal.AccountingService/FastMeal.AccountingService.csproj"
COPY . .
WORKDIR "/src/FastMeal.AccountingService"
RUN dotnet build "FastMeal.AccountingService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FastMeal.AccountingService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FastMeal.AccountingService.dll"]