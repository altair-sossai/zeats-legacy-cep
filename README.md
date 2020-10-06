<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-cep

Extensions to solve common problems when working with brazilian CEP

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-cep?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=26&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.CEP.svg)](https://www.nuget.org/packages/Zeats.Legacy.CEP)

## Installation

```PM>
Install-Package Zeats.Legacy.CEP
```

## Extensions

### CepHelper.IsValid(string cep)
Returns true if it is a valid cep
```c#
CepHelper.IsValid("13617540") /* returns true */
CepHelper.IsValid("1361754x") /* returns false */
```
---

### CepHelper.Format(string cep)
Formats as CEP
```c#
CepHelper.Format("13617540") /* returns "13.617-540" */
CepHelper.Format("Lorem Ipsum") /* returns "Lorem Ipsum" */
```
---
