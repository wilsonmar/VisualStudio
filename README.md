Here are my notes on using of VisualStudio from Microsoft for ensuring the performance and capacity of systems.

What else do I need to do to be an MVP on Performance Testing? ;)

## <a name="Versions"> Versions</a>

* 2015 was released in late 2014
* 2013
* 2010
* 2008
* 2003

There are different editions for each version.


## <a name="DownloadOptions"> Download Options</a>
As an example, the download page for Microsoft Visual Studio Community 2013 with Update 4 
https://www.visualstudio.com/en-us/downloads/
provides two options for downloading installers:
  * **Install Now** downloads 1.2 MB file vs_community.exe.
  * **DVD9 ISO Image** download 6.9 GB file vs2013.4_ce_enu.iso which requires another utility to read.

## <a name="Distinctives"> Distinctives of Microsoft's Approach</a>

Visual Studio provides a single IDE for developing in "all" languages platforms,
including node.js, PHP, and mobile (with Microsoft Xamarin)
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx

Microsoft has no shortage of competitors.

For its IDE features Visual Studio has competitors in JetBrain's Webstorm, open-source Eclipse (backed by IBM).

For its testing features Visual Studio has competitors in HP's UFT (Unified Functional Test, previously called QTP)
and HP LoadRunner for performance testing. 

The differentiator for Visual Studio is that it provides a single full-fledged user interface for developers and testers alike.

HP LoadRunner's VuGen is based on an open-source clone of Visual Studio 2008,
so does not contain many of the convenience features in Visual Studio of current vintage.


## <a name="WhatEdition"> What Edition of Visual Studio?</a>

### Visual Studio Express vs Community 2013 Free Edition
While it's true that there is a free ("Express") edition of the Visual Studio IDE
(see https://www.visualstudio.com/en-us/products/free-developer-offers-vs.aspx),
Microsoft still sells MSDN licenses based on different editions of Visual Studio.

Source code Microsoft uses to create Visual Studio is NOT open-source on Github.

One of those features is running load tests, which require the **Ultimate edition** of Visual Studio
(not Express editions).

Download of Visual Studio Community 2013 from
https://visualstudiogallery.msdn.microsoft.com/
file 


Microsoft has source code for .NET server on
https://github.com/Microsoft/dotnet
(with discussions on http://blogs.msdn.com/b/dotnet/)

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

While it's true http://anydevanyapp.com/


## <a name="Perftest"> Performance Testing </a>
Charles Sterling posted these blog entry in two parts on June 1, 2015:

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests



## <a name="UsingAzure"> Perftest the Azure Cloud</a>
https://www.udemy.com/introduction-to-cloud-computing-and-microsoft-azure/#/
provides an introduction to Azure cloud computing (why DevTest, etc.).

https://www.visualstudio.com/en-us/explore/vso-cloud-load-testing-vs
provides a calculator to determine how many virtual user minutes (VUMs) you will use.

While it's true the first 20,000 VUMs are free each month. That's 333 hours or over 13 continuous days by one virtual user
or 333 vusers running one hour per month.
See http://azure.microsoft.com/en-us/pricing/calculator/?scenario=full#meter45.
provides a full calculator to determine total cost based on your estimates
of server, database, notifications, etc. which are not free.

Microsoft also sells **monitoring** with alerts with event trace and exception logs on its servers in Azure. 
See https://www.visualstudio.com/features/application-insights-vs
to read about Microsoft's **Application Insights** offering.

Compare that against HP's StormRunner Load which charges a flat 15 cents per vuser hour.

https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx

## <a name="Mobile"> Mobile</a>

Visual Studio Community 2015 + Cordova tools for developing "hybrid" mobile apps
https://www.visualstudio.com/en-us/features/cordova-vs.aspx

While the Visual Studio Community 2015 + Xamarin tools for developing "native" mobile apps
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx
Xamarin is licensed for $1500 per platform per year per develop.

## <a name="Powershell"> Powershell</a>

One of the major benefits of using Microsoft servers is that it has a powerful shell scripting language: 
PowerShell, which Microsoft managed to keep coherant as features were added over time
(while various Linux shells fragmented).
See Scott Hanselman on http://azure.microsoft.com/en-us/documentation/videos/azure-powershell-101-managing-azure-storage-from-the-command-line/ (12 minutes)

https://github.com/psake/psake
is an automated build tool (such as Make, Rake, MSBuild, etc.) written in PowerShell.
http://blogs.msdn.com/b/heaths/archive/2014/06/28/seeing-colors-with-psake.aspx
shows how to set a red color to highlight 


Adam Driscoll's PowerShell Tools for Visual Studio (free)
https://visualstudiogallery.msdn.microsoft.com/c9eb3ba8-0c59-4944-9a62-6eee37294597?SRC=Home

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

