docker login -u pawelqq1

docker-compose -f docker-compose-lab.yaml ps

docker-compose -f docker-compose-lab.yaml config

docker-compose -f docker-compose-lab.yaml up --detach

curl -X GET "http://localhost:8082/doctors" -H  "accept: text/plain"

curl -X GET "http://localhost:8080/examination-rooms" -H  "accept: text/plain"

curl -X GET "http://localhost:8081/examination-rooms-selection" -H  "accept: text/plain"
docker-compose -f docker-compose-lab.yaml stop

docker-compose -f docker-compose-lab.yaml down

pause
