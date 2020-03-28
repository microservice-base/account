# account


Account projesi, ana projenin kişi bilgilerinin tutulduğu alt projedir.


## How to create project 

```
$ dotnet new webapi -o account --no-https
```


## Contributing

[Contributing guide](CONTRIBUTING.md).


## How to run project

```
$ git clone https://github.com/microservice-base/account.git

$ cd account 

$ dotnet run 

$ open http://localhost:5000/api/values
```

## docker 

```
$ docker pull keramiozsoy/image-account
$ docker run -it --rm --name app-account -p 8003:80 image-account

$ curl http://localhost:8003/api/values

```
## kubernetes
