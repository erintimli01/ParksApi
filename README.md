# _National Parks API_
### _An API for National Park Lookups_
#### By _**Erin Timlin**_

<br>


## **Technologies Used**

* _C#_
* _.Net 6_
* _ASP.NET_
* _SQL_
* _LINQ_
* _Swagger_

<br>

## **Description**

_Demonstrating knowledge of building API's, this API is a lookup for National State Parks and will list the park name and the city and state it's in._

<br>

## **Setup/Installation Requirements**

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

<br>

## **API Documentation**

Please feel free to test this API via [Postman](https://www.postman.com/)! 

<br>

### **Available End Points**

```
 GET http://localhost:5297/api/v1parks
 GET http://localhost:5297/api/v1parks/{id}
 POST http://localhost:5297/api/v1parks
 PUT http://localhost:5297/api/v1parks/{id}
 DELETE http://localhost:5297/api/v1parks/{id}
```

<em><small>Note: The value `{id}` found in the URL is not a fixed or constant value, but rather a variable that needs to be substituted with the specific id number of the park you intend to perform a GET, PUT, or DELETE operation on.</small></em>

<br>


#### **Optional Queries**
_It is possible to include query strings in GET requests to `http://localhost:5297/api/v1parks/` in order to filter or search for specific parks._ 

<br>

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| name     | String      | not required | Returns park name with a matching state value |
| state       | String      | not required | Returns states with a matching park name value |

<br>

### **Example Queries**

The following will return all parks:
```
GET http://localhost:5297/api/v1parks
```

The following will return all parks with a state value of "Arizona", indicated by the state id:
```
GET http://localhost:5297/api/v1parks?state=arizona
```

The following will return all parks with a city value of "Tusayan", indicated by the city id:
```
GET http://localhost:5297/api/v1parks?city=tusayan
```

The following will return all parks with the name "Grand Canyon National Park", indicated by the name id:
```
GET http://localhost:5297/api/v1parks?name=Grand Canyon National Park
```

The following will return all parks in Tusayan, Arizona, returning multiple query strings by separating them with an &:

```
GET http://localhost:5297/api/v1parks?state=arizona&city=Tusayan
```

<br>

#### **Additional Requirements for POST Request**
<em><small>Note: To make a POST request, it is necessary to include a JSON formatted body that contains all required fields.</small></em> 

<br>

Example:

```
POST http://localhost:5297/api/v1parks
```
```
{
    "name": "Joshua Tree National Park",
    "state": "California",
    "city": "Palm Springs"
}
```
<br>

#### **Additional Requirements for PUT Request**
<em><small>Note: To make a PUT request, it is necessary to include a JSON formatted body that contains all required fields including the parks `parkId` field.</small></em> 

<br>

Example: 

```
PUT http://localhost:5297/api/v1parks
```

```
{
    "parkId: "8",
    "name": "Joshua Tree National Park",
    "state": "California",
    "city": "Palm Springs"
}
```

<br>

## **Known Bugs**

* _No Known Bugs_

_Please reach out with any questions or concerns!_

<br>

## **License**
[MIT](License.txt) License


Copyright (c) _March 2023_ _Erin Timlin_