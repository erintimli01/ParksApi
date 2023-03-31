# _National Parks API_
### _An API for National Park Lookups_
#### By _**Erin Timlin**_


## Technologies Used

* _C#_
* _.Net 6_
* _ASP.NET_
* _SQL_
* _LINQ_
* _Swagger_

## Description

_Demonstrating knowledge of building API's, this API is a lookup for National State Parks and will list the park name and the city and state it's in._

## Setup/Installation Requirements

### To Open Project
* _Clone this repo_
* _Open the terminal and navigate to this project's production directory "ParksApi"_
* _Within this directory, create two new files: `appsettings.json` and `appsettings.Development.json`_
* _Within `appsettings.json`, insert the following code, first removing the [ ] brackets, and making sure to update `uid` and `pdw` with your personal MySQL credentials:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Within `appsettings.Development,json`, insert the following code:_
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```
* _Install dependencies within the "ParksApi" directory with `dotnet restore`_
* _Build and run the program in development mode with `dotnet run`_

## API Documentation

Please feel free to test this API via [Postman](https://www.postman.com/)! 

### Available End Points

```
 GET http://localhost:5297/api/v1/parks
 GET http://localhost:5297/api/v1/parks/{id}
 POST http://localhost:5297/api/v1/parks
 PUT http://localhost:5297/api/v1/parks/{id}
 DELETE http://localhost:5297/api/v1/parks/{id}
```
_Note: The '{id}' value in the URL is a variable and should be replaced with the id number of the park you want to GET, PUT, or DELETE_

_{Leave nothing to chance! You want it to be easy for potential users, employers and collaborators to run your app. Do I need to run a server? How should I set up my databases? Is there other code this application depends on? We recommend deleting the project from your desktop, re-cloning the project from GitHub, and writing down all the steps necessary to get the project working again.}_

## Known Bugs

* _Any known issues_
* _should go here_

## License

_{Let people know what to do if they run into any issues or have questions, ideas or concerns.  Encourage them to contact you or make a contribution to the code.}_

Copyright (c) _date_ _author name(s)_