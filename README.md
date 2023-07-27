# Dating App

Udemy course: https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/

### dotnet related commands
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

# new migration run
dotnet ef migrations add UserPasswordAdded
# commit the changes
dotnet ef database update
```

### angular related commands
```sh
# check versions
node --version
npm --version
ng version

# install and use specific versions
nvm install 16.10.0
nvm use 16.10.0
nvm alias default 16.10.0
npm install -g @angular/cli@14

# create project
ng new client

# run the angular app
ng serve

# install bootstrap
ng add ngx-bootstrap
# or
npm install ngx-bootstrap --save

# create new componenet navigation
ng g c nav

# without tests
ng g c nav --skip-tests 

# create a new service with specified folder
ng g s _services/account --skip-tests 
```

### Useful pages
- https://jwt.ms/
- https://jwt.io/
- https://github.com/scttcper/ngx-toastr
- https://bootswatch.com/