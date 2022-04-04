docker login -u melekus

docker images

docker build -f Visits.Web/Dockerfile -t melekus/hospitapp:Microservice_Visits_latest  .

docker images

docker push Visits.Web/Dockerfile -t melekus/hospitapp:Microservice_Visits_latest

pause
