# C/AL Open Library

The purpose of this repository is to build a C/AL library based on community contributions that will serve as an accelerator for adoption of the Extensions V2 technology. The source code from this library will be included in the base application of 'Dynamics 365 for Financials' on a monthly basis. 

The primary goal is to enable creation of .NET type wrappers written in C/AL that can then be subsequently used from Extensions V2. DotNet types must not be part of the definition of public functions in the submitted code to be callable by Extensions V2.

All contributions will be reviewed by Microsoft and assessed for the overall fit into the product, for reusability and for following the general coding style that is present in the other base application objects.

# Process

1. Code for this library should be written using the existing development environment (C/SIDE).
2. Object IDs should be created within the range 50K-99K.
3. Microsoft will review the contribution and decide whether it wants to make it part of the product.
4. If the contribution is accepted Microsoft will modify the object IDs to fit within the base Microsoft range and apply any code fixes resulting from internal best practice checks.
5. The code will be included in the next monthly update that is shipped after the contribution was accepted.

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
