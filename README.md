# RetroGG.net
Example retro game store site written for a class, in ASP.NET Core

## Technologies Used
* .NET/C#
  * ASP.NET
    * Razor Pages
    * Blazor/Razor Components
* Docker
  * Docker Compose
* PostgreSQL (Through Docker)
* SendGrid
* Cloudflare
  * Argo Tunnels
* Node.js
  * Bootstrap 5 Beta (including Icons v1.4)

## Configure Source to Run
> Prerequisites:
> * .NET Core SDK 3.1
> * Docker
> 
> Requirements for Extra Features:
>> Switch to no-extras branch if you do not want or have access to these features.
> * SendGrid Account (for emailing capabilities)
> * Cloudflare Account (for Argo Tunnel and domain linking)
> 
> Optional:
> * Visual Studio 2019 (Windows only)
> * Docker Desktop
> * Windows Subsystem for Linux 2 (if on Windows)
> * Git
> * pgAdmin
1. Clone the repo with your preferred method.
2. Add these [user secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets): 
    ```json
    // in secrets.json through Visual Studio...
    {
        "SendGridUser": "<your username here>",
        "SendGridKey": "<your api key here>",
        "SendGridDomain": "@<your domain here>"
    }
    ```
    ```bash
    # ...or on the command line for other IDEs
    # make sure to be in the project folder (inner "RetroGG.net" folder)
    dotnet user-secrets init # init the user secrets
    dotnet user-secrets set "SendGridUser" "<your username here>"
    dotnet user-secrets set "SendGridKey" "<your api key here>"
    dotnet user-secrets set "SendGridDomain" "@<your domain here>"
    ```
3. 
If you use Visual Studio, you're done! You can hit the run button and it should work!  
Otherwise, if you're using Visual Studio Code, follow
[this tutorial](https://www.syncfusion.com/blogs/post/how-to-develop-an-asp-net-core-application-using-visual-studio-code.aspx)
for initial configuration.
> Please note that this tutorial does not cover Docker, you may have to search for VS Code support
> for Docker Compose ASP.NET projects.

If you're using some other IDE, you may have to use a combination of the .NET CLI and Docker Compose commands, or find
extensions that will take care of those for you. Good luck!

## Custom Styling with Bootstrap 5 Beta
See this [readme](RetroGG.net/bs-theming/README.md).
