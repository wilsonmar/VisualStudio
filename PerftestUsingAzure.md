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

Efforts to tune configurations and predict what <a href="#Costing">production usage will cost</a>
typically require a way to impose an emulated load on the system. 

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png" width="350" /></a>
https://www.visualstudio.com/en-us/explore/vso-cloud-load-testing-vs
provides a calculator to determine how many virtual user minutes (VUMs) 
a scenario will use.

Each Cloud account is provided first 20,000 VUMs free each month. 
That's 333 hours or over 13 continuous days by one virtual user
or 333 vusers running one hour per month.


## <a name="CostingLogic"> Costing Logic</a>
Web page http://azure.microsoft.com/en-us/pricing/calculator/?scenario=full#meter45
contains the **Azure Pricing Calculator** to determine total cost based on your estimated usage
of server, database, notifications, etc. which are not free.

Microsoft also sells **monitoring** with alerts with event trace and exception logs on its servers in Azure. 
See https://www.visualstudio.com/features/application-insights-vs
to read about Microsoft's **Application Insights** offering.

Under App Service, free usage is with IP address and HTTP protocol 
rather than domain names with HTTPS.
Sharing a single site (domain) costs $0.0013/hour or $9.98 per month of 7446 hours.  
(a calculation error in the calculator).

Pricing for a "Standard" App Service (providing network load balancing, autoscale, and backup support):

| Size | VMs | Cores | RAM GB | Std. Storage GB | Prem. Storage | $/hour | $/month |
| ---- | --- | ----  | ---- | ----        | --- | ----   | ---- |
| S1   | 1   | 1     | 1.75 | 50          | 250 | $0.10 | $074.40 |
| S2   | 1   | 2     | 3.5  | 50          | 250 | $0.20 | $148.80 |
| S3   | 1   | 4     | 7.0  | 50          | 250 | $0.40 | $297.60 |

Notice that cost is directly proportional to the number of cores. 

However, using more cores does not necessarily mean a proportional increase in processing rate is achieved.
Typically, doubling the number of cores would yield 70% or less improvement in processing throughput.

COMMENTARY:
I propose that Microsoft consider a "volume discount" of sorts to reflect the diminishing returns from more cores. 

DO THIS:
Conduct experiment performance test runs on how many transactions can be processed within an hour on a 
"Standard" App Service (providing network load balancing, autoscale, and backup support)
in order to select the righ size of server:

Compare that against HP's StormRunner Load which charges a flat 15 cents per vuser hour.

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx
