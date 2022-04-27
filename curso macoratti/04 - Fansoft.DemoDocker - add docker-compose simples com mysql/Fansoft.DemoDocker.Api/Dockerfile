FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.1" description="Aplicacao Demo Docker em .Net 6"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","Fansoft.DemoDocker.Api.dll"]

# docker build -t fabianonalin/demoaspnet6:3.0 .

# Crie 2 redes:
    # docker network create frontend
    # docker network create backend
    
# Rodar MySQL:
    # docker image pull --platform linux/amd64 mysql:5.7 (p/ mac arm m1)
    # docker volume create mysqldb
    # * s/ porta para isolar
    # docker container run --name mysql --network=backend -e MYSQL_ROOT_PASSWORD=123456@qwerty  -v mysqldb:/var/lib/mysql -d mysql:5.7

#

# docker container run -d  --network backend --name appdemo1 -e DBHOST=mysql fabianonalin/demoaspnet6:3.0
# docker container run -d  --network backend --name appdemo2 -e DBHOST=mysql fabianonalin/demoaspnet6:3.0
# docker container run -d  --network backend --name appdemo3 -e DBHOST=mysql fabianonalin/demoaspnet6:3.0
 
# add os containers appdemo a network frontend
    # docker network connect frontend appdemo1
    # docker network connect frontend appdemo2
    # docker network connect frontend appdemo3

# restart:
    # docker container start appdemo1 appdemo2 appdemo3
    
# crie load balancer
    # docker pull haproxy
    # docker container run -d --name loadbalancer --network frontend -v "$(pwd)/haproxy.cfg:/usr/local/etc/haproxy/haproxy.cfg" -p 3200:80 haproxy:latest
    #teste em 3 abas: http://localhost:3200/api/v1/produtos

    
# docker login -u fabianonalin
# docker image push fabianonalin/demoaspnet6:1.0
