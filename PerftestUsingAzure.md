This mark-down text file describes the use of Microsoft's Azure cloud to conduct performance testing.

This assumes that the reader is familiar with 
Azure cloud computing (why DevTest, etc.) as taught in
[this free Udemy course](https://www.udemy.com/introduction-to-cloud-computing-and-microsoft-azure/#/).

There are two basic components of response time: 
a) time in the server and 
b) time requests and c) responses spend over the network.

Public networks can introduce a significant amount of time to response time.
And that time can vary significantly due to travel distance (propagation delay) 
and competition with others (congestion).

When load generators are placed within actual user machines at the other end of the public internet,
network times can be so significant and vary so significantly that they "drown out" 
the server time component.

So the ideal situation is to have a load generator near the front-end web server
within the data center to adequately measure time spent on the server.

Efforts to tune configurations and predict what production usage will cost 
typically require a way to impose an emulated load on the system. 

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png" width="350" /></a>
https://www.visualstudio.com/en-us/explore/vso-cloud-load-testing-vs
provides a calculator to determine how many virtual user minutes (VUMs) you will use.

Each Cloud account is provided first 20,000 VUMs free each month. 
That's 333 hours or over 13 continuous days by one virtual user
or 333 vusers running one hour per month.

See http://azure.microsoft.com/en-us/pricing/calculator/?scenario=full#meter45.
provides a full calculator to determine total cost based on your estimates
of server, database, notifications, etc. which are not free.

Microsoft also sells **monitoring** with alerts with event trace and exception logs on its servers in Azure. 
See https://www.visualstudio.com/features/application-insights-vs
to read about Microsoft's **Application Insights** offering.

Compare that against HP's StormRunner Load which charges a flat 15 cents per vuser hour.

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx
