docker login -u melekus

docker-compose -f docker-compose.yaml ps

docker-compose -f docker-compose.yaml config

docker-compose -f docker-compose.yaml up --detach

curl -X GET  http://localhost:8082/prescriptions-by-doctor-id?doctorId=1  -H accept: text/plain

docker-compose -f docker-compose.yaml stop

docker-compose -f docker-compose.yaml down

pause
