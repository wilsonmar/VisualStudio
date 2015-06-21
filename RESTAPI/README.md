This page and associated test script describes use of Visual Studio and the C# language to create a basic 
web service listener.

We want to compare REST API Async calls 
  * Restify (at http://mcavage.me/node-restify/) is a node.js + Socket.io module
    built specifically to build "correct" REST API web services.

    It was influenced by Express written by TJ Holowaychuk (visionmedia) was in 2014 transferred to for-profit StrangeLoop,
    which created the LoopBack Node framework built on Express.

### <a name="AgileApproach"> Agile Approach</a>
When Howard Dierking @howard_dierking provides his https://github.com/howarddierking/RestBugs
sample, he noted:
"I’m going to write my client to consume a series of static [JSON] files and will see how easy it is to drive my entire workflow through those resources. I’ll then use that experience (and the resulting representation design) to drive the design of my server, which will then drive the runtime execution of my client."



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

## <a name="ASPNET"> ASP.NET vs Node.JS</a>
Similar comparisons
  * http://www.readwriteweb.com/hack/2011/07/nodejs-creator-ryan-dahls-keyn.php
    Ryan Dahl, the create of Node.js, presents his seminal ideas in this 2011 talk.

  * http://www.letsnode.com/moving-from-net-to-node
    
  * https://www.airpair.com/node.js/posts/nodejs-framework-comparison-express-koa-hapi
    Johnathan Glock compared Node.js code calling Express vs. Koa vs. Hapi (from WalmartLabs).

  * http://css.dzone.com/articles/nodejs-vs-aspnet-web-api
    Mikael KosKinen used default server settings and minimal code
    to conclude that Node was faster than ASP.NET Web API.

  * http://blog.mixu.net/2011/02/01/understanding-the-node-js-event-loop/
  * http://blip.tv/file/2899135
  * http://nodeguide.com/
  * http://stackoverflow.com/questions/5599024/what-so-different-about-node-jss-event-driven-cant-we-do-that-in-asp-nets-ht


### <a name="WebSvcs"> Why Web Services APIs</a>
Microsoft provides several architectures for services which listen for and respond to web service requests.

 * ASP.NET MVC - http://www.asp.net/mvc/overview
 * ASP.NET WEB API which began in 2012 with ASP.NET MVC 4.0 - http://www.asp.net/web-api 
  and tutorial about this Template and 
  Controller Class at http://www.codemag.com/article/1206081
 * WCF (Web Communications Framework) REST

Web API and MVC controller are mixed in a single project to handle advanced AJAX requests which may return data in JSON, XML or any others format and building a full blown HTTP service. Typically, this is called **Web API self hosting**.

| Aspect	| MVC | Web API |
|----|----|----|
| Call format | <a href="#RPC">RPC</a> | <a href="#REST">REST</a> |
| Returns |	Views and Data | Data only |
| Result Formats |	JSON only | XML, JSON, ATOM, etc. |
| Basis for route mapping |	<a href="#RESTActions">REST in URL Actions</a> | <a href="#HTTPVerbs">HTTP Verbs</a> |

XML is the default format for Web API.

### <a name="RPC"> RPC (Remote Procedure Call)</a>
RPC Style Actions are like

```
api/{controller}/{action}/{id}
```

To make Web API support RPC-style endpoints:
* http://encosia.com/rest-vs-rpc-in-asp-net-web-api-who-cares-it-does-both/
* http://www.code-magazine.com/Article.aspx?quickid=1206081

### <a name="REST"> REST</a>
REST (Representational Transform) was first proposed by Roy Fielding in his doctoral dissertation
at UC Irvine: http://www.ics.uci.edu/~fielding/pubs/dissertation/fielding_dissertation.pdf

REST is not a protocol like HTTP, but an "architectural style".

Is this fictional URL "RESTful", meaning "everything is a resource"?

```
http://api.example.com/posts/delete/233/
```

http://blog.luisrei.com/articles/rest.html
says no because delete is an action, not a resource.

### <a name="HTTPVerbs"> HTTP Verbs (Request methods)</a>

| Verb	| Used for... |
|----|----|
|GET |	retrieves a representation of a resource without side-effects (nothing changes on the server).
 -- a resource or list of resources. |
| HEAD	| retrieves just the resource meta-information (headers) i.e. same as GET but without the response body - also without side-effects. |
| OPTIONS |	returns the actions supported for specified the resource - also without side-effects. |
|POST	| Create a resource. Get a list of resources using a more advanced query.|
|PUT |	(completely) replaces an existing resource. Create a resource if it doesn't exist or, if it does, update it.|
|DELETE	| Delete a resource. |
|PATCH	|  	partial modification of (update) a resource. |

For POST, PUT, the expected HTTP response code is 201 Created.

Alternately, 
https://code.msdn.microsoft.com/ASPNET-Web-API-OData-cecdb524
describes how using ASP.NET Web API can be an OData endpoint. 
the Open Data Protocol (OData) 
described at http://www.odata.org/
is a public data access protocol that provides a uniform way to query and manipulate data sets through CRUD operations (create, read, update, and delete). 
By controling which OData operations are exposed, you can host multiple OData endpoints, alongside non-OData endpoints. 
You have full control over your data model, back-end business logic, and data layer.

### <a name="RESTActions"> REST in URL Actions</a>
The GET started with the VSO REST APIs article at
https://www.visualstudio.com/integrate/get-started/rest/basics
makes use of the curl command-line utility to demonstrate the pattern of calls to APIs recognized by VisualStudio.com:

```
curl -u {username}[:{password}] 
https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version=1.0
```


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


## <a name="MVC"> Serialization by ASP.NET MVC</a>
David Ward in http://encosia.com/asp-net-web-api-vs-asp-net-mvc-apis/
points out that because MVC performs serialization of JSON,
it is more "wordy" than ASP.NET Web API coding:

```
public class TweetsController : Controller {
  // GET: /Tweets/
  [HttpGet]
  public ActionResult Index() {
    return Json(Twitter.GetTweets(), JsonRequestBehavior.AllowGet);
  }
}
```

The Web API:

```
public class TweetsController : ApiController {
  // GET: /Api/Tweets/
  public List<Tweet> Get() {
    return Twitter.GetTweets();
  }
}
```


### <a name="StatelessCaching"> Stateless Caching</a>
Caching of requests and its content on the local device/browser and the server is a major strategy
for the "10KChallenge" (being able to support 10,000 users simultaneously).

REST API is stateless and cacheable.


### <a name="Deploy2Hosting"> Depoloy to Hosting</a>

the deployment commands
https://toolbelt.heroku.com/


### <a name="Folders"> Folders</a>
So let's dive into the node-js-sample repo's folders.


