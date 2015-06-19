This text mark-down (.md) file describes how to do performance testing using Visual Studio Ultimate 2013,
using an approach that introduces concepts as you work hands-on following step-by-step instructions.
This is so you get productive in the quickest possible time.

## Contents

0. <a href="#SampleApp"> Sample Apps</a>
0. <a href="#Videos"> Videos by others about Testing Using Visual Studio</a>
1. <a href="#Why">Why? - App Flow and Risk Assesment</a>
2. <a href="#CreateScript"> Script Performance and Load Test Test</a>
3. <a href="#Config">Configure Recording Options</a>
4. <a href="#RecordUIRequests"> Record Traffic</a>
4. <a href="#Archive"> Archive Scripts</a>
5. <a href="#DefineTransactions"> Define Transaction Test Names</a>
6. <a href="#ResponseValidation"> Validate Responses</a>
7. <a href="#VaryStaticData"> Vary Static Data in Scripts</a>
8. <a href="#VaryCSVData"> Vary Data in CSV Files</a>
9. <a href="#VarySQLData"> Vary Data in SQL Databases</a>
10. <a href="#SetRunTimeSettings"> Set RunTime Settings</a>
11. <a href="#LoadGenerators"> Setup Load Generators</a>
12. <a href="#SetupAppCounters"> Add Perfmon Counters into App Source</a>
12. <a href="#SetupMonitoring"> Setup Monitoring</a>
13. <a href="#Scenarios"> Scenarios</a>
14. <a href="#MonitorRuns"> Monitor Runs</a>
15. <a href="#AnalyzeRunResults"> Analyze Run Results</a>
16. <a href="#AnalyzeLogs"> Analyze Logs</a>
17. <a href="#ProfileCode"> Profile App Source Code</a>
18. <a href="#ArchiveResults"> Archive Run Results</a>

<hr />

## <a name="SampleApp"> Sample Apps</a>
There are several apps that can be used.
<a target="_blank" href="http://blogs.msdn.com/b/briankel/">
Brian Riankel</a>, Director of ALM Evanagelism for Microsoft, 
has created virtual machines for
<a target="_blank" href="http://blogs.msdn.com/b/briankel/archive/2013/08/02/visual-studio-2013-application-lifecycle-management-virtual-machine-and-hands-on-labs-demo-scripts.aspx"> Visual Studio 2013 Update 3 on September 2014</a>.

These are very large files.


## <a name="Videos"> Videos by others about Testing Using Visual Studio</a>

  * http://www.pluralsight.com/courses/load-testing-visual-studio-2013 
      by <a target="_blank" href="http://www.benday.com/"> Benjamin Day</a>, 
      <a target="_blank" href="http://www.twitter.com/benday"> @BenDay</a>
  * https://www.youtube.com/watch?v=-TfwvavMVg4&list=PLT_-sjxAxUnETyDOImAikBhf50CVAkiGg
    is a playlist about VS2010 web performance tests.
  * https://www.youtube.com/watch?v=s0VQOkyEL7M using VS 2012 Ultimate by handsonvisualstudio.com
     of meaalmcommunity.com
  * https://www.youtube.com/watch?v=Igfz8oJ4yOk
  * Microsoft DemoMates to provide a “click through” of product screens without needing to download and run the virtual machine.
  * https://www.youtube.com/watch?v=37x8cHK7qLU - Load Testing SharePoint 2013 using Visual Studio 2013
        <a target="_blank" href="http://sharepoint.rackspace.com"> Rackspace</a>
     by <a target="_blank" href="http://www.toddkilindt.com"> Todd Klindt</a> at
     and Shake Young (@ShaneseCows)


## <a name="Why">Why? - App Performance and Load Risk Assesment</a>
Load (Stress) Testing is used for performance tuning, to uncover bottlenecks, and for capacity planning.

The reason for doing it is evolving from catching mistakes to preparing a work environment that
can scan ahead for potential issues and respond quickly when issues occur.

Doing the "homework" of creating scritps and analyzing performance and capacity
enables production issues to be diagnosed quickly.

Analyzing monitoring during tests enables the team to identify pre-cursors or early warning signs to issues
so that problems are averted before they cause wider impact.

Defects in performance and load can be filed within 
<a target="_blank" href="https://msdn.microsoft.com/en-us/library/dd293538%28v=vs.110%29.aspx">
from within Visual Studio</a>.

http://www.codeproject.com/Articles/534797/Troubleshooting-ASP-NET-based-Enterprise-Applicati
presents examples of performance issues in ASP.NET servers.


