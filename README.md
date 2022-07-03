# StockSearcher 📈

<!-- ABOUT -->
## About 🤔

<p align="center">
 Application was made to search stocks from the database and from an external API using <b>Razor Pages, EntityFrameworkCore</b> and <b>Syncfusion</b>.
 Application is the result of a project from my university and was made by myself without any further knowledge about Blazor 🤷.<br/>
 The application meets the assumptions of <b>SOLID, DI</b> and <b>DRY</b>.
</p>
 
### Built With 

* C#, .NET, Blazor
* Polygon.io 
* Syncfusion

<!-- GETTING STARTED -->
## Getting started 🚀

### Prerequisites

* [Git](https://git-scm.com/) 
  * Follow the guide
    > https://github.com/git-guides/install-git
* [.NET](https://docs.microsoft.com/pl-pl/dotnet/)
  * Packages should be installed automatically, but in case they don't install nugget package manager and following packages
   - ```Microsoft.AspNetCore```
   - ```Microsoft.EntityFrameworkCore.Design```
   - ```Microsoft.EntityFrameworkCore.Tools```
   - ```Microsoft.EntityFrameworkCore.SqlServer```
* [Polygon.io](https://polygon.io/)
  * To search stocks external api is needed. It is important to register on
    > https://polygon.io/dashboard/signup
  * and put an API key in the _appsettings.json_ file or also in a better, more securate place.
* [Syncfusion](https://www.syncfusion.com/)
  * Syncfusion is a software package for creating components and frameworks for e.g. Blazor and makes developers' work easier.
  * To fully use a website without any watermarks an API key from Syncfusion is needed. You may register here
    > https://www.syncfusion.com/account/register
  * If in some way Syncfusion packages are not loaded, you need to install these ones
   - ```Syncfusion.Blazor.Buttons```
   - ```Syncfusion.Blazor.DropDowns```
   - ```Syncfusion.Blazor.Grid```
   - ```Syncfusion.BlazorNavigations```
   - ```Syncfusion.Blazor.StockChart```
   - ```Syncfusion.Themes```

### Important!
**API is connected to my database by default and to set up yours you need to change ConnectionString in the file _appsettings.json_**

<br/>

### Installation

1. Use your command line and clone the repository:

 ```
 git clone https://github.com/xDejw/StockSearcher.git
```

 
2. Go to the clonned folder: 
```
cd StockSearcher
```
3. Open the repository in any development environment

<br/>

<!-- HOW DOES IT WORK-->
## How does it work 📔

  Application creates a stock tickers database for all of the current companies and stores the instances for passing them to the application user.
  Application also creates individual accounts for all the users and allows them to save their searched stocks in the watchlist.

<br/>

<!-- VISUALIZATION AND GUIDE -->
## Visualization 📸 and a guide 📙

  _Website redirect the user on start to the home page containing sideabar and a navbar with links to log in and to my Github profile._

![image](https://user-images.githubusercontent.com/74014874/175778658-35526d3c-f767-4bec-9fe9-45e0ac93ada8.png)

  _There are also images for register and login redirects._
  
![image](https://user-images.githubusercontent.com/74014874/175778698-e20f28e9-9fde-421b-87fc-4de8bfd7dff8.png)
![image](https://user-images.githubusercontent.com/74014874/175778725-eb5f78c4-1300-4917-bb46-ce77a693d401.png)

  _After we are logged in we can freely use all the functionalities of the page. We may enter a dashboard and select a stock from the list._
  
![image](https://user-images.githubusercontent.com/74014874/175778757-ce1415ee-4d41-42f6-859f-4a9d839b50d1.png)

  _There it is. We can read a basic information about the stock, check the description, add to private watchlist, check stock and pick date or search through newest articles._ 
  
![image](https://user-images.githubusercontent.com/74014874/175795831-f2c7b882-78a0-4ee0-a356-4d99ea15b936.png)
![image](https://user-images.githubusercontent.com/74014874/175795894-21ef0a17-ffb5-414e-beec-6908273533ef.png)
 
 _And of course the watchlist with all added stocks_

![image](https://user-images.githubusercontent.com/74014874/175795865-3d984da1-4f71-426c-a767-822d5db2da18.png)

<br/>

<!-- CONTRIBUTING -->
## Contributing :heart:

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

<br/>

<!-- LICENSE -->
## License :page_facing_up:

Copyright 2022 xDejw

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

> http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

<br/>

<!-- CONTACT -->
## Contact ☎

dawidwrobelx@gmail.com

Project Link: [https://github.com/xDejw/StockSearcher](https://github.com/xDejw/StockSearcher)
