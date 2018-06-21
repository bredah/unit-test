# Example: C# with .Net Core

[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=sample-application)](https://travis-ci.org/bredah/unit-test.svg?branch=master)
[![Coverage Status](https://coveralls.io/repos/github/bredah/unit-test/badge.svg?branch=master)](https://coveralls.io/github/bredah/unit-test?branch=master)

- [Project Structure](#Project-Structure)
- [Environmnet Validation](#Environmnet-Validation)
- [CLI](#CLI)
  - [Restore (packages), Clean and Build the project](#Restore-(packages),-Clean-and-Build-the-project)
  - [Solution - Add project](#Solution---Add-project)
  - [Solution - Remove project](#Solution---Remove-project)
  - [Solution - List project](#Solution---List-project)
  - [Reference - Add](#Reference---Add)
  - [Reference - List](#Reference---List)
  - [Reference - Remove](#Reference---Remove)
  - [Package - Install](#Package---Install)
  - [Package - Restore](#Package---Restore)

## Code Quality

Install Coveralls plugin:

```shell
dotnet tool install -g coveralls.net --version 1.0.0
```

## Project Structure

For this project, I choose the same structure used by [Microsoft](https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli):

```console
/Solution
|__/src
   |__/Project
      |__/Folder
         |__Class01.cs
         |__Class02.cs
      |__Class.cs
      |__Project.csproj
|__/test
   |__/Project.Tests
      |__/Folder
         |__Class01Test.cs
         |__Class02Test.cs
      |__ClassTest.cs
      |__Project.Tests.csproj
```

## Environmnet Validation

| OS                                   | .NET Core SDKs | Status |
|--------------------------------------|:--------------:|:------:|
| [Windows 10](#Environment---Windows) |       2.1      |   OK   |
| macOS                                |       2.1      |    -   |
| Ubuntu  18.04                        |       2.1      |    -   |

## CLI

### Restore (packages), Clean and Build the project

```shell
dotnet restore && dotnet clean && dotnet build
```

### Run Test - All tests

```shell
dotnet test
```

### Run Test - By Priority

```shell
dotnet test --filter Priority=<PRIORITY>
```

### Run Test - By Category

```shell
dotnet test --filter TestCategory=<CATEGORY>
```

### Run Test - By class name

```shell
dotnet test --filter ClassName=<NAMESPACES>.<TEST_CLASS>
dotnet test --filter ClassName=<NAMESPACES>.<TEST_CLASS>
```

### Run Test - By test name

```shell
# Specific test name
dotnet test --filter <TEST_METHOD>
# Test name contains
dotnet test --filter Name~<TEST_METHOD>
```

### Solution - Add project

```shell
dotnet sln [<SOLUTION_NAME>] add <PROJECT> <PROJECT> ...
dotnet sln [<SOLUTION_NAME>] add <GLOBBING_PATTERN>
# Example
dotnet sln netcore-lab.sln add Lab/Lab.csproj
dotnet sln netcore-lab.sln add Lab.Tests/Lab.Tests.csproj
dotnet sln netcore-lab.sln add **/*.csproj
```

### Solution - Remove project

```shell
dotnet sln [<SOLUTION_NAME>] remove <PROJECT> <PROJECT> ...
dotnet sln [<SOLUTION_NAME>] remove <GLOBBING_PATTERN>
# Example
dotnet sln netcore-lab.sln remove Lab/Lab.csproj
dotnet sln netcore-lab.sln remove Lab.Tests/Lab.Tests.csproj
dotnet sln netcore-lab.sln remove **/*.csproj
```

### Solution - List project

```shell
dotnet sln [<SOLUTION_NAME>] list
# Example
dotnet sln netcore-lab.sln list
```

### Reference - Add

```shell
dotnet add [<PROJECT>] reference <PROJECT_REFERENCES>
# Example
dotnet add app/app.csproj reference lib/lib.csproj
dotnet add reference lib/lib.csproj
```

### Reference - List

```shell
dotnet list [<PROJECT>] reference
# Example
dotnet list app/app.csproj reference
dotnet list reference
```

### Reference - Remove

```shell
dotnet list [<PROJECT>] reference [<PROJECT>]
# Example
dotnet remove app/app.csproj reference lib/lib.csproj
dotnet remove reference lib/lib.csproj
```

### Package - Install

```shell
dotnet add [<PROJECT>] package <PACKAGE_KEY:PACKAGE_VERSION>
# Example
dotnet add Lab.Tests package MSTest.TestFramework
dotnet add package MSTest.TestFramework
```

### Package - Restore

```shell
dotnet remove [<PROJECT>] package PACKAGE_KEY:PACKAGE_VERSION>
# Example
dotnet remove Lab.Tests package MSTest.TestFramework
dotnet remove package MSTest.TestFramework
```

## Environment - Windows

```console
dotnet --info
.NET Core SDK (reflecting any global.json):
 Version:   2.1.300
 Commit:    adab45bf0c

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.15063
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Program Files\dotnet\sdk\2.1.300\

Host (useful for support):
  Version: 2.1.0
  Commit:  caa7b7e2ba

.NET Core SDKs installed:
  2.1.104 [C:\Program Files\dotnet\sdk]
  2.1.200 [C:\Program Files\dotnet\sdk]
  2.1.201 [C:\Program Files\dotnet\sdk]
  2.1.300 [C:\Program Files\dotnet\sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.0 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.0 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 2.0.6 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.0.7 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.1.0 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]

To install additional .NET Core runtimes or SDKs:
  https://aka.ms/dotnet-download
```