docker login -u melekus

docker images

docker build -f Patient.Web/Dockerfile -t melekus/hospitapp:Microservice_Patient_latest  .

docker images

docker push melekus/hospitapp:Microservice_Patient_latest

pause