## <a name="CreateScript"> Performance and Load Test Scripting</a>
The "Performance and Load Test" is a type of C# project added to a solution. 

Instead of real browsers controlled by human users,
tests are a collection of **HTTP requests** sent from many **test agents** 
(also called load generators or robots) which simulate what browsers send to servers.

Options:

 * <a href="#NewPerftest"> Create New Web Performance Testing Project by Recording</a>
 * <a href="#OpenSampleProject"> Open a Sample Project</a>
 * <a href="#CodedUITests"> Use CodedUI Functional Tests</a>
 * <a href="#ConvertFiddler"> Convert Fiddler Recording</a>


## <a name="NewPerftest"> Create New Performance Testing Script by Recording</a>
With options 1 - 3, create a new solution (shown in <a target="_blank" href="http://channel9.msdn.com/Events/Visual-Studio/Launch-2013/qe103">
this video</a> and <a target="_blank" href="http://s.ch9.ms/Series/Visual-Studio-2012-Premium-and-Ultimate-Overview/Visual-Studio-Ultimate-2012-Load-testing-applications-in-Visual-Studio">this for VS2010</a>):

### <a name="CreateProject"> Create Project</a>

1). Install and Launch the Ultimate Visual Studio or Visual Studio Online.
If using IE 11, [disable "Enabled Enhanced Protected Mode" within Internet Options](http://blogs.msdn.com/b/visualstudioalm/archive/2013/09/16/using-internet-explorer-11-and-not-able-to-record-a-web-performance-test-successfully.aspx)

2). In Visual Studio, press Ctrl+Shift+N or select menu File | New | Project
 
   The default project name is **WebTest1.webtest**.
   
   PROTIP:
   Assign a file name according to a naming convention common to the whole team
   so that assets across **apps** and projects and content and **versions** over time can be uniquely identified.

3). Select **Web Performance and Load Test Project** in C# (there is no VB for this).

   Notice this is a different project than Coded UI and 
   <a target="_blank" href="https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs">
   Unit Test</a> projects. 


##### <a name="Config"> Configure Recording Options</a>

4). If the message "The 'Microsoft Web Test Recorder 12.0 Helper' add-on from 'Microsoft Corporation' is ready for use."
appears, click "Enable". 

QUESTION:
Are SSL/TLS certificates or a proxy needed?

To Access via Network see
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/10/load-testing-applications-behind-firewall-using-trusted-ip.aspx

##### <a name="RecordUIRequests"> Record UI Traffic</a>

5). Right-click on the **WebTest** to **Add Recording**.
   or click the red square for the **Web Test Recorder**.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8223466/356efff8-1535-11e5-899f-8bafe47dd68e.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8223466/356efff8-1535-11e5-899f-8bafe47dd68e.png"
width="350" /></a>

6). Type or paste in the URL under test. Each resource requested from the HTML is listed in the Web Test Recorder pane.

   Follow a pre-planned list of manual actions.
   
   QUESTION: 
   <a href="#DefineTransactions"> Transactions</a>
   are NOT added during recording?

7). Click **Stop** recording button. Visual Studio detects dynamic parameters, etc.

##### <a name="RecordAPIRequests"> Record API Traffic</a>

QUESTION:
To create a "headless" API request sent by a server without UI ...


## <a name="Archive"> Archive Project Assets</a>
8). PROTIP: Save the solution folder, then zip it up.

Performance and lod tests can use up a large amount of disk space.
And servers may need to be brought down when not used.
So project assets need to be moved to a storage medium for lower cost than 
instantly available drives which are more expensive to rent.

WARNING: Do not manually edit the .loadtest xml.
Doing so would result in errors such as:

 * VS1550084 - run aborted because the .loadtest xml file could not be parsed.
 * VS1550026 & VS1550027 - too many applications or counters have been selected to run for load test.

Incremental archival would ensure that back versions of files are automatically saved
and available to analyze what changed and to reverse those changes if need be.


### <a name="CleanUpScript"> Clean Up Script</a>

9). PROTIP: Clear-up the script by deleting extraneous lines (that are not .aspx calls):

   * "_browserLink" calls Visual Studio uses.
   * "SignalR" uses HTTP Web Sockets.


## <a name="OpenSampleProject"> Open Sample Project</a>
Opening an existing project provides a glimpse into the complete set of folders and files involved.

If you're using Visual Studio Ultimate 2013:

1. From within an internet browser, open URL
https://code.msdn.microsoft.com/Getting-started-with-17a52e95

2. Click on **C# (33.4 KB)** to download into your Downloads folder.

3. In Windows Explorer, unzip file **Visual Studio Load Testing** downloaded.

 * File "Descriptions.html" contains the page providing the download link.

4. If you have a folder containing Visual Studio projects, copy the **C#** folder there and rename.
5. In VS Ultimate 2013, navigate to the **GettingStartedWithLoadTesting.sln** to open it.
6. From the Solution Explorer pane, open **SampleWebTest.webtest**.
7. Select the URL listed in file "SampleWebTest.webtest".

If you're using Visual Studio Ultimate 2012 or 2010:
<a target="_blank" href="https://msdn.microsoft.com/en-us/library/dd293540%28v=vs.110%29.aspx">
This MSDN website</a> 
walks you through how to create the
"ColorWebAppTest" project.


### <a name="CodedUITests"> Use CodedUI Functional Tests</a>
Wheras WPTs simulate request and response traffic out of and back to browsers,
Microsoft's CodedUI tests **take over a runnning app** and controls keyboard clicks and mouse activities. 
Thus, one agent machine is needed to emulate each individual UI user.
(Can you afford to do that?)

Tutorials on CodedUI:

 * http://www.pluralsight.com/courses/codedui-test-automation by Marcel de Vries
 
1) Download "Agents for Microsoft Visual Studio 2013" 287 MB file VS2013_RTM_AGTS_ENU.iso
from http://www.microsoft.com/en-us/download/details.aspx?id=40750.

2) Use Pismo 
or other program to mount the iso file.

3) Run the **Test Agent Configuration Tool** (TestAgentConfig.exe).

The test agent can be re-configured from service mode to process mode.


### <a name="NUnitTests"> Use NUnit API Tests</a>
NUnit tests operate at the API level.


### <a name="ConvertFiddler"> Convert Fiddler Recording</a>
An alternate way of creating a WebTest script is make a recording using **Fiddler**
to generate a pcap file.
The pcap file is parsed by ??? to create a WebTest script.

<hr />

## <a name="DefineTransactions"> Define Test Names (Transactions)</a>
<a target"_blank" href="https://cloud.githubusercontent.com/assets/300046/8229282/9171665a-1572-11e5-828d-e93718ae85dd.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8229282/9171665a-1572-11e5-828d-e93718ae85dd.png" width="200" /></a>

Right-click on the first of each significant group of HTTP Requests
and select **Insert Comment** to 
define a **Test Name** (akin to "transactions") as an artificial way to measure **response time**
-- how long a sequence of HTTP requests take from request to response from the server.

Repeat this for the rest of the requests.

PROTIP:
Prefix test names with some character (such as "***" or ">>>") so they stand out better.

PROTIP:
Initially, some prefer to measure response time for an entire sequence of requests.
Others prefer to invest the time up front to specify a one transaction name for each request.
This is why some organizations define a policy on this along with elements within test names.

PROTIP:
Some like to put a number in test names.
But changes to sequential numbers would require renaming all other names.



## <a name="ParametizeWebServers"> Parametize Web Servers</a>
<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8238119/e8e09bca-15b0-11e5-8ea6-835cecc13e55.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8238119/e8e09bca-15b0-11e5-8ea6-835cecc13e55.png" 
width="200" /></a>

1) Click on the menu icon.

   Visual Studio creates "WebServer1" as the default **Context Parameter Name** for the web servers it finds.

2) Click OK.

   The host name in all requests are replaced with **{{WebServer1}}**
   "squiggly brackets" or "double braces".


## <a name="ResponseTimeGoal"> Think Time and Response Time Goal</a>

At the bottom of the requests, 
Visual Studio automatically adds a Validation Rule **Response Time Goal**.

Click the right-most menu icon to **Set Request Details**
to change the Think Time and Response Time Goal.


## <a name="WaitLoops"> Loops and Wait</a>
1). Right-click on a request and select **Insert Condition**.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8256432/4d2d4728-1664-11e5-9dfb-8f3ebd0aa995.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8256432/4d2d4728-1664-11e5-9dfb-8f3ebd0aa995.png" 
width="200" /></a>

2). Select rule **Context Parameter Exists** 

 If you specify a Context Parameter Name value, and the value, it will perform the function in the 
 **Items in condition** at the bottom of the dialog.

