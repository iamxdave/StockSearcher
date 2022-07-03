# StockSearcher

Application was made to search stocks from the database and from an external API using Razor Pages, EntityFrameworkCore and Syncfusion models.
<br>
<br>
Application is the result of a project from my university and was made by myself without any further knowledge about Blazor.</a>.app</a>.
<br>
<br>
<b>The application meets the assumptions of SOLID, DI and DRY</b>.
<hr>

## How does it work

  Application creates a stock tickers database for all of the current companies and stores the instances for passing them to the application user.
  Application also creates individual accounts for all the users and allows them to save their searched stocks in the watchlist.
  
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

  _Here is another example._
  
![image](https://user-images.githubusercontent.com/74014874/175795846-4325fc84-e16a-4958-befe-a25a1898691b.png)
![image](https://user-images.githubusercontent.com/74014874/175795860-7978e56b-25c2-42e9-8d46-d9f5d44e68a4.png)
 
 _And of course the watchlist with all added stocks_

![image](https://user-images.githubusercontent.com/74014874/175795865-3d984da1-4f71-426c-a767-822d5db2da18.png)


_*API is connected to my database by default and to set up yours you need to change ConnectionString in the file appsettings.json*_

