#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Prescriptions.Web/Prescriptions.Web.csproj", "Prescriptions.Web/"]
COPY ["ProjectDoctors/Prescriptions.Domain.csproj", "ProjectDoctors/"]
COPY ["ProjectDoctors.Infrastructure/Prescriptions.Infrastructure.csproj", "ProjectDoctors.Infrastructure/"]
RUN dotnet restore "Prescriptions.Web/Prescriptions.Web.csproj"
COPY . .
WORKDIR "/src/Prescriptions.Web"
RUN dotnet build "Prescriptions.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Prescriptions.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Prescriptions.Web.dll"]