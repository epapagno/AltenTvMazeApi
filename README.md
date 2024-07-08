# AltenTvMazeApi
## Pre-Requisites:
<b>PostgreSQL</b>

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
To get token to use ShowController/update

Auth/token
User: user
Passward: p455w0rd

