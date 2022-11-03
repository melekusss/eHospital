docker login -u melekus

docker ps -a

docker start paim_lab_examinationrooms

docker ps 

docker images

docker pull paim_lab_examinationrooms:ExaminationRooms_latest

docker run -d -p 8080:80 -p 44300:443 --name examinationrooms paim_lab_examinationrooms:ExaminationRooms_latest

docker inspect examinationrooms

curl -X GET "http://localhost:8080/examination-rooms" -H  "accept: text/plain"

::docker stop examinationrooms 

::docker rm examinationrooms 

pause
