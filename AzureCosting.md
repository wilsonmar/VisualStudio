This mark-down text file describes how to find the **least-cost** configuration of an app
running in the Microsoft's Azure cloud, 
with load simulated from Visual Studio Code and other performance testing utiliities (such as LoadRunner).


## <a name="ActualCosts"> Actual Costs</a>

Here we gather facts based on **actual usage** rather than estimates and conjecture,
by conducting performance test runs 
which imposes sample (but artificial) loads on servers within Azure.

This technical tutorial assumes that the reader is familiar with 
Azure cloud computing (why DevTest, etc.) as taught in
[this free Udemy course](https://www.udemy.com/introduction-to-cloud-computing-and-microsoft-azure/#/).


## <a name="AzurePricingCalculator"> Azure Pricing Calculator</a>
Web page http://azure.microsoft.com/en-us/pricing/calculator/?scenario=full#meter45
contains the **Azure Pricing Calculator** to determine total cost based on your estimated usage
of server, database, notifications, etc. which are not free.

While in Preview mode (June 2015), Premium prices are lower than Standard.

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


## <a name="Cost Comparison"> Cost Comparison Spreadsheet</a>
Analysis of prices are in my Excel (97-2000 format) file 
https://onedrive.live.com/view.aspx?cid=4cf625875c66377a&page=view&resid=4CF625875C66377A!25949&parId=4CF625875C66377A!135&app=Excel.  
(Microsoft requires you to sign in using one of their accounts)

At the bottom of the spreadsheet are tabs that contain calculations for some category of Azure pricing:

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8377107/91da2aaa-1bcb-11e5-8cb3-a1897f057995.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8377107/91da2aaa-1bcb-11e5-8cb3-a1897f057995.png" /></a>

Other types of charges are not in this spreadsheet yet.

### <a name="Basics"> Basics Spreadsheet</a>
The **Basics** tab provides the number of Hours per Day, Month, and Year used in other sheets.

If you bring your servers down and up each day, change 24 to whatever usage you have per day.

<a href="#AzurePricingCalculator"> Microsoft's Azure Pricing Calculator</a>
uses **31** as the number of days per month.

Change the spreadsheet to that if you want to compare pricing with the website.
But to account for leap years, some may consider it more accurate to use 365.25/12
and 365.25/12 so the fractional number of days each month adds up to the yearly number.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8377647/24c136ac-1bd0-11e5-9464-2d4a3c6efa5a.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8377647/24c136ac-1bd0-11e5-9464-2d4a3c6efa5a.png" 
width="300" /></a>

The number of days is used to calculate the **$/Day** calculation 
in my spreadsheet, a column not in
<a href="#AzurePricingCalculator"> Microsoft's Azure Pricing Calculator</a>.


### <a name="PricingTabs"> Pricing Tabs</a>
Within the **Worker, Windows, Linux, SQL** tabs,
columns ID, Cores, RAM, SSD, Gbit/s, $/Hour, and $/Month are copied from the 
<a href="#AzurePricingCalculator"> Microsoft's Azure Pricing Calculator</a>.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8377401/3ecb3518-1bce-11e5-8555-df8a9117c0e6.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8377401/3ecb3518-1bce-11e5-8555-df8a9117c0e6.png" 
/></a>

### <a name="IncrementRatio"> Incr. (Increment) Ratio</a>
To begin with a simpler example,
pricing for a "Basic" Windows App Service (providing network load balancing, autoscale, and backup support)
but no disk, in the Calcs Spreadsheet:

| ID |  Cores | RAM GB | SSD GB | $/hour | Incr. Ratio | #Machines | $Total |
| ---- | ---- | ----: | ----    | ----:  | ---- | ---- | ----: |
| A1   | 1    | 1.75  | 0      | $0.074 | -    | 8 | $0.59 |
| A2   | 2    |  3.5  | 0      | $0.148 | 2.0  | 4 | $0.59 |
| A3   | 4    |  7.0  | 0      | $0.296 | 2.0  | 2 | $0.59 |
| A4   | 8    | 14.0  | 0      | $0.592 | 2.0  | 1 | $0.59 |

Notice The number of **Cores** and **RAM** double as the size increases 
(from 2 to 4 to 8, etc.).

For these specific servers, cost is directly proportional to the number of cores. 
So 8 smaller machines with 1 core is the same cost as 1 big machine with 8 cores.

The **Incr. Ratio** (Increment Ratio) of the larger divided by the smaller 
is calculated to show that pricing also doubles as servers get larger.

In reality using more cores does not necessarily mean a proportional increase in processing rate is achieved.
In our experiments, doubling the number of cores would yield at most 70% in transaction processing throughput.
This means more smaller servers may be cost less overall than larger servers.

Load balancers that distribute load across servers do not distribute load evenly.

  COMMENTARY:
  Microsoft may consider a "volume discount" of sorts to reflect the diminishing returns from more cores. 
  However, this would complicate calculations somewhat.

That may be why there is a ratio of **1.80** going from D13 to D14 and the largest machine of each group.
The lower the ratio, the less increase.

DO THIS:
Conduct experiment performance test runs on how many transactions can be processed within an hour on a 
"Standard" App Service (providing network load balancing, autoscale, and backup support)
in order to select the righ size of server that can servicie a set of transactions at the lowest overall price.

This would involve configuration of a load balancer for servers.

Sample results of such an experiment is presented in the
<a href="#Calcs"> Calcs Spreadsheet</a>.

If there were no "dissipation" factor, an 8 core server would process the same number of transactions
as 8 one-core servers, say 4800 transactions during a one-hour run,
if transactions occured at the rate of 80 transactions per second.

The total dollars spent ($0.59) divided by the transactions processed is $0.00012 per transaction.

But what if more transactions were processed by several machines?

DO THIS:
In the Calc spreadsheet, 
change the Tot. Trans per sec value for the 1 core machines to 100.



In production, is the number of server instances necessary at each particular point in time?
**Auto-provisioning** by server automation scripts make it possible to automatically adjust the number of 
servers in use at any point in time.

## <a name="MultipleServers"> Single vs. Multiple Servers</a>
Not quantified here are **qualitative** aspects that nevertheless can have a significant impact.

The disadvantage of several smaller servers:

  * Automation of server initiation and take-down requires work
  * Communication among servers (for redunduncy) complicates and use up bandwidth
  * There is a limit to number of physical servers serviced by a single switch
  * Waste in purchasing excess stand-by capacity that "don't earn money"
  * Each copy of the operating system consumes overhead memory
  
The advantage of several smaller servers:

  * Automation of server initiation eliminate human error and enables learning
  * Ability to down individual servers
  * Ability to incrementally add or subtract instances dynamically
  * Assets deployed are more fully utilized


<hr />

Efforts to tune configurations and predict what <a href="#Costing">production usage will cost</a>
typically require a way to impose an emulated load on the system. 

## <a name="ImposingLoad"> Imposing Load</a>
The basic components of response time as observed by end-users:

  1. time client request spend over the network into the server.
  2. time in the server to prepare responses 
  3. time the response travels over the network (as measured by the time when the first byte is received)
  4. time the client spends painting the response on the screen.

Public networks can introduce a significant amount of time to response time.
Some say that it's 75% of the total time.
And that time can vary significantly due to travel distance (propagation delay) 
and competition with others (congestion).

When load generators are placed within actual user machines at the other end of the public internet,
network times can be so significant and vary so significantly that they "drown out" 
the server time component.

To adequately measure time spent on the server without network variation,
the ideal situation is to have a **load generator agent near the front-end web server**
within the data center.


## <a name="VSOnlineVUMs"> VS Online VUMs</a>

As of this writing, Microsoft charges gives each Cloud account's first 20,000 VUMs free each month. 

Because you must have a **minimum of 25 VUsers per agent core** in a run,
that's 800 minutes or (x60=) or **13 one-hour runs free** each month at minimnum load.

No VUserMinutes are charged for runs that end in an error state.

After that, each 100 VUM is $0.40 (40 cents).
That's $0.24 (24 cents) per Vuser Hour.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8075255/4f1b414a-0efb-11e5-87f9-2337b74b7eea.png" width="350" /></a>
https://www.visualstudio.com/en-us/explore/vso-cloud-load-testing-vs
provides a calculator to determine how many virtual user minutes (VUMs) 
a scenario will use.

From https://www.visualstudio.com/en-us/support/load-testing-faq-vs.aspx#EarlierVersions

VUserMinutes = (Maximum user load for the run) * (Duration of the run in minutes).

The minimum values used for calculating VUserMinutes are 25 VUsers and 1 minute. If your run values are smaller than the minimums, then the value will be rounded up to the minimum value. For example, if your load test is set up to run with 100 VUsers for 30 seconds, then the VUserMinutes will be calculated with 1 minute for the duration: 100 (VUsers) * 1 (minute) = 100. The same rule applies to VUser count calculation.

If your run duration is 5 minutes and 15 seconds, then the run duration will be rounded up to the next integer value. In this example, the duration will be 6 minutes.

VUserMinutes (minimum 250, including warm-up period) are deducted from your account for:

*    Completed runs, based on the full duration of the run
*    Aborted runs, based on the elapsed run duration



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


## <a name="Security"> Security</a>


## <a name="MFA"> Multi-Factor Authentication</a>
MFA is charged both by user and by authentication exchange:
* $1.40 per use to maintain keys for that user.
* $0.14 per authentication exchange.

Compare versus https://www.authy.com/pricing/
* $0.15 per user (Azure costs 9 times more)
* $0.05 per successful authentication (Azure costs 3 times more)


## <a name="Monitoring"> Monitoring</a>

Microsoft also sells **monitoring** with alerts with event trace and exception logs on its servers in Azure. 
See https://www.visualstudio.com/features/application-insights-vs
to read about Microsoft's **Application Insights** offering.


## <a name="BackupLogShipping"> Backup and Log Shipping</a>
To avoid loss of data if a server crashes, 
a duplicate of data in production servers are shipped off to another location.

And that may racks up data communication costs, perhaps across AWS Availability Centers.
Google does not 


## <a name="#StormRunner"> Test Cloud Comparison Across Competitors</a>
Compare this against HP's StormRunner Load which charges a flat 15 cents per vuser hour.

* http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-iii-taking-your-load-test-to-the-cloud-i-e-creating-a-cloud-based-load-test.aspx

## <a name="#LoadRunner"> LoadRunner Within AWS</a>
An alternative approach is to run LoadRunner instead of Visual Studio Cloud.

This situation would be useful to use labor-saving TruClient scripts.

More on this in the future.

## <a name="References"> References</a>
Additional information on this topic by JeffreyLush.Net

* https://www.youtube.com/watch?v=nMMJu7IbWfk
  Sizing Cloud with RAM, Storage, CPUs


## <a name="#OtherClouds"> Other Clouds</a>

BTW, by contrast, Amazon's pricing calculator is at
http://calculator.s3.amazonaws.com/index.html.

