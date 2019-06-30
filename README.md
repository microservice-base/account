# account


```
$ dotnet new webapi -o account --no-https
```

```
$ cd account 
$ dotnet run 
```

```
$ open http://localhost:5000/api/values
```

## docker 

```
$ git clone https://github.com/microservice-base/account.git
$ cd account
$ docker build -t image-account -f container/docker/Dockerfile .

```
