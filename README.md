# AltenTvMazeApi
### Pre-Requisites:
> <b>PostgreSQL</b>

- <u>AltenTvMaze - <b>Repositories</b></u>: This layer has the data access and the dbcontext. As the connection string is added here to use migrations from the console.
<u>In a production environment i used to use an appsettings file.</u>

<p>
    <ol>
    <li>Change the connection string in AltenTvMazeRepositories/Data/TvMazeContext.cs line 14.</li>
    <li>In sh execute: dotnet ef database update -- project AltenTvMazeRepositories</li>
    </ol> 
</p>

- <u>AltenTvMaze - <b>Services</b></u>: The business logic.
I did set a condition to update the Show entity in the database, it is updated when the last updated date is more than 1 day.
- <u>AltenTvMaze - <b>Models</b></u>: Data models. (I did use it in AltenTvMazeApi too, the correct must be put it in another layer called DTO)

- <u>AltenTvMaze - <b>Api</b></u>: Client/Front Swagger is implemented.
I use JWT.
To get token to use ShowController/update, you need to use Auth/token with these parameter
User: user
Password: p455w0rd

The objet will return the token: "token value"
To login, click on the candado an put
Bearer {token}

<u>Example:</u>
Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InVzZXIiLCJuYmYiOjE3MjEwNTUxNTMsImV4cCI6MTcyMTA2MjM1MywiaWF0IjoxNzIxMDU1MTUzLCJpc3MiOiJBbHRlblR2TWF6ZUFQSSIsImF1ZCI6IkFsdGVuVHZNYXplQVBJIn0.loVzUf8fqTM5teqOwi69zn0ewTtQKYskdsmn8K3If9s





