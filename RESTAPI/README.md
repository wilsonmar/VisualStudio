This page and associated test script describes use of Visual Studio and the C# language to create a basic 
web service listener.

This repo is similar to Charles Sterling's
Getting started with Cloud-based Load Test REST APIs blog at
http://blogs.msdn.com/b/visualstudioalm/archive/2014/12/04/getting-started-with-cloud-based-load-test-rest-apis.aspx 
which references the Visual Studio Online REST API Reference at 
https://www.visualstudio.com/en-us/integrate/api/overview

This repo is equivalent to what repository https://github.com/heroku/node-js-sample
provides for the node.js web server written in JavaScript. 
The authors deployed that code to the website http://node-js-sample.herokuapp.com/.

Use an internet browser to open that web page and 
notice that it only displays a simple "Hellow World!".
This is because the example is "bare bones" and intended to work with web services between computers 
who have no need for animated cat gifs for amusement.


### <a name="REST"> REST</a>
The Get started with the VSO REST APIs article at
https://www.visualstudio.com/integrate/get-started/rest/basics
makes use of the curl utility to demonstrate the pattern of URLs:

```
curl -u {username}[:{password}] 
https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version=1.0
```

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


## <a name="Documentation"> Documentation</a>

For more information ....
