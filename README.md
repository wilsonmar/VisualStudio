Here are my notes on using of VisualStudio from Microsoft for ensuring the performance and capacity of systems.

What else do I need to do to be an MVP on Performance Testing? ;)

## <a name="Versions"> Versions</a>

* 2015 was released in late 2014
* 2013
* 2010
* 2008
* 2003

There are different editions for each version.


## <a name="Distinctives"> Distinctives of Microsoft's Approach</a>

Microsoft has no shortage of competitors.

For its IDE features Visual Studio has competitors in JetBrain's Webstorm, open-source Eclipse (backed by IBM).

For its testing features Visual Studio has competitors in HP's UFT (Unified Functional Test, previously called QTP)
and HP LoadRunner for performance testing. 

The differentiator for Visual Studio is that it provides a single full-fledged user interface for developers and testers alike.

HP LoadRunner's VuGen is based on an open-source knock-off of Visual Studio 2008,
so does not contain many of the convenience features in Visual Studio of current vintage.

## <a name="WhatEdition"> What Edition of Visual Studio?</a>

While it's true that there is a free ("Express") edition of the Visual Studio IDE
(see https://www.visualstudio.com/en-us/products/free-developer-offers-vs.aspx),
Microsoft still sells MSDN licenses based on different editions of Visual Studio.

While it's true that source code Microsoft uses to create Visual Studio is open-source on Github
(see https://visualstudio.github.com/),
additional features not in open source are still being sold as part of MSDN Visual Studio licenses.

One of those features is running load tests, which require the **Ultimate edition** of Visual Studio
(not Express editions).

While it's true that there "Visual Studio works on Macs and Linux"
(see https://www.visualstudio.com/products/code-vs or http://code.visualstudio.com),
the free software is branded "Visual Studio Code". 
The VSCode installer for OS X (file VSCode-darwin.zip) is 64.7 MB (expands to 196.7 MB),
described as "Preview" maturity as of June 2015.
Follow its @code Twitter handle.
The program provides IntelliCode and [TaskRunner](https://code.visualstudio.com/Docs/tasks)
that runs TypeScript (.ts files) and JS Hint at http://jshint.com/.

https://visualstudio.github.com/index.html
offers a Github Extension for Visual Studio 2015, in RC (Release Candidate) maturity as of June 2015.
This enables Visual Studio to use Github as a source code repository instead of Microsoft's own 
TFS (Team Foundation Server).

While it's true that Visual Studio is available **online**
(see https://www.visualstudio.com/en-us/products/what-is-visual-studio-online-vs),
many developers still prefer to download and install Visual Studio on computers used to develop code,
where response time is near instantaneous.
The online edition makes use of Team Foundation Version Control (TFVC) for one massively scalable repo, 
or multiple Git repositories for maximum flexibility.

https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs

https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests

While it's true http://anydevanyapp.com/


## <a name="Perftest"> Performance Testing </a>
Charles Sterling posted these blog entry in two parts on June 1, 2015:

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx



## <a name="UsingAzure"> Perftest the Azure Cloud</a>

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

## <a name="MachineLearning"> Machine Learning</a>

http://azure.microsoft.com/en-us/services/machine-learning/api/

## <a name="Powershell"> Powershell</a>

One of the major benefits of using Microsoft servers is that it has a powerful shell scripting language: 
PowerShell, which Microsoft managed to keep coherant as features were added over time
(while various Linux shells fragmented).
See Scott Hanselman on http://azure.microsoft.com/en-us/documentation/videos/azure-powershell-101-managing-azure-storage-from-the-command-line/ (12 minutes)