3). Right-click on the same request and select **Insert Loop**.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8256620/918dd3dc-1665-11e5-8830-32a601c48c32.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8256620/918dd3dc-1665-11e5-8830-32a601c48c32.png" 
width="200" /></a>

4). Select rule **Context Parameter Exists** 
or **Probability Rule** to run a request only the specified percentage of the time.

**For Loop** modifies a context parameter where Counting Loop does not.




## <a name="ResponseValidation"> Validate Response</a>
<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8235938/3e0eee9e-15a2-11e5-846f-bd14c2d13f08.png">
<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8235938/3e0eee9e-15a2-11e5-846f-bd14c2d13f08.png" 
width="200" /></a>

To ensure that what is returned is what is expected:

1) Right-click on a HTTP request and select **Add Extraction Rule**.

2) Select (CSS) **Tag Inner Text** which puts what is extracted into a **Context Parameter**.

3) Specify the Context Parameter Name.

4) Specify the Tag Name in HTML - "span" or "div", etc.

5) Specify the Attribute Name - "id" or "class".

6) Specify the Attribute Value.

7) Do a test run

   The nice thing about Visual Studio is for each request you can see its

   Web Browser | Request | Response | Context | Details

8) Click on Context and scroll down to see the parameter.


## <a name="VaryStaticData"> Parametize Static Values in Scripts</a>
Right-click on a HTTP Request step and select an item to Insert or Add.

Replace static (hard-coded) values with a parameter (aka variable) surrounded by "squiggly brackets"
**{{variable_name}}**,
where variable_name is a name of your choosing.

This is called "pameterization".

## <a name="VaryCSVData"> Vary CSV Data in New Project</a>
## <a name="CustomRules"> Custom Validation and Extraction Rules</a>
1). Right-click on the solution.

2). Add a New Project - Class Library named "Utilities".

3). Expand the WebTest project to References to the
Microsoft.VisualStudio.QualityTools.WebTestFramework.dll.

4). Right-click on it for Properties to copy into your invisible Windows clipboard path
C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\PublicAssembiles\

5). In the new Utilities class References, select Add References.

6). Browse.

7). Paste the path in the File Name and click Add, then OK.

8). Rename the default Class1.cs.

9). Extend the class from the ValidationRule or ExtractionRule base class

```
public class TableColumnValueValidator : validationRule
```

10). From the autocomplete select **using Microsoft.VisualStudio.TestTools.WebTesting**.

11). Right-click again to select **Implement abstract class 'Validation Rule' to generate a basic method code.

```
public override void Validate(object sender, ValidatiionEventArgs e)
{
    throw new NotImplementedException();
}
```

12). Add  attributes for use by a Validate() or Extract() method.

```
[DisplayName("Table Column Value")] 
[Description("Validates value exists in column X in HTML table")]
```


## <a name="VarySQLData"> Vary SQL Data</a>

See https://msdn.microsoft.com/en-us/library/ms243142.aspx
To add a SQL database data source (named ColorWebAppData) to a web performance test


## <a name="SetRunTimeSettings"> Set RunTime Settings</a>
See https://msdn.microsoft.com/en-us/library/ff406976.aspx

   * General Properties

   * Logging Properties

   * Results Properties

   * SQL Tracing Properties

   * Test Iterations Properties

   * Timing Properties

   * WebTest Connections Properties

   * Changing Run Setting Properties

<hr />
## <a name="LoadGenerators"> Load Generators</a>
There are several ways to perform load tests:

1. From within Visual Studio Ultimate installed on a local machine, run on the same machine (to verify script logic).
2. From within Visual Studio Ultimate installed on a local machine, run on a TFS (Test Foundation Server).
3. From an internet browser on the Visual Studio Online website running in Microsoft's Azure cloud.
4. From another software product (such as LoadRunner or SOASTA) using servers in Azure.

### <a name="CloudPerftest"> Cloud Performance Testing </a>
With VS 2013, cloud-based Load Testing can, in a single load test run, emulate up to 5,000 users running from
10 agents spanning 20 cores.

With VS 2015, load Tests in Azure can scale out to 25,000 users spanning 100 cores 
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/23/announcing-100-core-support-for-vso-cloud-load-testing-and-more.aspx



## <a name="NewLoadTest"> New Load Test</a>
With Visual Studio, in the Solution Explorer, right-click on the project and select **Add** a **Load Test**
for the New Test Wizard.

* A **Web Performance Test** focuses on response time by one or a few users.
* A **Load Test** is also called a **stress** test because it involves many virtual users.

