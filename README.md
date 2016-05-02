# SimpleLogger
Yet another very simple logger library for .NET.

## Installation Instructions
The recommended way to get SimpleLogger is to use NuGet. The following packages are provided and maintained in the public NuGet Gallery.
###SimpleLogger.NET v2.0.0
https://www.nuget.org/packages/SimpleLogger.NET/

## Usage info
Usage is very straightforward
* First we need to create an instance of SimpleLogger
```C#
var logger = = new SimpleLogger(AppName);//we pass string representing our application's name
```
* Then whenever we want to log some anomalous or exceptional situations, we simple call
```C#
logger.Log(message, errorType, exception);//message is string, exception is Exception and errorType must be Enum
```
* Calling Log will create new file in directory
```
MainDrive:\Users\$CurrentUser$\AppData\Roaming\$AppName$\Logs

```
New created file will contain useful info like machine configuration, exception details, message etc
* Logger can also open Logs directory by calling (it will start a new explorer process)
```C#
logger.OpenLogsDirectory();
```
* Optionally, before calling Log, we can provide  some additional information, like
```C#
logger.ClassName = GetType().FullName;
logger.MethodName = MethodBase.GetCurrentMethod().Name;
logger.Parameters["inputString"] = "bad string";
```
