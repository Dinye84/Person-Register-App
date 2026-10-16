## Person Register Assignment  
============  

This application lets you search for and display info about Lord of the Rings characters and their businesses. 
  
### Instructions. Build, run program and change data source  
  
To Using PowerShell, navigate to the directory containing the .csproj-file: 
```powershell 
dotnet build 
dotnet run 
``` 

Change data source from hardcoded to external data source by changing the integer number in program.cs Main() / RegisterFunctions.SelectDataSource(2/*switch here*/);.  
The register functions will get the data source depending on which source you select in Program.Main() through the IPeopleDataSources contract.

### Program structure  

Classes and methods are divided by responsibility to make it easier to understand, navigate and update. The classes' responsibylities are divided as follows:  
  
* Program: Runs the program.  
* Person: Structures the properties included in a person.  
* Address: Structures the properties included in an address.  
* Company: Structures the properties included in a company.   
* Menu: Is responsible for how the menu functions  
* RegisterFunctions: Controls the underlying functions of the register like sorting. 
* PrintFunctions: Controls most of the printing of info to console.   
* HardcodedPeopleData: Stores and assembles lists of hardcoded people information.  
* IPeopleDataSources: Decides how data sources are fetched and distributed  
* ImportExternalPeople: Imports external data sources from JSON-file.  
  
### What is C#, .NET and what is the main difference from JavaScript  
  
.NET is a platform used to build and execute, for example web applications, APIs, and desktop programs. C# is a statically typed programming language meaning it is built to avoid mismatches between for example data types, the main difference from JavaScript.  
  
### What is Visual Studio, Git and PowerShell used for and what is commit and branch? 
  
* Visual Studio is an Integrated Development Environment (IDE), used to code programs and makes programming faster, more reliable and cost effective.   
  
* Git is versions control system to make collaboration between developers easier. It enables you to go back in time to see earlier versions. 
  
* In Git you can commit, which means you save staged files, together with comments explaining the changes made. You create a snapshot of your code.   
  
* Branch enables you working on, several versions simultaneously not sacrificing  
the integrity of the existing code. Merging a branch means you merge one version with another.  
  
* PowerShell is a tool and language used to automate tasks on a computer but also to manipulate data. The tool allows user to work with systems and make tasks much more efficient. 