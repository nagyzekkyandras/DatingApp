# Dating App

Udemy course: https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/

### commands
```sh
dotnet --info

# list templates
dotnet new list

# create solution file
dotnet new sln

# create .Net web application template
dotnet new webapi -n api

# add to solution file
dotnet sln add api/

# list projects
dotnet sln list

# run the project
dotnet run

# test the template api
curl http://localhost:5000/WeatherForecast

# run other profiles
dontnet run -lp https

# cert gen (if needed)
dotnet dev-certs https --clean
dotnet dev-certs https --trust

# open the swagger
https://localhost:5001/swagger/index.html

# install dotnet Entity Framework Core Tools (CLI)
dotnet tool install --global dotnet-ef --version 7.0.8

# Enables these commonly used dotnet-ef commands:
dotnet ef migrations add
dotnet ef migrations list
dotnet ef migrations script
dotnet ef dbcontext info
dotnet ef dbcontext scaffold
dotnet ef database drop
dotnet ef database update

# list the globally installed dotnet tools
dotnet tool list -g

# make a migration
dotnet ef migrations add InitialCreate -o Data/Migrations

# run the generated migrations and create the database
dotnet ef database update

# new template gitignore
dontnet new gitignore
```