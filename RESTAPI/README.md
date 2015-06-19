This page and associated test script describes use of Visual Studio and the C# language to create a basic 
web service listener.


### <a name="LikeNode"> Like NodeJS Express Example</a>
This repo is equivalent to what repository https://github.com/heroku/node-js-sample
provides for the node.js web server written in JavaScript. 
The authors deployed that code to the website http://node-js-sample.herokuapp.com/.

Use an internet browser to open that web page and 
notice that it only displays a simple "Hello World!".
This "bare bones" example is an API example intended to work with web services between computers that need no human UI
or animated cat gifs for amusement.

The README.md page for the node-js-sample repo begins by describing 
http://expressjs.com/
as its web services engine.
Walmart's subsidiary has also written a web services engine.


### <a name="WebSvcs"> Why Web Services APIs</a>
Microsoft provides several architectures for services which listen for and respond to web service requests.

 * ASP.NET WEB API - http://www.asp.net/web-api
 * ASP.NET MVC - http://www.asp.net/mvc/overview
 * WCF (Web Communications Framework)

Web API and MVC controller are mixed in a single project to handle advanced AJAX requests which may return data in JSON, XML or any others format and building a full blown HTTP service. Typically, this is called **Web API self hosting**.

| Aspect	| MVC | Web API |
|----|----|----|
| Returns |	Views and Data | Data only |
| Result Formats |	JSON only | JSON, XML, ATOM, etc. |
| Basis for route mapping |	<a href="#RESTActions">REST in URL Actions</a> | <a href="#HTTPVerbs">HTTP Verbs</a> |


### <a name="RESTActions"> REST in URL Actions</a>
The GET started with the VSO REST APIs article at
https://www.visualstudio.com/integrate/get-started/rest/basics
makes use of the curl command-line utility to demonstrate the pattern of calls to APIs recognized by VisualStudio.com:

```
curl -u {username}[:{password}] 
https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version=1.0
```

### <a name="HTTPVerbs"> HTTP Verbs</a>

| Verb	| Used for... |
|----|----|
|GET |	Get a resource or list of resources|
|POST	| Create a resource. Get a list of resources using a more advanced query|
|PUT |	Create a resource if it doesn't exist or, if it does, update it|
|DELETE	| Delete a resource |
|PATCH	| Update a resource (used for Web Sockets) |

Alternately, 
https://code.msdn.microsoft.com/ASPNET-Web-API-OData-cecdb524
describes how using ASP.NET Web API can be an OData endpoint. 
the Open Data Protocol (OData) 
described at http://www.odata.org/
is a public data access protocol that provides a uniform way to query and manipulate data sets through CRUD operations (create, read, update, and delete). 
By controling which OData operations are exposed, you can host multiple OData endpoints, alongside non-OData endpoints. 
You have full control over your data model, back-end business logic, and data layer.

### <a name="Sample"> Repo Samples</a>
This repo is similar to Charles Sterling's
Getting started with Cloud-based Load Test REST APIs blog at
http://blogs.msdn.com/b/visualstudioalm/archive/2014/12/04/getting-started-with-cloud-based-load-test-rest-apis.aspx 
which references the Visual Studio Online REST API Reference at 
https://www.visualstudio.com/en-us/integrate/api/overview

ASP.NET Web API code samples from Mike Wasson of Microsoft at
https://code.msdn.microsoft.com/site/search?f[0].Type=User&f[0].Value=Mike.Wasson
and http://www.asp.net/web-api/overview/creating-web-apis/creating-a-web-api-that-supports-crud-operations
will be referenced here.


http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api


### <a name="WebServer"> Web Service Engine Resources</a>
[Node's app.json file](https://github.com/heroku/node-js-sample/blob/master/app.json)
specifies resources, like a manifest file:

```
{
  "name": "Node.js Sample",
  "description": "A barebones Node.js app using Express 4",
  "repository": "https://github.com/heroku/node-js-sample",
  "logo": "http://node-js-sample.herokuapp.com/node.svg",
  "keywords": ["node", "express", "static"]
}
```

The equivalent in ASP.NET is the .config file:

```
???
```

[Node's **index.js** file](https://github.com/heroku/node-js-sample/blob/master/index.js) 
holds the configuration logic:

```
var express = require('express')
var app = express();

app.set('port', (process.env.PORT || 5000))
app.use(express.static(__dirname + '/public'))

app.get('/', function(request, response) {
  response.send('Hello World!')
})

app.listen(app.get('port'), function() {
  console.log("Node app is running at localhost:" + app.get('port'))
})
```

The equivalent of this in ASP.NET is the .cs (C#) code-behind files:

```
???
```


### <a name="Deploy2Hosting"> Depoloy to Hosting</a>

the deployment commands
https://toolbelt.heroku.com/


### <a name="Folders"> Folders</a>
So let's dive into the node-js-sample repo's folders.


