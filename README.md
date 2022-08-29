# # XLIFF 2.0 Object Model (NetStandard)
[![NuGet](https://img.shields.io/badge/nuget-2.0.0-blue)](https://www.nuget.org/packages/Xliff.OM.NetStandard)

This is an active and ongoing fork of the dead [XLIFF2-Object-Model project](https://github.com/valdisiljuconoks/XLIFF2-Object-Model)
Despite of the original one, the project supports .Net Standard, strong signed assemblies, new features and all known bugfixes.

The XLIFF 2.0 Object Model contains classes and methods for generating and manipulating XLIFF 2.0 documents as described in the [XLIFF 2.0
Standard](http://docs.oasis-open.org/xliff/xliff-core/v2.0/xliff-core-v2.0.html).
 
## Goals for this project
The localization community needs to have up-to date and maintanable XLIFF 2.0 Object model.
As the original project is not suported anymore, it seems reasonable to create a new fork and continue the further development. 

## What this project provides 
The library includes classes for all the Core elements as well as all the 
module elements as described in the standard including: 

* Core Elements (xliff, file, group, etc)
* Change Tracking Module
* Format Style Module
* Glossary Module
* Metadata Module
* Resource Data Module
* Size and Length Restriction Module
* Translation Candidates Module
* Validation Module

## Differences from the original one.

* It's .NET Standard version
* All assemblies are strong signed now
* Customized namespace are allowed for all known xliff elements
* Fixed an issue with the Note -> priority attribute and its validation.