#!/bin/bash
# enter the github repository
cd ~/delivery-api
# ignore local changes and pull
git fetch origin main
git reset --hard origin/main
echo ''
git pull origin main
dotnet format
git add .
eval 'git commit -m "Deploy commit $(date '+%Y%m%d-%H:%M:%S')"'
git push --force
echo ''
echo '$(git log -1)'
# publish project to nginx folder
sudo dotnet clean
sudo dotnet publish -f net6.0 -o /var/www/delivery-api/ -c Release -r linux-x64 --self-contained false
echo ''
# reload services
sudo systemctl restart delivery-api.service
echo ''
# show service status
echo 'WebApi Status: $(sudo systemctl is-active delivery-api.service)'
