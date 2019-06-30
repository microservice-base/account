FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env

RUN git clone https://github.com/microservice-base/account.git


WORKDIR /account/account

ENTRYPOINT ["dotnet", "run"]


