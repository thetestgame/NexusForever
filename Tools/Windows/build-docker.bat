@echo off
title Build Docker Images
cd ../../

rem Builds the nexusforever-auth:latest Docker image on your local machine
echo Building auth server image
docker build . --tag nexusforever-auth --build-arg ServerExecutable=AuthServer

rem Builds the nexusforever-sts:latest Docker image on your local machine
echo Building sts server image
docker build . --tag nexusforever-sts --build-arg ServerExecutable=StsServer

rem Builds the nexusforever-world:latest Docker image on your local machine
echo Building world server image
docker build . --tag nexusforever-world --build-arg ServerExecutable=WorldServer

echo Done!
pause
exit 0