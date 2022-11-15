#!/bin/bash
cd ~/delivery-api
export PATH="$PATH:$HOME/.dotnet/tools"
clear_build() {
  sudo rm -rf ./*/bin
  sudo rm -rf ./*/obj
}
# ignore local changes and pull
echo "Updating local repository..."
echo ""
git fetch origin main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
git reset --hard origin/main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
git pull origin main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
echo ""
echo "Target commit: $(git log --pretty=format:'%s (%an - %ae)' -1)"
echo ""
export ASPNETCORE_ENVIRONMENT=Development
echo "Updating $ASPNETCORE_ENVIRONMENT environment..."
clear_build 2>&1> /dev/null
dotnet ef database update --project ./Delivery.Api 2>&1> /dev/null
echo ""
echo "$ASPNETCORE_ENVIRONMENT environment update completed..."

# test
echo ""
echo "Starting the test..."
sudo dotnet test 2>&1> /dev/null
result=$?

echo ""
if [ $result -eq 0 ]; then
  echo "Test completed successfully!"
  echo ""
  export ASPNETCORE_ENVIRONMENT=Production
  echo "Updating $ASPNETCORE_ENVIRONMENT environment..."
  # clear trash
  clear_build 2>&1> /dev/null
  dotnet ef database update --project ./Delivery.Api 2>&1> /dev/null
  # publish project to nginx folder
  clear_build 2>&1> /dev/null
  sudo dotnet publish -f net6.0 -o /var/www/delivery-api/ -c Release -r linux-x64 --self-contained false 2>&1> /dev/null
  # clear trash
  clear_build 2>&1> /dev/null
  echo ""
  echo "Restarting service..."
  # reload services
  sudo systemctl restart delivery-api.service 2>&1> /dev/null
  echo ""
  # show service status
  echo "Service status: $(sudo systemctl is-active delivery-api.service)"
  echo "$ASPNETCORE_ENVIRONMENT environment update completed..."
else
  echo "Test ended with error!"
  echo "Aborting deploy..."
fi
