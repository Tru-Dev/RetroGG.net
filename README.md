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
3. Add your Cloudflare Argo Tunnel certificate and config into the `cloudflared` folder.
4. Add a certificate and key for your origin and root CA in `certs`.  
   * They can be selfsigned.
   * Make sure to put the root CA cert in `cloudflared` as well.
   * You can use [this tool](https://certificatetools.com/) to generate the certs.
     * Generate the CA with the default CA settings, make sure to set your domain and DNS to localhost or your
       domain name if you have one. Change the default duration if necessary.
     * When you export the root CA make sure to mark it as persistent in addition to downloading its cert.
     * Now configure the web server certificate using the web server template, make sure to set common names
       and subject alternate names to nginx, localhost, and your domain if you have one.
     * In the CSR options, instead of CSR Only choose the domain you created the root CA under. Finally,
       generate the certificate.
> Here's an example project structure with the files introduced:
> ```
> RetroGG.net
> |   LICENSE
> |   README.md
> |   RetroGG.net.sln
> |   ...
> |
> +---certs
> |       retrogg.crt
> |       retrogg.key
> |       RootCert.crt
> |
> +---cloudflared
> |       cert.pem
> |       config.yml
> |       RootCert.crt
> |
> \---RetroGG.net
>         ...
> ```
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
