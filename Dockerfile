# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

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

# Defina o diretório de trabalho do Nginx
WORKDIR /usr/share/nginx/html

# Copie os arquivos publicados do Blazor WebAssembly
COPY --from=publish /app/publish/wwwroot .

# Copie o arquivo de configuração do Nginx
COPY nginx.conf /etc/nginx/nginx.conf

# Defina permissões adequadas para os arquivos
RUN chmod -R 755 /usr/share/nginx/html

# Exponha a porta 80
EXPOSE 80

# Comando para iniciar o Nginx
CMD ["nginx", "-g", "daemon off;"]