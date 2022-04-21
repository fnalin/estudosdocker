FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.1" description="Aplicacao Demo Docker em .Net 6"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","Fansoft.DemoDocker.Api.dll"]

# docker build -t fabianonalin/demoaspnet6:1.0 .
# docker container run --rm  -p 3000:80 --name appdemo fabianonalin/demoaspnet6:1.0
# docker login -u fabianonalin
# docker image push fabianonalin/demoaspnet6:1.0
