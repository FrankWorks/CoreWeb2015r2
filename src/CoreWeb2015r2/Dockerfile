FROM microsoft/aspnetcore:1.0.1
ENTRYPOINT ["dotnet", "CoreWeb2015r2.dll"]
ARG source=.
WORKDIR /app
EXPOSE 80
COPY $source .
