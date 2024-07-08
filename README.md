# AltenTvMazeApi
## Pre-Requisites:
PostgreSQL

- AltenTvMaze - Repositories: This layer has the data access and the dbcontext. As the connection string is added here to use migrations from the console. <u>In a production environment i used to use an appsettings file.</u>
</br>
<ul>
  <li>Change the connection string in AltenTvMazeRepositories/Data/TvMazeContext.cs line 14.</li>
  <li>In sh execute: dotnet ef database update -- project AltenTvMazeRepositories</li>
</ul> 

- AltenTvMaze - Services: The business logic.
I set a condition to update the TvShow, it is updated when the last updated date is more than 1 day.
AltenTvMaze - Models: Data models. (I did use it in AltenTvMazeApi too, the correct thing, must be put it in another layer called DTO)

- AltenTvMaze - Api: Client/Front Swagger is implemented.
To Login:
User: test
Passward: password
AutoController
