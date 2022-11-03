docker login -u melekus

docker ps -a

docker start paim_lab_examinationroomsselector

docker ps 

docker images

docker pull paim_lab_examinationroomsselector:ExaminationRoomsSelector_latest

docker run -d -p 8081:80 -p 44301:443 --name examinationroomsselector paim_lab_examinationroomsselector:ExaminationRoomsSelector_latest

docker inspect examinationroomsselector 

curl -X GET "http://localhost:8081/examination-rooms-selection" -H  "accept: text/plain"

::docker stop examinationroomsselector 

::docker rm examinationroomsselector 

pause
