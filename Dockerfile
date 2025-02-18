# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Exponha a porta do servidor
EXPOSE 8080

WORKDIR /src

# Copie o arquivo .csproj e restaure as dependências
COPY CalculaFacil.csproj .
RUN dotnet restore CalculaFacil.csproj

# Copie o restante do código e compile a aplicação
COPY . .
RUN dotnet build CalculaFacil.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish CalculaFacil.csproj -c Release -o /app/publish

# Etapa 2: Configuração do servidor
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY ngix.conf /etc/nginx/nginx.conf