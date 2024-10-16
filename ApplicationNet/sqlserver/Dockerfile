# Usar la imagen base de SQL Server 2019
FROM mcr.microsoft.com/mssql/server:2019-latest

# Cambiar al usuario root para instalar paquetes
USER root

# Instalar dependencias necesarias y mssql-tools
RUN apt-get update && \
    apt-get install -y curl apt-transport-https gnupg ca-certificates && \
    curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > /etc/apt/trusted.gpg.d/microsoft.gpg && \
    echo "deb [arch=amd64] https://packages.microsoft.com/ubuntu/20.04/prod focal main" > /etc/apt/sources.list.d/mssql-release.list && \
    apt-get update && \
    ACCEPT_EULA=Y apt-get install -y mssql-tools unixodbc-dev && \
    echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> /etc/bash.bashrc && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Volver al usuario mssql
USER mssql
