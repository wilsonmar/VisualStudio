This mark-down text file describes an analysis of costing of Microsoft's Azure cloud to conduct performance testing.

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


## <a name="CostingLogic"> Costing Logic</a>
Web page http://azure.microsoft.com/en-us/pricing/calculator/?scenario=full#meter45
contains the **Azure Pricing Calculator** to determine total cost based on your estimated usage
of server, database, notifications, etc. which are not free.

The attached Excel 2013 file contains a worksheet for each category of costing
described below:


* <a href="#AppSvcScaleUpCostingLogic"> App Service</a>

## <a name="VSOnlineVUMs"> VS Online VUMs</a>

Each Cloud account is provided first 20,000 VUMs free each month. 
That's 333 hours or over 13 continuous days by one virtual user
or 333 vusers running one hour per month.

After that, each 100 VUM is $0.40 (40 cents).
That's $0.24 (24 cents) per Vuser Hour.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png" width="350" /></a>
https://www.visualstudio.com/en-us/explore/vso-cloud-load-testing-vs
provides a calculator to determine how many virtual user minutes (VUMs) 
a scenario will use.

## <a name="AppSvcScaleUpCostingLogic"> App Service Scale-Up Costing Logic</a>

Under App Service, free usage is with IP address and HTTP protocol 
rather than domain names with HTTPS.
Sharing a single site (domain) costs $0.0013/hour or $9.98 per month of 7446 hours.  

QUESTION:
Is this an error in the calculator?

24 hours in a day * 31 days = 744.
Since the number of days during each month varies,
the actual total would vary as well.
The calculation is for a month that has 31 days.

However, servers are not typically used continuously the whole month.

Most performance testing runs are conducted in bursts of an hour or a few hours.


Pricing for a "Standard" App Service (providing network load balancing, autoscale, and backup support):

| Size | VMs | Cores | RAM GB | Std. Storage GB | $/hour | $/month |
| ---- | --- | ----  | ---- | ----              | ----   | ---- |
| S1   | 1   | 1     | 1.75 | 50                | $0.10 | $074.40 |
| S2   | 1   | 2     | 3.5  | 50                | $0.20 | $148.80 |
| S3   | 1   | 4     | 7.0  | 50                | $0.40 | $297.60 |

Notice that cost is directly proportional to the number of cores. 

However, using more cores does not necessarily mean a proportional increase in processing rate is achieved.
Typically, doubling the number of cores would yield 70% or less improvement in processing throughput.
This means more smaller servers may be cost less overall than larger servers.

COMMENTARY:
Microsoft may consider a "volume discount" of sorts to reflect the diminishing returns from more cores. 
However, this would complicate calculations somewhat.

DO THIS:
Conduct experiment performance test runs on how many transactions can be processed within an hour on a 
"Standard" App Service (providing network load balancing, autoscale, and backup support)
in order to select the righ size of server that can servicie a set of transactions at the lowest overall price.

## <a name="AppSvcScaleAcrossCostingLogic"> App Service Scale-Across Costing Logic</a>
Similarly, the cost per VM stays the same as the number VMs deployed increases.
Azure does not offer a "volume discount" for the number of VMs used.

The question is whether what number of server instances are necessary at each particular point in time.

Auto-provisioning by server automation scripts make it possible to automatically adjust the number of 
servers in use at any point in time.

Additionally, while in Preview mode (June 2015), Premium prices are lower than Standard.


## <a name="WebWorkerCosting"> Web Worker Costing</a>

A8 and A9 includes 40 Gbit/Sec Infiniband at almost double the cost significant price increase.

QUESTION: 
A7 and A10 have the same specs (8 cores, 56 GB), but have different prices.
I assume that A10 has 112 GB instead of 56.

The largest of each Standard series (D14, A11, G5) have a lower cost than double the next lower one
even though the RAM doubled. From 15% to 21% less.

Linux are 59% less than Windows (A4 $0.352 vs. $0.592).

## <a name="SQLCosting"> SQL Costing</a>

Within the worksheet "SQL",
the multiplier increase from the base Windows server price is calculated in the 
"BaseX" column. For example, 1.43 means 43% more (almost half-again more) than the base Windows server price.
2.78 means 178% (almost double) the base Windows server price.

QUESTION:
Why is Standard SQL Server Basic A3 less than Windows base ($0.696)?


## <a name="MFA"> Multi-Factor Authentication</a>
MFA is charged both by user and by authentication exchange:
* $1.40 per use to maintain keys for that user.
* $0.14 per authentication exchange.

Compare versus https://www.authy.com/pricing/
* $0.15 per user (Azure costs 11 times more)
* $0.05 per successful authentication (Azure costs 3 times more)


## <a name="Monitoring"> Monitoring</a>

Microsoft also sells **monitoring** with alerts with event trace and exception logs on its servers in Azure. 
See https://www.visualstudio.com/features/application-insights-vs
to read about Microsoft's **Application Insights** offering.


## <a name="#StormRunner"> Comparison Across Competitors</a>
Compare that against HP's StormRunner Load which charges a flat 15 cents per vuser hour.

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx
