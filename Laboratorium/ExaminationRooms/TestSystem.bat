curl -X GET "http://localhost:8080/Network/GetNodes?searchText=xxx" -H "accept: application/json"

curl -X GET "http://localhost:8081/Network/GetNodes?searchText=xxx" -H "accept: application/json"

curl -X GET "http://localhost:8080/Network/RunTests?host=localhost&port=80" -H "accept: application/json"

curl -X GET "http://localhost:8081/Network/RunTests?host=localhost&port=80" -H "accept: application/json"

curl -X GET "http://localhost:8080/Network/RunTests?host=data_webservicerest&port=80" -H "accept: application/json"

curl -X GET "http://localhost:8080/Network/RunTests?host=app_webservicerest&port=80" -H "accept: application/json"

curl -X GET "http://localhost:8081/Network/RunTests?host=data_webservicerest&port=80" -H "accept: application/json"

curl -X GET "http://localhost:8081/Network/RunTests?host=app_webservicerest&port=80" -H "accept: application/json"

pause
