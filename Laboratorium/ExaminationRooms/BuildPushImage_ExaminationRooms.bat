docker login -u melekus

docker images

docker build -f ExaminationRooms.Web/Dockerfile -t melekus/paim_lab_examinationrooms:ExaminationRooms_latest  .

docker images

docker image ls --filter label=stage=paim_lab_ExaminationRooms_build

docker push melekus/paim_lab_examinationrooms:ExaminationRooms_latest 

pause
