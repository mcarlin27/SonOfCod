# Son of Cod Seafood

#### _App created for Epicodus .NET Week 2 Independent project, using ASP.NET, with a focus on testing and user authentication. 8/10/2017_

#### By **Marilyn Carlin**

## Description

_A web application for a seafood company, Son of Cod Seafood, that allows users to sign up for the Son of Cod newsletter. Authenticated admin users can also Create, Edit, and Delete products from the site._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows users to view a landing page.  | Home  | "Welcome" |
| The program allows users to view all products.  | View all Products  | Products Page |
| The program allows users to view a product detail page.  | User Clicks on Product  | Product Detail Page |
| The program allows users to view a marketing page.  | Marketing/About  | About Page |
| The program allows users to sign up for a mailing list.  | Mailing List Sign Up  | "Enter your information" |
| The program allows authenticated users to view all newsletter recipients.  | /Recipients  | List View of Recipients |
| The program allows authenticated users to edit newsletter recipient info.  | /Recipients/Edit  | Form for editing |
| The program allows authenticated users to delete newsletter recipient info.  | /Recipients/Delete  | Delete Confirmation Page |
| The program allows authenticated users to Create/Edit/Delete Products  | Admin Portal  | Product is added/edited/deleted |
| The program allows authenticated users to delete their account.  | /Account/Delete  | Delete Confirmation Page |

**STRETCH GOALS**
1. Add SASS to mimic [Pacific Seafood](https://www.pacificseafood.com/landing)
2. Use JS Library (maybe D3) to map Newsletter Recipient Data.

## Setup/Installation Requirements

**Requirements**

If you do not have Visual Studio 2017, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

**Cloning From GitHub:** Download or clone project repository onto desktop from GitHub.

Open the project in Visual Studio.

**Migrations**
1. In Solution Explorer, right-click the project and choose 'Open in File Explorer' from the context menu.
2. Enter "cmd" in the address bar and press Enter.
3. Enter the following command in the command window:
  - dotnet ef database update
4. Open scripts.sql in SSMS and execute (this will add sample data).
5. Back in VS, click IIS Express at the top of the window. Project should open in a new window in your default browser.

## Known Bugs

_No known bugs._

## Support and contact details

_Please contact Marilyn Carlin at marilyn.s.carlin@gmail.com with any questions, comments, or concerns_

## Technologies Used

**Languages:** HTML, CSS, C#, ASP.NET

**IDE:** Visual Studio 2017

**Database Management:** MySQL (SSMS)

### License

*MIT license Agreement*

Copyright (c) 2017 **_Marilyn Carlin_*
