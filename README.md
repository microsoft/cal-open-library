
# C/AL Open Library

The purpose of this repository is to build a C/AL library based on community contributions that will serve as an accelerator for adoption of the Extensions V2 technology. The source code from this library will be included in the base application of 'Dynamics 365 for Financials' on a monthly basis. 

The primary goal is to enable creation of .NET type wrappers written in C/AL that can then be subsequently used from Extensions V2. DotNet types must not be part of the definition of public functions in the submitted code to be callable by Extensions V2.

All contributions will be reviewed by Microsoft and assessed for the overall fit into the product, for reusability and for following the general coding style that is present in the other base application objects.

# Process

1. Make the Pull Requests granular. Don't bundle together many different requests. 
2. Code for this library should be written using the existing development environment (C/SIDE).
3. Object IDs should be created within the range 50K-99K.
4. In general we only accept codeunit objects. If you have a  strong reason for another object type it is recommended to discuss it with Microsoft through an Issue first, before submitting the code.
5. **All code needs to be submitted with accompanying unit tests.**
6. Microsoft will review the contribution and decide whether it wants to make it part of the product.
7. If the contribution is accepted Microsoft will modify the object IDs to fit within the base Microsoft range and apply any code fixes resulting from internal best practice checks.
8. The code will be included in the next monthly update that is shipped after the contribution was accepted.

# Guidelines

Range: 3000..3999
Name: DotNet_(dotnet assemblyname)

Best practices:
* Add the dotnet assembly as a global, prefix the name with DotNet
* There should be only 1 global
* The signature of every function should match the signature of the corresponding .NET method
    * Exception: Return values can be VAR parameters.
* You cannot not take a dependency on the BaseApp
    * i.e. The 3000 range must be compilable in a new empty database
* Don't add helpers to the wrappers. Isolate type helper functions in codeunits of their own.
    * Small helpers can be added in the 3750..3999 range. These should not be large functions with logic but rather small helpers that make it easier to use the wrapper functions. Logic should be placed in normal BaseApp as usual.
* Add a Get(dotnet)
    * This is a global function
    * This is NEVER an external function
    * It has 1 parameter
        * Has the same name as the global but with a '2' appended
        * Is a VAR
* Add a Set(dotnet)
    * This is a global function
    * This is NEVER an external function
    * It has 1 parameter
        * Has the same name as the global but with a '2' appended
        * Is a VAR
* All functions in the wrapper are global
* If a function is SAFE, it is made External
    * The same rules apply for internal/external as for everything else
    * The internal/external is meant to protect tenants from each other
    * The internal/external is meant to protect our service
        * No file access is allowed!
* Except for the Get and Set functions, no dotnet is allowed as parameters
    * If a function requires a dotnet parameter:
        * the dotnet variable is added as a local
        * The wrapper for the dotnet is added as a parameter (i.e. codeunit parameter)
        * The dotnet variable is retrieved from the the codeunit parameter by using the Get method
    * If a function returns a dotnet variable:
        * The dotnet variable is added as a local
        * The wrapper for the dotnet is added as a VAR parameter
        * The dotnet variable is set in the wrapper by using the Set method. 

# Contributing

This project welcomes contributions and suggestions. Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
