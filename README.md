# readme

the official training code

## command line

### git

- `git add <path> [<path>] .. [<path>]`, stage the changes to be committed
- `git commit -m '<message>'`, commit/save the staged changes
- `git clone <url> [<path>]`, copy remote repository locally with tracking
- `git status`, list the current changes
- `git log`, list the current commits

### dotnet

- `dotnet new sln -n <solution_name>`, create a new solution
- `dotnet tool install -g dotnet-ef`, install ef core cli tooling
- `dotnet ef migrations add`, create a migration for the current entity state
- `dotnet ef database update`, apply current migrations to database

### docker

- `docker container run -dit --rm --name sqlserver -p 1433:1433 -e 'ACCEPT_EULA=y' -e 'SA_PASSWORD=Password12345' mcr.microsoft.com/mssql/server:2017-latest`, launch a new sql server database

## maintainer

- fred belotte

## license

[MIT License](https://github.com/2002-24-dotnet/training-code/blob/master/LICENSE)
