This text mark-down (.md) file describes how to do performance testing using Visual Studio Ultimate 2013,
using an approach that introduces concepts as you work hands-on following step-by-step instructions.
This is so you get productive in the quickest possible time.

## Contents

0. <a href="#Videos"> Videos by others about Testing Using Visual Studio</a>
1. <a href="#Why">Why? - App Flow and Risk Assesment</a>
2. <a href="#CreateScript"> Script Performance and Load Test Test</a>
3. <a href="#Config">Configure Recording Options</a>
4. <a href="#Archive"> Archive Assets</a>
5. <a href="#DefineTransactions"> Define Transactions</a>
6. <a href="#ResponseValidation"> Validate Responses</a>
7. <a href="#VaryCSVData"> Vary Data in CSV Files</a>
8. <a href="#VarySQLData"> Vary Data in SQL Databases</a>
9. <a href="#SetRunTimeSettings"> Set RunTime Settings</a>
10. <a href="#LoadGenerators"> Setup Load Generators</a>
11. <a href="#SetupMonitoring"> Setup Monitoring</a>
12. <a href="#Scenarios"> Scenarios</a>
13. <a href="#MonitorRuns"> Monitor Runs</a>
14. <a href="#AnalyzeRunResults"> Analyze Run Results</a>
15. <a href="#AnalyzeLogs"> Analyze Logs</a>

<hr />

## <a name="Videos"> Videos by others about Testing Using Visual Studio</a>

* https://www.youtube.com/watch?v=Igfz8oJ4yOk
* http://www.pluralsight.com/courses/load-testing-visual-studio-2013 
by <a target="_blank" href="http://www.benday.com/"> Benjamin Day</a>, 
   <a target="_blank" href="http://www.twitter.com/benday"> @BenDay</a>

## <a name="Why">Why? - App Flow and Risk Assesment</a>
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

It consists of a collection of HTTP requests sent from test agents instead of real browsers controlled by human users.

 * <a href="#NewPerftest"> Create New Performance Testing Project by Recording</a>
 * <a href="#OpenSampleProject"> Open a Sample Project</a>
 * <a href="#UseFuncTests"> Use CodedUI Functional Tests</a>
 * <a href="#ConvertFiddler"> Convert Fiddler Recording</a>


### <a name="NewPerftest"> Create New Performance Testing Script by Recording</a>
With options 1 - 3, create a new solution (shown in <a target="_blank" href="http://channel9.msdn.com/Events/Visual-Studio/Launch-2013/qe103">
this video</a> and <a target="_blank" href="http://s.ch9.ms/Series/Visual-Studio-2012-Premium-and-Ultimate-Overview/Visual-Studio-Ultimate-2012-Load-testing-applications-in-Visual-Studio">this for VS2010</a>):

#### <a name="CreateProject"> Create Project</a>

1). Install and Launch the Ultimate Visual Studio or Visual Studio Online.
If using IE 11, [disable "Enabled Enhanced Protected Mode" within Internet Options](http://blogs.msdn.com/b/visualstudioalm/archive/2013/09/16/using-internet-explorer-11-and-not-able-to-record-a-web-performance-test-successfully.aspx)

2). In Visual Studio, press Ctrl+Shift+N or select menu File | New | Project
 
   The default project name is **WebTest1.webtest**.

3). Select **Web Performance and Load Test Project** in C# (there is no VB for this).

   Notice this is a different project than Coded UI and 
   <a target="_blank" href="https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs">
   Unit Test</a> projects. 

#### <a name="Config"> Configure Recording Options</a>

4). If the message "The 'Microsoft Web Test Recorder 12.0 Helper' add-on from 'Microsoft Corporation' is ready for use."
appears, click "Enable". 

QUESTION:
Are SSL/TLS certificates or a proxy needed?

To Access via Network see
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/10/load-testing-applications-behind-firewall-using-trusted-ip.aspx

#### <a name="Record"> Record Traffic</a>

5). Right-click on the **WebTest** to **Add Recording**.
   or click the red square for the **Web Test Recorder**.

<a target="_blank" href="https://cloud.githubusercontent.com/assets/300046/8223466/356efff8-1535-11e5-899f-8bafe47dd68e.png">
<img src="https://cloud.githubusercontent.com/assets/300046/8223466/356efff8-1535-11e5-899f-8bafe47dd68e.png"
width="350" /></a>

6). Type or paste in the URL under test. Each resource requested from the HTML is listed in the Web Test Recorder pane.

   Follow a pre-planned list of manual actions.
   
   QUESTION: Transaction names are NOT added during recording?

7). Click stop recording button. Visual Studio detects dynamic parameters, etc.

8). TIP: Save the solution folder, then zip it up.

A recording is just the beginning.


### <a name="OpenSampleProject"> Open Sample Project</a>
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

### <a name="UseFuncTests"> Use CodedUI Functional Tests</a>
QUESTION:
Can Load Tests leverage JUnit tests and functional tests coded in CodedUI?



### <a name="ConvertFiddler"> Convert Fiddler Recording</a>
An alternate way of creating a WebTest script is make a recording using **Fiddler**
to generate a pcap file.
The pcap file is parsed by ??? to create a WebTest script.

<hr />

## <a name="Archive"> Archive Project Assets</a>
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

<hr />

## <a name="DefineTransactions"> Define Transactions</a>
Specify the name of what should be measured.


## <a name="ResponseValidation"> Validate Response</a>
Ensure that what is returned is what is expected.


## <a name="VaryCSVData"> Vary CSV Data</a>

See https://msdn.microsoft.com/en-us/library/ms243142.aspx
To add a data source (named ColorWebAppData) to a web performance test

## <a name="VarySQLData"> Vary SQL Data</a>


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

The **Details Sampling rate** in seconds and 

**Save Log on Test Failure** is True/False setting.


## <a name="SetupMonitoring"> Setup Monitoring</a>

### <a name="CounterSets"> Counter Sets</a>
Counter sets specify what computers in the test rig to **monitor**.

TIP:
Monitoring involves generation of logs which fill up disk space, 
so it's best to not monitor until serious load is imposed.


<hr />



Credits: This expands on these:

* https://www.visualstudio.com/en-us/support/load-testing-faq-vs.aspx
* http://blogs.msdn.com/b/visualstudioalm/p/cltknowledgebase.aspx

* what Charles Sterling posted on June 1, 2015 in  http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests

## <a name="MonitorRuns"> Monitor Runs</a>

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
