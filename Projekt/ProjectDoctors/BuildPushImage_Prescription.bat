docker login -u melekus

docker images

docker build -f Prescriptions.Web/Dockerfile -t melekus/hospitapp:Microservice_Prescriptions_latest  .

docker images

docker push melekus/hospitapp:Microservice_Prescriptions_latest

pause
