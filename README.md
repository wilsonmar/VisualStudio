Here are my notes on using of VisualStudio from Microsoft for ensuring the performance and capacity of systems.

What else do I need to do to be an MVP on Performance Testing? ;)

## <a name="Versions"> Versions</a>

* 2015 was released in late 2014
* 2013
* 2012
* 2010
* 2008
* 2003

For each version there are different <a href="#Editions">editions</a>.


## <a name="DownloadOptions"> Download Options</a>
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8066305/2e73216c-0ea4-11e5-9460-3c50115d79af.png" width="350" />
As an example, the download page for Microsoft Visual Studio Community 2013 with Update 4 
https://www.visualstudio.com/en-us/downloads/
provides two options for downloading installers:
  * **Install Now** downloads 1.2 MB file vs_community.exe and installs after dowload.
  * **Download Now** downloads 1.1 MB file vs_ultimate_download.exe which manages the download to conclusion.
  This is the approach I recommend.
  * **DVD9 ISO Image** download the whole 6.9 GB file vs2013.4_ce_enu.iso which requires another utility to read,
  and leaves it to the browser or other program to manage broken downloads.

Do not download a Language Pack unless you need another language than English.


## <a name="Distinctives"> Distinctives of Microsoft's Approach</a>

Visual Studio provides a single IDE for developing in "all" languages platforms,
including node.js, PHP, and mobile (with Microsoft Xamarin)
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx

Microsoft has no shortage of competitors.

For its IDE features Visual Studio has competitors in JetBrain's Webstorm, open-source Eclipse (backed by IBM).

For its testing features Visual Studio has competitors in HP's UFT (Unified Functional Test, previously called QTP)
and HP LoadRunner for performance testing. 

The differentiator for Visual Studio is that it provides a single full-fledged user interface for developers and testers alike.

HP LoadRunner's VuGen IDE is based on an open-source clone of Visual Studio 2008,
so does not contain many of the convenience features in Visual Studio of current vintage.
However, Visual Studio can be made to take the place of VuGen to 
edit C-language scripts and invoke LoadRunner's mdrv.exe load generator.


Microsoft has source code for .NET server on
https://github.com/Microsoft/dotnet
(with discussions on http://blogs.msdn.com/b/dotnet/)
rather than Microsoft's CodePlex.com for crowd-sourced contributions.


## <a name="Editions"> What Edition of Visual Studio?</a>

For each version of Visual Studio over time:

### Visual Studio Express vs Community 2013 Free Edition
There are free editions of the Visual Studio IDE
(see https://www.visualstudio.com/en-us/products/free-developer-offers-vs.aspx),
but Microsoft still sells MSDN licenses based on different editions of Visual Studio
because functionality is limited on free editions.

Express editions cannot install Visual Studio <a href="#PlugIns">plug-ins</a>. 
However Community editions can.
Also, Community editions is cross-plantform: it can be used to build across platforms - 
web HTML apps, Windows apps, and Windows Desktop apps.

Source code Microsoft uses to create Visual Studio is NOT open-source on Github.

One of those features is running <a href="#Perftest.md">performance/load tests</a>, 
which require the **Ultimate edition** of Visual Studio
(not Express editions).


### Visual Studio Code on Macs and Linux
Microsoft created a "Visual Studio works on Macs and Linux"
(see https://www.visualstudio.com/products/code-vs or http://code.visualstudio.com),
the free software is branded "Visual Studio Code". 
The VSCode installer for OS X (file VSCode-darwin.zip) is 64.7 MB (expands to 196.7 MB),
described as "Preview" maturity as of June 2015.
Follow its @code Twitter handle.
The program provides IntelliCode and [TaskRunner](https://code.visualstudio.com/Docs/tasks)
that runs TypeScript (.ts files) and JS Hint at http://jshint.com/.

VSCode offers debugging for Node.js, but not yet for ASP.NET 5.


### Visual Studio Github
https://visualstudio.github.com/index.html
offers a Github Extension for Visual Studio 2015, in RC (Release Candidate) maturity as of June 2015.
This enables Visual Studio to use Github as a source code repository instead of Microsoft's own 
TFS (Team Foundation Server).

But where's the local git repo support?
For VS 2012, see 
http://www.codeproject.com/Articles/581907/IntegratingplusandplusUsingplusGithubplusinplusVis

## Visual Studio Online
While it's true that Visual Studio is available **online**
(see https://www.visualstudio.com/en-us/products/what-is-visual-studio-online-vs),
many developers still prefer to download and install Visual Studio on computers used to develop code,
where response time is near instantaneous.
The online edition makes use of Team Foundation Version Control (TFVC) for one massively scalable repo, 
or multiple Git repositories for maximum flexibility.

## <a name="Unittest"> Unit Testing </a>
See
https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs

## <a name="Mobile"> Mobile</a>

See http://anydevanyapp.com/

Visual Studio Community 2015 + Cordova tools for developing "hybrid" mobile apps
https://www.visualstudio.com/en-us/features/cordova-vs.aspx

While the Visual Studio Community 2015 + Xamarin tools for developing "native" mobile apps
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx
Xamarin is licensed for $1500 per platform per year per develop.

### <a name="Powershell"> Powershell</a>

One of the major benefits of using Microsoft servers is that it has a powerful shell scripting language: 
PowerShell, which Microsoft managed to keep coherant as features were added over time
(while various Linux shells fragmented).
See Scott Hanselman on http://azure.microsoft.com/en-us/documentation/videos/azure-powershell-101-managing-azure-storage-from-the-command-line/ (12 minutes)

https://github.com/psake/psake
is an automated build tool (such as Make, Rake, MSBuild, etc.) written in PowerShell.
http://blogs.msdn.com/b/heaths/archive/2014/06/28/seeing-colors-with-psake.aspx
shows how to set a red color to highlight 

### <a name="PlugIns"> Plug-Ins</a>

Adam Driscoll's PowerShell Tools for Visual Studio (free)
https://visualstudiogallery.msdn.microsoft.com/c9eb3ba8-0c59-4944-9a62-6eee37294597?SRC=Home

NuGet Package Manager 
https://visualstudiogallery.msdn.microsoft.com/27077b70-9dad-4c64-adcf-c7cf6bc9970c?SRC=Home
(like NPM for Node.js) is the top plug-in for Visual Studio.

Others in the **Visual Studio Gallary** of Products and Extensions for Visual Studio
https://visualstudiogallery.msdn.microsoft.com/
include 

* ReSharper from JetBrains
and 
* Save All the Tabs at
https://visualstudiogallery.msdn.microsoft.com/0c5642e8-f6aa-4353-830c-946a315c163d?SRC=Home

## <a name="MachineLearning"> Machine Learning</a>
I would like to take advantage of
http://azure.microsoft.com/en-us/services/machine-learning/api/


## Authentication via OAuth
* OAuth redirect header
* How to create OAuth Tokens and Secretes?
* What options are configurable?

### Add Connected Service SDK
is the modern way to connect to cloud services in VS 2015 with VS 2015 SDK.

Dynamics CRM, SAP, Salesforce, Adobe DataLogics

VSIX Extension

Provider

