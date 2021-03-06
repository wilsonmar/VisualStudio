Here are my notes on using of VisualStudio from Microsoft for ensuring the performance and capacity of systems.

## <a name="Contents"> Contents</a>
0. <a href="#Versions"> Versions</a>
0. <a href="#DownloadOptions"> Download Options</a>
0. <a href="#OptionalFeatures"> Optional Features to Install</a>
0. <a href="#Distinctives"> Distinctives of Microsoft's Approach</a>
0. <a href="#Editions"> What Edition of Visual Studio?</a>
0. <a href="#CommunityEdition"> Visual Studio Community</a>
0. <a href="#VSCode"> Visual Studio Code</a>
0. <a href="#VSGithub"> Visual Studio Github</a>
0. <a href="#VSOnline"> Visual Studio Online</a>
0. <a href="#VS_Tips"> Visual Studio Usage Tips</a>
0. <a href="#PlugIns"> Plug-Ins (Extension Pack)</a>
0. <a href="#SocialMedia"> Social Media around Visual Studio</a>


## <a name="Versions"> Versions</a>
<a target="_blank" href="https://www.visualstudio.com/products/vs-2015-product-editions">
Visual Studio 2015</a> combines Premium and Ultimate into an **Enterprise** product name.

http://en.wikipedia.org/wiki/Microsoft_Visual_Studio#History
presents a table of the correspondence between product names, 
internal code names, internal version number, release date,
and what version of the core .NET Framework each supports.
Note Visual Studio 2013 supports up to .NET 4.5.2.

For each version there are different <a href="#Editions">editions</a>.

