#!/bin/bash
cd ~/delivery-api
export PATH="$PATH:$HOME/.dotnet/tools"
clear_build() {
  sudo rm -r ./*/bin
  sudo rm -r ./*/obj
}
# ignore local changes and pull
echo "Updating local repository..."
echo ""
git fetch origin main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
git reset --hard origin/main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
git pull origin main 2>&1> /dev/null && sudo chmod +x ./deploy.sh
echo "Deploying commit: $(git log --pretty=format:'%s (%an - %ae)' -1)"
echo ""
echo "Formating code..."
dotnet format 2>&1> /dev/null
export ASPNETCORE_ENVIRONMENT=Development
echo ""
echo "Updating $ASPNETCORE_ENVIRONMENT environment..."
clear_build 2>&1> /dev/null
dotnet ef database update --project ./Delivery.Api 2>&1> /dev/null
echo ""
echo "$ASPNETCORE_ENVIRONMENT environment update completed..."

# test
echo ""
echo "Starting the test..."
dotnet test 2>&1> /dev/null
result=$?

echo ""
if [ $result -eq 0 ]; then
  echo "Test completed successfully!"
  echo ""
  echo "Pushing deploy commit..."
  git add . 2>&1> /dev/null
  git commit -m "Deploy commit $(date '+%Y%m%d-%H:%M:%S')" 2>&1> /dev/null
  git push 2>&1> /dev/null
  echo ""
  if [ $? -eq 0 ]; then
    echo "The main branch has been updated!"
    echo "Deploy commit: $(git log --pretty=format:'%s (%an - %ae)' -1)"
  else
    echo "Error updating main branch!"
  fi
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