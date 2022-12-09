# to start new weapi proj
    dotnet new webapi --name something
# error: NU1301: The local source '/home/yazz/.nuget/NuGet/Microsoft.EntityFrameworkCore.SqlServer' doesn't exist.
info : Package 'Microsoft.EntityFrameworkCore.SqlServer' is compatible with all the specified frameworks in project '/media/yazz/projectvolume/asp.net/on-linux/fromLinuxApi/fromLinuxApi.csproj'.
error: Value cannot be null. (Parameter 'version')
    dotnet new nugetconfig

# to install package to project
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add <proj_name> package Microsoft.EntityFrameworkCore.SqlServer

# to Scaffold-DbContext from DB to Model n ..
    dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=Basin_Hydrology;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models

# generate controller out of model
    dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name SiteController  -api -m XOKA_API_Mineral.Models.Site -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

# publishing
    dotnet publish -c Release -v n

# create new sln
    dotnet new sln

dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --table Mineral Mineral_Use Resource_Deposite Site --context-dir Data --output-dir Models


dotnet-aspnet-codegenerator -p "./ controller -name HydroSiteController -api -m Models.HydroSite -dc Basin_HydrologyContext -outDir Controllers -namespace HydroSiteController



This is the new way since mid 2018
You have to install dotnet-aspnet-codegenerator.
This is now done globally and not through a Nuget package:

PowerShell:

dotnet tool install --global dotnet-aspnet-codegenerator
Then this is how you create a REST-Controller from an existing EF Model in PowerShell:

dotnet-aspnet-codegenerator -p "C:\MyProject\MyProject.csproj" controller -name MyDemoModelController -api -m My.Namespace.Models.MyDemoModel -dc MyDemoDbContext -outDir Controllers -namespace My.Namespace.Controllers


Some helpful calls
Show available generators (-p... -h):

dotnet-aspnet-codegenerator -p "C:\MyProject\MyProject.csproj" -h
Show available options of the "controller" generator (-p... controller -h):

dotnet-aspnet-codegenerator -p "C:\MyProject\MyProject.csproj" controller -h
Generate controllers for many models in a loop
This is how you would generate REST controllers for all models in a given path from a PowerShell:
    ```pws
Get-ChildItem "F:\\fromLinuxApi\Models" -Filter *.cs | 
Foreach-Object {
    $scaffoldCmd = 
    'dotnet-aspnet-codegenerator ' + 
    '-p "F:\\fromLinuxApi\fromLinuxApi.csproj" ' +
    'controller ' + 
    '-name ' + $_.BaseName + 'Controller ' +
    '-api ' + 
    '-m fromLinuxApi.Models.' + $_.BaseName + ' ' +
    '-dc MyDemoDbContext ' +
    '-outDir Controllers ' +
    '-namespace fromLinuxApi.Controllers'

    # List commands for testing:
    $scaffoldCmd

    # Excute commands (uncomment this line):
    #iex $scaffoldCmd
}

ls ./Models | xargs -I _ dotnet-aspnet-codegenerator -p ./fromLinuxApi.csproj controller -name _.BaseName -async -nv -api -m fromLinuxApi.Models.$_.BaseName -dc Basin_HydrologyContext -outDir Controllers -namespace fromLinuxApi.controllers.${_.BaseName}


dotnet aspnet-codegenerator controller -name HydroSite -actions -nv -m fromLinuxApi.Models.HydroSite -dc Basin_HydrologyContext -outDir Controllers -namespace fromLinuxApi.Controllers

dotnet aspnet-codegenerator --project . controller -name HydroSite -m fromLinuxApi.Models.HydroSite -dc Basin_HydrologyContext -outDir Controllers 

dotnet aspnet-codegenerator controller -name HydroSiteController -actions -api -outDir Controllers


dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name MineralController  -api -m XOKA_API_Mineral.Models.Mineral -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral
dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name MineralUseController  -api -m XOKA_API_Mineral.Models.MineralUse -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral
dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name ResourceDepositController  -api -m XOKA_API_Mineral.Models.ResourceDeposit -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --context-dir DataContext --output-dir Models -t regions

dotnet aspnet-codegenerator -p XOKA_API_Mineral controller -name ZonesController  -api -m XOKA_API_Mineral.Models.Zones -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet aspnet-codegenerator -p XOKA_API_Mineral controller -name WoredasController  -api -m XOKA_API_Mineral.Models.Woredas -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name RegionsController  -api -m XOKA_API_Mineral.Models.Regions -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name CustomerController  -api -m XOKA_API_Mineral.Models.Customer -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet aspnet-codegenerator -p ./XOKA_API_Mineral.csproj controller -name RegionsController  -api -m XOKA_API_Mineral.Models.Regions -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=Basin_Hydrology;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models

dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --context-dir DataContext --output-dir Models -t Customer

dotnet ef dbcontext scaffold "server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev" Microsoft.EntityFrameworkCore.SqlServer --context-dir DataContext --output-dir Models -t Plot_Registration

dotnet aspnet-codegenerator -project XOKA_API_Mineral controller -name PlotRegistrationController  -api -m XOKA_API_Mineral.Models.PlotRegistration -dc XOKA_OROMADAContext -outDir Controllers -namespace XOKA_API_Mineral

 byte[] bytes = (byte[])GetData("SELECT Data FROM Images WHERE Id =" + id).Rows[0]["Data"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/png;base64," + base64String;

Customer
64cbe6ca-6048-4485-9532-000a1d9bf78c

