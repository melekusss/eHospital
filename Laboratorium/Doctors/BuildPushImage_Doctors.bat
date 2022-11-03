docker login -u melekus

docker images

docker build -f WebApplication1/Dockerfile -t melekus/paim_lab_doctors:Doctors_latest  .

docker images

docker image ls --filter label=stage=paim_lab_Doctors_build

docker push melekus/paim_lab_doctors:Doctors_latest

pause
