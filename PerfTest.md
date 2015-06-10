This text mark-down (.md) file describes how to do performance testing using Visual Studio.

First of all, there are several ways to perform load tests:

1. From Visual Studio Ultimate installed on a local machine.
2. From an internet browser on the Visual Studio Online website running in Microsoft's Azure cloud.
3. From another software product (such as LoadRunner or SOASTA) using servers in Azure.

## <a name="NewPerftest"> New Performance Testing Script</a>
With either option, create a new script (shown in <a target="_blank" href="http://channel9.msdn.com/Events/Visual-Studio/Launch-2013/qe103">
this video</a>:
1. Install and Launch the Ultimate Visual Studio.
2. Press Ctrl+Shift+N or select menu File | New | Project
3. Select **Web Performance and Load Test Project** in C# (there is no VB for this).
4. Click the red square to begin recording.
5. Type or paste in the URL under test. Each resource requested from the HTML is listed in the Web Test Recorder pane.
    * Follow a pre-planned list of manual actions.
    * QUESTION: Transaction names?
6. Click stop recording button. Visual Studio detects dynamic parameters, etc.


## <a name="Scenario"> Scenario</a>

## <a name="CloudPerftest"> Cloud Performance Testing </a>
With VS 2013, cloud-based Load Testing can, in a single load test run, emulate up to 5,000 users running from
10 agents spanning 20 cores.

With VS 2015, load Tests in Azure can scale out to 25,000 users spanning 100 cores 
http://blogs.msdn.com/b/visualstudioalm/archive/2015/03/23/announcing-100-core-support-for-vso-cloud-load-testing-and-more.aspx


## <a name="Unittest"> Unit Testing </a>
QUESTION:
Can Load Tests leverage unit tests and functional tests?

See
https://www.visualstudio.com/en-us/get-started/code/create-and-run-unit-tests-vs


Credits: This expands on these:

* https://www.visualstudio.com/en-us/support/load-testing-faq-vs.aspx
* http://blogs.msdn.com/b/visualstudioalm/p/cltknowledgebase.aspx

* what Charles Sterling posted on June 1, 2015 in  http://blogs.msdn.com/b/charles_sterling/archive/2015/06/02/load-test-series-part-i-creating-web-performance-tests-for-a-load-test.aspx

* https://www.visualstudio.com/en-us/get-started/test/load-test-your-app-vs

* https://www.visualstudio.com/en-us/get-started/test/get-performance-data-for-load-tests