Unlike LoadRunner, which has a separate Controller, Visual Studio provides a one-stop shop.


## <a name="Scenarios"> Scenarios</a>
With LoadRunner, a "scenario" is a collection of conditions defining a test run,
such as the number of vusers, ramp-up speed, etc.

   * <a href="#LoadPattern"> Load Pattern</a> specifies the **user count**.
   * <a href="#TestMixModel">Text Mix Model</a>
   * <a href="#TestMix"> Test Mix</a>
   * <a href="#NetworkMix"> Network Mix</a>
   * <a href="#BrowserMix"> Browser Mix</a> specifies the distribution of different browsers. LoadRunner requires additional custom coding to do this.
 
QUESTION: More ???   

### <a name="LoadPattern"> Scenario Load Pattern</a>
Load Pattern ???


### <a name="TestMixModel">Text Mix Model</a>

   * Based on the total number of tests
   * Based on the number of virtual users
   * Based on user pace
   * Based on sequential test order

### <a name="TestMix">Test Mix</a>
In Visual Studio, a "Test" refers to the projects selected for inclusion in a test run
by clicking **Add**.

A Distribution defaults to 100%.



### <a name="TestSettings"> Test Settings</a>

Test settings for a local test run are stored in the **vsonline.testsettings** file.

* SampleLoadTest.loadtest contains XML defining Counter Sets and references the TestProfile
* SampleWebTest.webtest
* GettingStartedWithLoadTesting.csproj
* AssemblyInfo.cs in the Properties folder


### <a name="RunSettings"> Run Settings</a>
The duration of the run is specified in the Run Settings pane.

The **Details Sampling rate** in seconds.

**Save Log on Test Failure** is True/False setting.


## <a name="SetupAppCounters"> Add Custom Counters into App Source</a>
Exposing counters of how many of each operation has occured is like having a 3D X-Ray video of an app.

The earlier this is implemented early in the dev cycle, the better the pay-back throughout the life of the program.

This tutorial is based on these writings:
* http://rtarlowski.blogspot.com/2011/10/c-custom-performance-counters-part-ii.html
* http://www.codeproject.com/Articles/8590/An-Introduction-To-Performance-Counters by Michael Groeger in 2005.
* http://www.benday.com/2011/12/17/how-to-create-custom-performance-monitor-perfmon-counters/
* http://www.codeproject.com/Articles/12992/Using-custom-attributes-to-add-performance-counter uses the .NET Framework's
  PerformanceCounterCategory class.


1). Using the <a target="_blank" href="https://msdn.microsoft.com/en-us/library/system.diagnostics.performancecountertype.aspx">
System.Diagnostics library</a>, create a .PerfCounters namespace containing a PerfmonCounterLocator class
and a CategoryName for Perfmon to display.

```
using System.Diagnostics;

namespace my.app.PerfCounters {
    public class PerfmonCounterLocator {
        private static object m_SyncRoot = new object();
        private const string CategoryName = "Stuff App Custom Counters";
        private PerfmonCounterLocator() {
            GetAllStuff = new PerfmonOp( Category Name, "Get all Stuff" );
            ....
```

2). Identify in the source code the various **operations** (get, save, set, etc.).
For each potentially problematic operation function on key objects (for example, GetAllStuff), define:

```
public PerfmonOp GetAllStuff { get; private set; }
```

3). In the .cs file that does real work, before the try code,
begin the clock:

```
var startTicks = DateTime.Now.Ticks;
```

4). In the .cs file that does real work, code in the catch section (before the throw),
the Manager error counter: 

```
PerfmonCounterLocator.Instance.PersonManagerError.RecordOperation();
```

5). Code in the finally section calculate and report the elapsed time:

```
PerfmonCounterLocator.Instance.GetAllStuff.RecordOperation(
    DateTime.Now.Ticks - startTicks);
```


## <a name="SetupMonitoring"> Setup Monitoring</a>



### <a name="CounterSets"> Counter Sets</a>
Counter sets specify what computers in the test rig to **monitor**.

1). Right-click on **Custom Counter** to Add Counters.

2). Select the Computer (web server), Performance category ("Stuff App Custom Counters" above).

3). Multi-select the counters defined in the source code.

### <a name="RunSettings"> Run Settings</a>

1). Right-click on the web server name under Counter Set Mappings.

2). Select **Manage Counter Sets...*.

3). Select Custom Counter, then OK.

4). Run a Load Test to see the counters.

PROTIP:
Monitoring involves generation of logs which fill up disk space, 
so it's best to not monitor until serious load is imposed.


