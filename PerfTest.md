This text mark-down (.md) file describes how to do performance testing using Visual Studio.

Credits: This expands on these:

* what Charles Sterling posted on June 1, 2015 in  http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests


## <a name="Perftest"> Performance Testing </a>


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

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx
