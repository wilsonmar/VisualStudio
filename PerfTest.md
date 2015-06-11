This text mark-down (.md) file describes how to do performance testing using Visual Studio Ultimate 2013,
using an approach that introduces concepts as you work hands-on following step-by-step instructions.
This is so you get up to speed in the quickest time.

## <a name="Scripting"> Performance and Load Test Scripting</a>
Automated scripts create **virtual users** that take the place of browser real human users.

 * <a href="#NewPerftest"> Create New Performance Testing Script by Recording</a>
 * <a href="#OpenSampleProject"> Open a Sample Project</a>
 * <a href="#ConvertFiddler"> Convert Fiddler Recording</a>


### <a name="NewPerftest"> Create New Performance Testing Script by Recording</a>
With options 1 - 3, create a new solution (shown in <a target="_blank" href="http://channel9.msdn.com/Events/Visual-Studio/Launch-2013/qe103">
this video</a>:

1. Install and Launch the Ultimate Visual Studio or Visual Studio Online.
2. Press Ctrl+Shift+N or select menu File | New | Project
 
   The default project name is "WebTest".

3. Select **Web Performance and Load Test Project** in C# (there is no VB for this).

   Notice this is a different project than Coded UI and 
   <a target="_blank" href="https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs">
   Unit Test</a> projects. 

4. Click the red square to begin recording.
5. Type or paste in the URL under test. Each resource requested from the HTML is listed in the Web Test Recorder pane.

    * Follow a pre-planned list of manual actions.
    * QUESTION: Transaction names are NOT added during recording?

6. Click stop recording button. Visual Studio detects dynamic parameters, etc.
7. Save the solution.


### <a name="OpenSampleProject"> Open Sample Project</a>
Opening an existing project provides a glimpse into the complete set of folders and files involved.

If you're using Visual Studio Ultimate 2013:

1. From within an internet browser, open URL
https://code.msdn.microsoft.com/Getting-started-with-17a52e95
2. Click on **C# (33.4 KB)** to download into your Downloads folder.
3. In Windows Explorer, unzip file **Visual Studio Load Testing** downloaded.

 * Descriptions.html contains the page providing the download link.

4. If you have a folder containing Visual Studio projects, copy the **C#** folder there and rename.
5. In VS Ultimate 2013, navigate to the **GettingStartedWithLoadTesting.sln** to open it.
6. From the Solution Explorer pane, open **SampleWebTest.webtest**.
7. Select the URL listed in SampleWebTest.webtest file.


### <a name="ConvertFiddler"> Convert Fiddler Recording</a>
An alternate way of creating a WebTest script is make a recording using **Fiddler**
to generate a pcap file,
which is converted to a webtest script.

<hr />

## <a name="LoadGenerators"> Load Generators</a>
There are several ways to perform load tests:

1. From within Visual Studio Ultimate installed on a local machine, run on the same machine (to verify script logic).
2. From within Visual Studio Ultimate installed on a local machine, run on a TFS (Test Foundation Server).
3. From an internet browser on the Visual Studio Online website running in Microsoft's Azure cloud.
4. From another software product (such as LoadRunner or SOASTA) using servers in Azure.


### <a name="NetworkAccess"> Access via Network</a>
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/10/load-testing-applications-behind-firewall-using-trusted-ip.aspx


## <a name="NewLoadTest"> New Load Test</a>
With Visual Studio, in the Solution Explorer, right-click on the project and select **Add** a **Load Test**
for the New Test Wizard.

* A **Web Performance Test** focuses on response time by one or a few users.
* A **Load Test** is also called a **stress** test because it involves many virtual users.

Unlike LoadRunner, which has a separate Controller, Visual Studio provides a one-stop shop.


## <a name="Scenario"> Scenario Specification</a>
Each Scenario consists of:

   * <a href="#LoadPattern"> Load Pattern</a> specifies the user count.
   * <a href="#TestMixModel">Text Mix Model</a>
   * <a href="#TestMix"> Test Mix</a>
   * <a href="#NetworkMix"> Network Mix</a>
   * <a href="#BrowserMix"> Browser Mix</a> specifies the distribution of different browsers. LoadRunner requires additional custom coding to do this.

### <a name="LoadPattern"> Scenario Load Pattern</a>
Load Pattern 


### <a name="TestMixModel">Text Mix Model</a>

   * Based on the total number of tests
   * Based on the number of virtual users
   * Based on user pace
   * Based on sequential test order

### <a name="TestMix">Test Mix</a>
In Visual Studio, a "Test" refers to the projects selected for inclusion in a test run
by clicking **Add**.

A Distribution defaults to 100%.

### <a name="RunSettings"> Run Settings</a>
The duration of the run is specified in the Run Settings pane.

The **Details Sampling rate** in seconds and 

**Save Log on Test Failure** is True/False setting.

### <a name="CounterSets"> Counter Sets</a>
Counter sets specify what computers in the test rig to **monitor**.

TIP:
Monitoring involves generation of logs which fill up disk space, 
so it's best to not monitor until serious load is imposed.


### <a name="TestSettings"> Test Settings</a>

Test settings for a local test run are stored in the **vsonline.testsettings** file.

* SampleWebTest.webtest
* SampleLoadTest.loadtest
* GettingStartedWithLoadTesting.csproj
* AssemblyInfo.cs in the Properties folder


## <a name="CloudPerftest"> Cloud Performance Testing </a>
With VS 2013, cloud-based Load Testing can, in a single load test run, emulate up to 5,000 users running from
10 agents spanning 20 cores.

With VS 2015, load Tests in Azure can scale out to 25,000 users spanning 100 cores 
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/23/announcing-100-core-support-for-vso-cloud-load-testing-and-more.aspx


## <a name="Unittest"> Unit Testing </a>
QUESTION:
Can Load Tests leverage unit tests and functional tests?

See



Credits: This expands on these:

* https://www.visualstudio.com/en-us/support/load-testing-faq-vs.aspx
* http://blogs.msdn.com/b/visualstudioalm/p/cltknowledgebase.aspx

* what Charles Sterling posted on June 1, 2015 in  http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests

