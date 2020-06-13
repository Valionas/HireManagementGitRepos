# HireManagementGitRepos
 ASP.Net Project by Valentin Kolev
---------------------------------------------------------------------------------------------------
## 1. Roles
There are 4 roles:
 - a) Admin - has access to every part of the application
 - b) Moderator - can perform CRUD operation, can't acces Admin panel.
 - c) User - every person with successful registration. Can perform his own CRUD operations, can't access other users' publications.
 - d) Anonymous - visitors , without registration.

## 2. Layers
There are 2 main Layers
 - a) Anonymous layer - visual representation of the application.
 - b) Authenticated layer - includes the functionality of the application.

## 3. The concept 
HireManagement is an ASP.NET project which gives people the oportunity to publish work offers, just like the labour market.
It has 2 sections - Workers and Contracts. 

In the first one , users can recreate people , by publishing personal data. In the second one , just like the offers on the internet, people can browse through different options or create their own when they need a helping hand.
In both sections users can create their own contract or add their own worker on the market.
If someone else is interested in them, he can easily contact them via the email adress or phone number.
It is created for those who have their own business or want to get employeed as soon as possible.
If something happens, users can instantly contact the Admin through ContactUs tab.




## 4. Type of used security methods
- Authentication - the person must be logged in to use the functionality of the application.
- Authorization - the person must have the role to perform the action
- User protected data - the person can only modify his own publications.

## 5.Created by using
- Bootstrap
- Animate.CSS
- ASP.Net Core 3.1
- Entity Framework Core 3.1


--------------------------------------------------------------------------------------------------------
