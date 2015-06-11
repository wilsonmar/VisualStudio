This page and associated test script describes use of Visual Studio and the C# language to create a basic 
web service listener.

http://www.asp.net/web-api

http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api

This repo is similar to Charles Sterling's
Getting started with Cloud-based Load Test REST APIs blog at
http://blogs.msdn.com/b/visualstudioalm/archive/2014/12/04/getting-started-with-cloud-based-load-test-rest-apis.aspx 
which references the Visual Studio Online REST API Reference at 
https://www.visualstudio.com/en-us/integrate/api/overview

ASP.NET Web API code samples from Mike Wasson of Microsoft at
https://code.msdn.microsoft.com/site/search?f[0].Type=User&f[0].Value=Mike.Wasson
and http://www.asp.net/web-api/overview/creating-web-apis/creating-a-web-api-that-supports-crud-operations
will be referenced here.

This repo is equivalent to what repository https://github.com/heroku/node-js-sample
provides for the node.js web server written in JavaScript. 
The authors deployed that code to the website http://node-js-sample.herokuapp.com/.

Use an internet browser to open that web page and 
notice that it only displays a simple "Hellow World!".
This is because the example is "bare bones" and intended to work with web services between computers 
who have no need for animated cat gifs for amusement.

### <a name="WebSvcs"> Why Web Services APIs</a>
This tutorial focuses on the Web Servies API only.

Microsoft offers several ways:
  * Web Services API
  * WCF
  * OData - see http://www.odata.org/
 From https://code.msdn.microsoft.com/ASPNET-Web-API-OData-cecdb524
 The Open Data Protocol (OData) is a data access protocol for the web. OData provides a uniform way to query and manipulate data sets through CRUD operations (create, read, update, and delete). Using ASP.NET Web API, it is easy to create an OData endpoint. You can control which OData operations are exposed. You can host multiple OData endpoints, alongside non-OData endpoints. You have full control over your data model, back-end business logic, and data layer.


### <a name="REST"> REST</a>
The Get started with the VSO REST APIs article at
https://www.visualstudio.com/integrate/get-started/rest/basics
makes use of the curl command-line utility to demonstrate the pattern of calls to APIs recognized by VisualStudio.com:

```
curl -u {username}[:{password}] 
https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version=1.0
```

The 

| Verb	| Used for... |
|----|----|
|GET |	Get a resource or list of resources|
|POST	| Create a resource. Get a list of resources using a more advanced query|
|PUT |	Create a resource if it doesn't exist or, if it does, update it|
|PATCH	Update a resource |
|DELETE	| Delete a resource |


### <a name="WebServer"> Web Service Engines</a>
The README.md page for the node-js-sample repo begins by describing 
http://expressjs.com/
as its web services engine. 

Express does for Node.js what Microsoft's IIS (Internet Information Server) does.

Walmart's subsidiary has also written a web services engine.

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


