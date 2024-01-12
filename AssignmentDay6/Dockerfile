#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AssignmentDay6/AssignmentDay6.csproj", "AssignmentDay6/"]
RUN dotnet restore "AssignmentDay6/AssignmentDay6.csproj"
COPY . .
WORKDIR "/src/AssignmentDay6"
RUN dotnet build "AssignmentDay6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AssignmentDay6.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AssignmentDay6.dll"]