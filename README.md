# _Eau Claire's Salon_

#### _This page is for a hair salon to store their employees and their customers_

#### _**By Diego Serafico**_

<p align="center">
  <img src="HairSalom/wwwroot/img/dataschema.png">  
</p>

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_

## Description

_This app is for Eau Claire's Salon to keep a database of stylists they emply and the customers they serve. You can add a stylist and see their details like phone number and what clients they have. You can add a client to a specific stylist. You can also click on the client to see their details_

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* _Clone this repository to your desktop_
* _Open in text editor_
* _Create appsettings.json in /HairSalon/HairSalon directory_
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=fear_generator;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _open new terminal and run SQL ($ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In the Navigator > Administration window, select Data Import/Restore.
* _In Import Options select Import from Self-Contained File_
* _Navigate to diego_serafico.sql located on the root directory of the project_
* _Under Default Schema to be Imported To, select the New button & Enter diego_serafico as name of database_
* _Click Ok_
* _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window_
* _After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The diego_serafico database should appear._
* _In terminal, navigate into HairSalon/HairSalon/ and enter the command $ dotnet restore, to install necessary packages_
* _enter command $ dotnet build, to build program_
* _enter command $ dotnet run, to view program in your browser_
* _press ctrl or cmd and click on the localhost link_ 

## Known Bugs

* _No Delete functionality_
* _No edit functionality_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information
  
Diego Serafico: <dseraficohernandez@gmail.com> 🍃