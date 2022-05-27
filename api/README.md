The API looks for a PostgreSQL server on localhost:6003, and authenticates with a username, password and database of 'envy'.

Set up a database with Docker.

```
docker container run -d --name envydb -e POSTGRES_USER=envy -e POSTGRES_PASSWORD=envy -e POSTGRES_DB=envy -e PGDATA=/postgres/envy/data -p 6003:5432 postgres
```

Start the ASP.NET API. Migrations will run and data will be seeded automatically.

```
cd ./src
dotnet run
```
