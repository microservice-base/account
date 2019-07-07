FROM microsoft/dotnet:2.2-sdk AS build

#RUN dotnet dev-certs https --trust

RUN git clone https://github.com/microservice-base/account.git

WORKDIR /account/account

RUN dotnet restore

RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime

WORKDIR /app

COPY --from=build /account/account/out .

ENTRYPOINT ["dotnet","account.dll"]




