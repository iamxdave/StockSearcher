<h1 align="center">StockSearcher 📈</h1>
<p align="center">
 Application was made to search stocks from the database and from an external API using <b>Razor Pages, EntityFrameworkCore</b> and <b>Syncfusion</b>.
 The application meets the assumptions of <b>SOLID, DI</b> and <b>DRY</b>.
</p>
<br/>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents :page_with_curl:</h2></summary>
  <ol>
    <li>
      <a href="#about-">About 🤔 </a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started-">Getting started 🚀</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#how-does-it-work-">How does it work 📔</a></li>
    <li><a href="#contributing-heart">Contributing ❤️</a></li>
    <li><a href="#license-">License 📝</a></li>
    <li><a href="#contact-">Contact ☎</a></li>
  </ol>
</details>

<!-- ABOUT -->
## About 🤔
Application is the result of a project from my university and was made by myself without any further knowledge about Blazor 🤷.<br/>



### Built With 

* [C#](https://pl.wikipedia.org/wiki/C_Sharp), [.NET](https://docs.microsoft.com/pl-pl/dotnet/), [Blazor](https://docs.microsoft.com/pl-pl/aspnet/core/blazor/?view=aspnetcore-6.0)
* [Polygon.io](https://polygon.io/)
* [Syncfusion](https://www.syncfusion.com/)

<br/>

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

**API is connected to my database by default and to set up yours you need to change ConnectionString in the file _appsettings.json_**<br/>



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
<p>
  Application creates a stock tickers database for all of the current companies and stores the instances for passing them to the application user.
  Application also creates individual accounts for all the users and allows them to save their searched stocks in the watchlist.
</p>
  

<br/>

<!-- VISUALIZATION AND GUIDE -->
## Visualization 📸 and a guide 📙

  _Website redirect the user on start to the home page containing sideabar and a navbar with links to log in and to my Github profile._

![Home](https://user-images.githubusercontent.com/74014874/177059896-fdf78d1f-d73a-4b1f-9713-3db8c2f75351.png)

  _There are also images for register and login redirects._
  
![Register|Login](https://user-images.githubusercontent.com/74014874/177060318-a37aab3c-b824-4be8-a3d3-edd6454e0305.png)

  _After we are logged in we can freely use all the functionalities of the page. We may enter a dashboard and select a stock from the list._

![Dashboard](https://user-images.githubusercontent.com/74014874/177060019-873e4931-7c6c-4199-9bfd-20734445771e.png)

  _There it is. We can read a basic information about the stock, check the description, add to private watchlist, check stock and pick date or search through newest articles._ 

![Details-Top](https://user-images.githubusercontent.com/74014874/177060035-58b4a95f-1dae-43b4-90d1-0f09a2596dfc.png)
![Articles](https://user-images.githubusercontent.com/74014874/177060058-6b0a4af1-a47b-4bb8-9b29-a5a0f7b69a74.png)

 _And of course the watchlist with all added stocks_

![Watchlist](https://user-images.githubusercontent.com/74014874/177060068-54c75e49-892b-4958-8cca-ed13a25ff9d1.png)

<br/>

<!-- CONTRIBUTING -->
## Contributing :heart:
<p> 
 Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.
</p>

<br/>

<!-- LICENSE -->
## License 📝
<p> 
 Copyright 2022 xDejw

 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at
</p>

> http://www.apache.org/licenses/LICENSE-2.0

<p> 
 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
</p>
<br/>

<!-- CONTACT -->
## Contact ☎

dawidwrobelx@gmail.com

Project Link: [https://github.com/xDejw/StockSearcher](https://github.com/xDejw/StockSearcher)
