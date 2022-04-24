FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.1" description="Aplicacao Demo Docker em .Net 6"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","Fansoft.DemoDocker.Api.dll"]

# docker build -t fabianonalin/demoaspnet6:2.0 .

# Rodar MySQL:
    # docker image pull --platform linux/amd64 mysql:5.7 (p/ mac arm m1)
    # docker volume create mysqldb
    # docker run --name mysql -e MYSQL_ROOT_PASSWORD=123456@qwerty -p 3306:3306 -v mysqldb:/var/lib/mysql -d mysql:5.7 

# docker network inspect bridge (p/ pegar o ip do container mysql)

# docker container run --rm  -p 3000:80 --name appdemo -e DBHOST=172.17.0.2 fabianonalin/demoaspnet6:2.0
    # teste -> http://localhost:3000/api/v1/produtos
    
# docker login -u fabianonalin
# docker image push fabianonalin/demoaspnet6:1.0
