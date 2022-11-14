#!/bin/bash
clear_build() {
  sudo rm -r ./*/bin
  sudo rm -r ./*/obj
}
# ignore local changes and pull
echo "Updating local repository..."
git fetch origin main 2>&1> /dev/null
git reset --hard origin/main 2>&1> /dev/null
git pull origin main 2>&1> /dev/null
chmod +x ./deploy.sh
echo "Deploying commit: $(git log --pretty=format:'%s (%an - %ae)' -1)"
dotnet format 2>&1> /dev/null
export ASPNETCORE_ENVIRONMENT=Development
echo "Updating $ASPNETCORE_ENVIRONMENT environment..."
clear_build
dotnet ef database update --project ./Delivery.Api 2>&1> /dev/null
echo "$ASPNETCORE_ENVIRONMENT environment update completed..."

# test
echo "Starting the test..."
dotnet test 2>&1> /dev/null
result=$?

if [ $result -eq 0 ]; then
  echo "Test completed successfully!"
  echo "Pushing deploy commit..."
  git add . 2>&1> /dev/null
  git commit -m "Deploy commit $(date '+%Y%m%d-%H:%M:%S')" 2>&1> /dev/null
  git push 2>&1> /dev/null
  if [ $? -eq 0 ]; then
    echo "The main branch has been updated!"
  else
    echo "Error updating main branch!"
  fi
  export ASPNETCORE_ENVIRONMENT=Production
  echo "Updating $ASPNETCORE_ENVIRONMENT environment..."
  # clear trash
  clear_build
  dotnet ef database update --project ./Delivery.Api 2>&1> /dev/null
  # publish project to nginx folder
  clear_build
  sudo dotnet publish -f net6.0 -o /var/www/delivery-api/ -c Release -r linux-x64 --self-contained false 2>&1> /dev/null
  # clear trash
  clear_build
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

echo ""
read -p "Press any key to close the terminal..."
