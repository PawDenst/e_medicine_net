docker login -u pawelqq1

docker-compose -f docker-compose.yaml ps

docker-compose -f docker-compose.yaml config

docker-compose -f docker-compose.yaml up --detach

curl -X GET  http://localhost:8082/prescriptions-by-doctor-id?doctorId=1  -H accept: text/plain

curl -X GET  http://localhost:8081/visitsByPatientId?patientId=1 -H  "accept: text/plain"

curl -X GET http://localhost:8081/visitsByDoctorId?doctorId=1 -H  "accept: text/plain"

curl -X GET http://localhost:8081/visits -H  "accept: text/plain"



pause
