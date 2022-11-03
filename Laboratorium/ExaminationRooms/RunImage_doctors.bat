docker login -u melekus

docker ps -a

docker start paim_lab_doctors

docker ps 

docker images

docker pull paim_lab_doctors:Doctors_latest

docker run -d -p 8082:80 -p 44302:443 --name doctors paim_lab_doctors:Doctors_latest

docker inspect doctors 

curl -X GET "http://localhost:8082/Doctors" -H  "accept: text/plain"

::docker stop doctors 

::docker rm doctors 

pause
