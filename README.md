# account


Account bilgilerinin tutulduğu projedir.

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
$ docker pull keramiozsoy/image-account
$ docker run -it --rm --name app-account -p 8003:80 image-account

$ curl http://localhost:8003/api/values

```