<hr />


## <a name="MonitorRuns"> Monitor During Runs</a>
1). Open Microsoft SQL Server Management Studio.

2). Connect to the database being used in the test.

3). Invoke **sql_who2** to list current connections to the database 

The total is shown in yellow at the bottom of the UI, as the number of rows.

Tutorial Videos on this topic:

   * https://www.youtube.com/watch?v=eR-zDM-hhv4 - distributed load tests using VS2010

Subscribe to alerts
http://social.msdn.microsoft.com/Forums/vstudio/en-US/74fdaf92-e293-4d71-bd63-cfcc8a9dcd60/subscribe-to-alerts-about-team-foundation-service-and-elastic-load-service-status

View Visual Studio Online Portal
https://www.visualstudio.com/support-overview-vs

http://blogs.msdn.com/b/vsoservice/

The states for a load test run within Visual Studio Online are:

 * **In-Progress**: The test run is currently running in the cloud.
 * **Completed**: The test run has completed successfully.
 * **Aborted**: The test run has been stopped by the user clicking the stop button. This state can also occur if there are issues related to your load test. For example, aborted can occur if there are issues in your test scripts.
 * **Error**: The test run has stopped due to an error with the service itself. For example, there might be an infrastructure issue in the service and it is unable to continue to run your test. This is not an issue caused by your load test or test scripts.

<img src="https://cloud.githubusercontent.com/assets/300046/8152936/87507aaa-12e1-11e5-9663-cb1f69007a75.png" />


## <a name="AnalyzeRunResults"> Analyze Run Results</a>
Analysis includes calculating and interpreting probability statistics
such as as average, median, standard deviation, and coefficient of variation.

This also includes graphing results to illustrate relationships among metrics collected.


## <a name="AnalyzeLogs"> Analyze Logs</a>
It's rather rare, but some performance issues are identified by looking into the "weeds"
https://msdn.microsoft.com/en-us/magazine/dn519926.aspx


## <a name="ProfileCode"> Profile App Source Code</a>
One advantage of Visual Studio is that its **Performance Wizard** 
is built into the same program that defines and runs load tests.

1). Press Alt+F2 or select from the ANALYZE menu Performance and Diagnostics.

 The current project is pre-selected as the Startup project.
 
2). Click Start.

3). Select the method of profiling:

 * CPU Sampling is the recommended method to monitor CPU-bound applications with low overhead.
 * Instrumentation to measure function call counts and timing
 * .NET Memory allocation, 
 * Resource contention data (concurrency) to detect threads waiting for other threads

4). Select the app and click Next.

5). Select the client (Internet Explorer) and click Next.

6). Click Finish to launch.

7). **Manually** operate the app.

  QUESTION: Can this be automated?

8). Close the browser.

9). In **Call Tree**, click **Expand Hot Path** at each level of function calls.

10). Click on the line with a large number under the Inclusive Samples column.

11). Click View Source associated with the line.

All this is usually done by the developer who wrote the program.
A course on performance is at:
* https://developer.innerworkings.com/Catalog/B0005-CS

## <a name="ArchiveResults"> Archive Run Results</a>
The general rule is that, on average, runs generate **10 GB** of data per run.

Each DVD stores up to 4 GB of data, but do provide 30 years of stable storage.

USB hard drives now can store 1 TB (1,000 GB) for $100 each.

PROTIP:
Define a naming convention for run outputs so you can
separate out files in a way that you can reassemble them again later.

PROTIP:
Put in GitHub or source coutrol programmoing code such as:

 * Custom programs to parse data

Put into SharePoint human-reable information:

 * Presentation PowerPoint files
 * Final Excel files which provide the numbers and graphs in the presentation
 * Procedures Word documents
 * Project Contacts data (exported from Outlook)
 * Video (avi or mp4) files
 * Analysis Notes for each load test result
 * List of monitors

Put into removeable hard drives:

 * Intermediate Excel files
 * Emails and Lync/Skype logs
 * Video capture (Camtasia .trec) files
 * Raw results
 * SQL Trace files
 * Parsed data

There should be a policy about destruction based on a calendar such as 1 year.


## <a name="Credits"> Credits</a>
Further information on this topic:

* https://www.visualstudio.com/en-us/support/load-testing-faq-vs.aspx

* http://blogs.msdn.com/b/visualstudioalm/p/cltknowledgebase.aspx

* what Charles Sterling posted on June 1, 2015 in  http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests
