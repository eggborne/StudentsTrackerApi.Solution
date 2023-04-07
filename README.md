
# students tracker api
### Special Project #13 for [Epicodus](https://epicodus.com), 7 April 2023

#### by [John Diggins](https://github.com/john-dig), [Mike Donovan](https://github.com/eggborne), [Chris Johnedis](https://github.com/johnedisc)

_a martial arts gym student tracking api to be integrated with a gym client_

***

a client app which uses this api can be found here: [https://github.com/eggborne/StudentsTrackerClient.Solution](https://github.com/eggborne/StudentsTrackerClient.Solution)

***

### install tools

first, make sure that you have the [dotnet sdk](https://dotnet.microsoft.com/en-us/download) and dotnet entity framework tool installed.

``` bash
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. clone this [repository](https://github.com/John-Dig/StudentsTracker.Solution) to the directory of your choosing.
``` bash
git clone https://github.com/John-Dig/StudentsTracker.Solution
```
2. navigate to the StudentsTracker.Solution directory(folder).
``` bash
cd StudentsTracker.Solution/TrackerApi
```
3. create two new files in that directory `appsettings.json` and `appsettings.Development.json`.
``` bash
touch appsettings.json appsettings.Development.json
```
4. in appsettings, add the information below replacing database name, uid, pwd to suit your own situation.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=NAME_OF_YOUR_CHOOSING;uid=YOUR_USER_NAME;pwd=YOUR_PASSWORD;"
  }
}
```

5. in appsettings.Development.json add the following.

```json
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

6. next set up your local database with the following dotnet entity framework command
``` bash
dotnet ef database update
```
7. you are ready to start the api server. this will start the server in production mode. if you are going to develop it further, run the following without the --launch-profile
``` bash
dotnet watch run --launch-profile "PortlandLocalShopsApi-Production"
```
8. use your favorite program to make api calls (eg, [postman](https://www.postman.com/), [curl](https://curl.se/) on the command line, or with swagger). swagger can be found at [http://localhost:5288/swagger](http://localhost:5250/swagger)

```bash
GET http://localhost:5250/api/students/
GET http://localhost:5250/api/students/{id}
POST http://localhost:5250/api/students/
PUT http://localhost:5250/api/students/{id}
DELETE http://localhost:5250/api/students/{id}
```

```bash
GET http://localhost:5250/api/promotions/
GET http://localhost:5250/api/promotions/{id}
POST http://localhost:5250/api/promotions/
PUT http://localhost:5250/api/promotions/{id}
DELETE http://localhost:5250/api/promotions/{id}
```

```bash
GET http://localhost:5250/api/coaches/
GET http://localhost:5250/api/coaches/{id}
POST http://localhost:5250/api/coaches/
PUT http://localhost:5250/api/coaches/{id}
DELETE http://localhost:5250/api/coaches/{id}
```

note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.

#### for a POST request, you have to supply an entire unique object

a body is required for the post to be successful. remember to leave the idea at 0 for the database to auto-increment

here is an example from the coaches endpoint:
```json
{
    "coachId": 0,
    "firstN": "Jimmy",
    "lastN": "Carter",
    "email": "JimmyCoacher@email.com",
    "phone": "555-555-5555",
    "beltId": 124,
    "promotions": null
  }
```

#### PUT request

when making a put request, you must provide the whole object, not just the value that is changing. thus:

```json
{
    "studentId": 7,
    "firstN": "Funny",
    "lastN": "Guy",
    "email": "guy@buddy.com",
    "beltId": 114,
    "dateEnrolled": "2023-04-05T16:12:55.04",
    "promotions": null
  }
```
becomes
```json
{
    "studentId": 7,
    "firstN": "Buddy",
    "lastN": "Guy",
    "email": "guy@buddy.com",
    "beltId": 114,
    "dateEnrolled": "2023-04-05T16:12:55.04",
    "promotions": null
  }
```

## MIT license

copyright (c) [2023] team-dont-forget-to-log-out. AKA: [John Diggins and his mutable array](https://github.com/John-Dig)

permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the software, and to permit persons to whom the software is
furnished to do so, subject to the following conditions:

the above copyright notice and this permission notice shall be included in all
copies or substantial portions of the software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
