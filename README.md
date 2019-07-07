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
$  docker pull keramiozsoy/image-account
$  docker run -it --rm --name project-account -p 8002:8002 image-account // just run

$ curl http://localhost:8003/api/values

```
