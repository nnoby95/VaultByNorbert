#!/bin/bash
# VaultByNorbert Quick Deployment Script v1.0
# This includes all fixes discovered during deployment

set -e  # Exit on error

echo "=== VaultByNorbert Deployment Script ==="
echo "Starting deployment with all critical fixes..."
echo ""

# Check if running as root
if [ "$EUID" -ne 0 ]; then 
    echo "Please run as root (use sudo)"
    exit 1
fi

# Update system
echo "1. Updating system packages..."
apt update && apt upgrade -y

# Install dependencies
echo "2. Installing dependencies..."
apt install -y postgresql postgresql-contrib nginx git curl wget nano nodejs npm

# Install .NET 7.0
echo "3. Installing .NET 7.0..."
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
apt update
apt install -y dotnet-sdk-7.0

# Setup PostgreSQL
echo "4. Setting up PostgreSQL..."
DB_PASS=$(openssl rand -base64 32 | tr -d "=+/" | cut -c1-25)
sudo -u postgres psql << SQL
CREATE USER twu_vault WITH PASSWORD '$DB_PASS';
CREATE DATABASE vault OWNER twu_vault;
GRANT ALL PRIVILEGES ON DATABASE vault TO twu_vault;
SQL

echo "Database Password: $DB_PASS" > /root/vault-credentials.txt

# Create directories
echo "5. Creating directory structure..."
mkdir -p /vault/{src,bin/{webapp,manage,update}}

# The fixes are already in the source code from git!
echo "6. Building applications..."
cd /vault/src/app/TW.Vault.App
dotnet publish -c Release -r linux-x64 --self-contained false -o /vault/bin/webapp

cd /vault/src/app/TW.Vault.Manage  
dotnet publish -c Release -r linux-x64 --self-contained false -o /vault/bin/manage

cd /vault/src/app/TW.Vault.MapDataFetcher
dotnet publish -c Release -r linux-x64 --self-contained false -o /vault/bin/update

# Create start scripts
echo "7. Creating start scripts..."
echo '#!/bin/bash
cd /vault/bin/webapp
dotnet TW.Vault.App.dll' > /vault/bin/webapp/start.sh

echo '#!/bin/bash
cd /vault/bin/manage
dotnet TW.Vault.Manage.dll' > /vault/bin/manage/start.sh

echo '#!/bin/bash
cd /vault/bin/update
dotnet TW.Vault.MapDataFetcher.dll' > /vault/bin/update/start.sh

chmod +x /vault/bin/*/start.sh

# Run migrations
echo "8. Running database migrations..."
cd /vault/src/app/TW.Vault.Migration
export ConnectionStrings__Vault="Server=localhost;Port=5432;Database=vault;User Id=twu_vault;Password=$DB_PASS"
dotnet run

echo ""
echo "=== Deployment Complete! ==="
echo "Database password saved in: /root/vault-credentials.txt"
echo ""
echo "Next steps:"
echo "1. Configure systemd services"
echo "2. Setup NGINX"
echo "3. Run configuration fetcher for game worlds"
echo ""
