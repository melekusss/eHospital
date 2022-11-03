docker login -u melekus

docker images

docker build -f ExaminationRoomsSelector.Web/Dockerfile -t melekus/paim_lab_examinationroomsselector:ExaminationRoomsSelector_latest .

docker images

docker image ls --filter label=stage=paim_lab_ExaminationRooms_build

docker push melekus/paim_lab_examinationroomsselector:ExaminationRoomsSelector_latest

pause
