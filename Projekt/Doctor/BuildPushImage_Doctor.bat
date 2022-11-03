docker login -u melekus

docker images

docker build -f Doctor/Dockerfile -t melekus/hospitapp:Microservice_Doctor_latest  .

docker images

docker push melekus/hospitapp:Microservice_Doctor_latest

pause