TIP: If you have installers for currently supported version 2013 or 2012, 
use them rather than downloading the big installer with the 
[latest update](http://go.microsoft.com/fwlink/?LinkId=510314) 
([currently 4 release November 12, 2014](https://support.microsoft.com/en-us/kb/2994375)),
then download the smaller **updater** and apply it to the version already installed.

Updates are cumulative such that update 4 contains all the contents in updates 1, 2, and 3.

## <a name="DownloadOptions"> Download Options</a>
For example, the download page for Microsoft Visual Studio 2013 with Update 4 
https://www.visualstudio.com/en-us/downloads/
provides two options for downloading installers:

<img align="right" src="https://cloud.githubusercontent.com/assets/300046/8066305/2e73216c-0ea4-11e5-9460-3c50115d79af.png" width="350" />

  * **Download Now** downloads 1.1 MB file vs_ultimate_download.exe.
  Invoke it to manage download of installers into default folder:

   ```
   C:\Users\%USERNAME%\My Documents\Ultimate 2013
   ```
   
  After the big installer file is fully "acquired", the folder contains file **vs_ultimate.exe**.
  Invoke it. Agree to the terms. Leave the folder at:
  
   ```
   C:\Program Files (x86)\Microsoft Visual Studio 12.0
   ```
   
  PROTIP: 
  This is the approach I recommend because it give you the option to save the installer for reuse
  by other colleagues or on other machines.

  * **Install Now** downloads 1.2 MB file vs_ultimate.exe.
  which when invoked downloads the rest and installs it automatically without additional user intervention.
 
  * **DVD9 ISO Image** downloads the whole 6.9 GB file vs2013.4_ult_enu.iso which requires another utility to read,
  and leaves it to the browser or other program to manage broken downloads
  After downloading you'll need to run a special utility to open the ISO file.

Login to VisualStudio.com is presented during download, but that's not mandatory.

Do not download a Language Pack unless you need another language than English.

Notice licensed editions have a 90 day free trial period.
But the request is registration within 30 days.


### <a name="OptionalFeatures"> Optional Features to Install</a>

* Blend for Visual Studio for UI Design of XAML-based interfaces for Windows Presentation Foundation and Silverlight applications.. See https://en.wikipedia.org/wiki/Microsoft_Blend
* LightSwitch - a simplified, self-service development tool that enables you to build business applications quickly and easily for the desktop and cloud. 
* Microsoft Foundation Classes for C++ [uncheck]
* Microsoft Office Developer Tools [uncheck]
* Microsoft SQL Server Data Tools
* Microsoft Web Developer Tools
* Silverlight Development Kit [uncheck]

## <a name="Distinctives"> Distinctives of Microsoft's Approach</a>

Visual Studio provides a single IDE for developing in "all" languages platforms,
including node.js, PHP, and mobile (with Microsoft Xamarin)
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx

Microsoft has no shortage of competitors.

For its IDE features Visual Studio has competitors in JetBrain's Webstorm, open-source Eclipse (backed by IBM).

For its testing features Visual Studio has competitors in HP's UFT (Unified Functional Test, previously called QTP)
and HP LoadRunner for performance testing. 

The differentiator for Visual Studio is that it provides a single full-fledged user interface for developers and testers alike.

HP LoadRunner's VuGen IDE is based on an open-source clone of Visual Studio 2008,
so does not contain many of the convenience features in Visual Studio of current vintage.
However, Visual Studio can be made to take the place of VuGen to 
edit C-language scripts and invoke LoadRunner's mdrv.exe load generator.


Microsoft has source code for .NET server on
https://github.com/Microsoft/dotnet
(with discussions on http://blogs.msdn.com/b/dotnet/)
rather than Microsoft's CodePlex.com for crowd-sourced contributions.


## <a name="Editions"> What Edition of Visual Studio?</a>

For each version of Visual Studio over time:

### Visual Studio Express vs Community 2013 Free Edition
There are free editions of the Visual Studio IDE
(see https://www.visualstudio.com/en-us/products/free-developer-offers-vs.aspx),
but Microsoft still sells MSDN licenses based on different editions of Visual Studio
because functionality is limited on free editions.

Express editions cannot install Visual Studio <a href="#PlugIns">plug-ins</a>. 
However Community editions can.
Also, Community editions is cross-plantform: it can be used to build across platforms - 
web HTML apps, Windows apps, and Windows Desktop apps.

The Community edition is equivalent to the Pro edition.
In [this table comparing editions](https://www.visualstudio.com/products/compare-visual-studio-products-vs).

COMMENTARY:
It is ironic to me that Microsoft is one of the pioneers in the "Software Developer in Test"
job title, yet the "Test Pro" edition does not include Debugging functionality
or even Architecture Diagrams and Code visualization.
As http://en.wikipedia.org/wiki/Microsoft_Visual_Studio#Editions_feature_grid
highlights, another irony is that the **Test edition of Visual Studio does not run load tests**.

The Pro edition does not include Lab Management functionality:

 * Virtual environment setup & teardown 	  	  	 
 * Provision environment from template 	  	  	 
 * Checkpoint environment

The Online edition doesn't have them either.

The **Ultimate edition** of Visual Studio is required to run
<a href="#Perftest.md">performance/load tests</a>**.

MSDN subscribers also get 40% off PluralSight.com video tutorials.


### <a name="CommunityEdition"> Visual Studio Community</a>

A big part of the resurgence in popularity is Visual Studio's ability to provide one IDE
to work across many mobile platforms (iOS, Android, Windows Phone, etc.).
See http://anydevanyapp.com/

Visual Studio Community 2015 + Cordova tools for developing "hybrid" mobile apps
https://www.visualstudio.com/en-us/features/cordova-vs.aspx

While the Visual Studio Community 2015 + Xamarin tools for developing "native" mobile apps
https://www.visualstudio.com/en-us/features/xamarin-vs.aspx
Xamarin is licensed for $1500 per platform per year per develop.


### <a name="VSCode"> Visual Studio Code</a>

Microsoft released its Code IDE April 2015 during its BUILD conference.

 * http://www.hanselman.com/blog/IntroducingVisualStudioCodeForWindowsMacAndLinux.aspx
 * http://blogs.msdn.com/b/vscode/ is where updates are announced, expected once each month.
 * https://twitter.com/code (@code)

It installer is available from:

 * http://code.visualstudio.com
 * https://www.visualstudio.com/en-us/products/code-vs.aspx
 * https://chocolatey.org/packages/VisualStudioCode for Windows
 * VSCode installer for OS X (file VSCode-darwin.zip) is 64.7 MB (expands to 196.7 MB),
described as "Preview" maturity as of June 2015.

**VSCode works on Macs and Linux** as well as Windows (it's cross-platform).

Ohter competitors to VSCode:

 * Sublime Text
 * WebStorm
 * JetBrains
 * Vi

VSCode provides IntelliCode and [TaskRunner](https://code.visualstudio.com/Docs/tasks)
that runs TypeScript (.ts files) and JS Hint from http://jshint.com/.

VSCode offers debugging for Node.js, but not yet for ASP.NET 5.

Built-in integration with local Git and Github.com.

QUESTION:
Integration with <a target="_blank" href="http://hockeyapp.net/">
HockyApp</a> which Microsoft bought (competitor to Apple's TestFlight)
for beta distribution, crash reporting, and analytics.

Videos by others about VSCode:

* https://www.youtube.com/watch?v=e3tPWAq74v4


## <a name="VSGithub"> Visual Studio Github</a>
https://visualstudio.github.com/index.html
offers a Github Extension for Visual Studio 2015, in RC (Release Candidate) maturity as of June 2015.
This enables Visual Studio to use Github as a source code repository instead of Microsoft's own 
TFS (Team Foundation Server).

But where's the local git repo support?
For VS 2012, see 
http://www.codeproject.com/Articles/581907/IntegratingplusandplusUsingplusGithubplusinplusVis

## <a name="VSOnline"> Visual Studio Online</a>
While it's true that Visual Studio is available **online**
(see https://www.visualstudio.com/en-us/products/what-is-visual-studio-online-vs),
many developers still prefer to download and install Visual Studio on computers used to develop code,
where response time is near instantaneous.
The online edition makes use of Team Foundation Version Control (TFVC) for one massively scalable repo, 
or multiple Git repositories for maximum flexibility.


## <a name="VS_Tips"> Visual Studio Usage Tips</a>
Getting in the habit of using keyboard shortcuts enhances productivity.
http://visualstudioshortcuts.com/2013/ shows all 813 shortcuts for VS 2013.

It's not just about saving micro-seconds that add up saving you several days during your whole career.
It's the ability to stay focused on the code being developed rather than how to control the tool (Visual Studio).
Avoidance of mental "task switching" is required to maintain the concentration ("flow") that developers enjoy.

Susan Ibach's videos at
http://channel9.msdn.com/Series/vstips

Ben Williams's list of tips at
http://blogs.msdn.com/b/benwilli/archive/2015/04/07/back-to-basics-visual-studio-tips.aspx

1. Install the Productivity Power Tools Plug-in
2. Pin your data tips
3. Use “Navigate To”
4. Code Snippets
5. Quickly adding namespace using statements
6. Turn on Line Numbers (with Quick Launch!)
7. Edit whole ines
8. Add existing files with Show All Files
9. Edit directly in the Diff tool


## <a name="PlugIns"> Plug-Ins (Extension Pack)</a>

These can be downloaded and installed from inside Visual Studio's Tools menu "Extensions and Updates".

Productivity Power Tools 2013
https://visualstudiogallery.msdn.microsoft.com/dbcb8670-889e-4a54-a226-a48a15e4cace
continues the tradition of one for each VS version.

NuGet Package Manager 
https://visualstudiogallery.msdn.microsoft.com/27077b70-9dad-4c64-adcf-c7cf6bc9970c?SRC=Home
(like NPM for Node.js) is the top plug-in for Visual Studio.

Others in the **Visual Studio Gallary** of Products and Extensions for Visual Studio
https://visualstudiogallery.msdn.microsoft.com/
include 

* ReSharper from JetBrains
and 
* Save All the Tabs at
https://visualstudiogallery.msdn.microsoft.com/0c5642e8-f6aa-4353-830c-946a315c163d?SRC=Home

https://vlasovstudio.com/
and http://visualstudioextensions.vlasovstudio.com/
provides additional descriptions on top plug-ins.

### <a name="FontColorTemplates"> Font color templates</a>
QUESTION:
Visual Studio Font color templates like the one for Sublime Text at
https://flattr.com/thing/814991/chriskempsontomorrow-theme-on-GitHub,
https://github.com/chriskempson/base16, and
https://github.com/kkga/spacegray

### <a name="Powershell"> Powershell</a>

One of the major benefits of using Microsoft servers is that it has a powerful shell scripting language: 
PowerShell, which Microsoft managed to keep coherant as features were added over time
(while various Linux shells fragmented).

See https://www.microsoftvirtualacademy.com/en-US/training-courses/getting-started-with-powershell-3-0-jump-start-8276

See Scott Hanselman on http://azure.microsoft.com/en-us/documentation/videos/azure-powershell-101-managing-azure-storage-from-the-command-line/ (12 minutes)

https://github.com/psake/psake
is an automated build tool (such as Make, Rake, MSBuild, etc.) written in PowerShell.
http://blogs.msdn.com/b/heaths/archive/2014/06/28/seeing-colors-with-psake.aspx
shows how to set a red color to highlight 

Adam Driscoll's PowerShell Tools for Visual Studio (free)
https://visualstudiogallery.msdn.microsoft.com/c9eb3ba8-0c59-4944-9a62-6eee37294597?SRC=Home

## <a name="SocialMedia"> Social Media around Visual Studio</a>
* http://developer.microsoft.com/
* https://www.facebook.com/MicrosoftItPro app
* https://www.facebook.com/WindowsServer app
* https://www.facebook.com/microsoftazure app
* https://www.facebook.com/MSVirtAcademy education website
* 
* https://www.facebook.com/MSFTDev.US?brand_redir=469287159809482
* LinkedIn
* Twitter

https://github.com/tjanczuk/edge
enables .NET to run within Node.js.
Why one would want to is another matter.

