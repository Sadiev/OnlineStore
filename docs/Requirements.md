#ONLINE STORE APPLICATION

**Web Pages details:**

Feature **Master Page
	A master page provides a template for other pages, with shared layout and functionality.
	The master page defines placeholders for the content, which can be overridden by content pages.
	The output result is a combination of the master page and the content page.
	The content pages contain the content you want to display.

Feature: **HOMEPAGE 
	The Home Screen will consist of the screen where one can browse through the products which we have on our website.
	HOMEPAGE should display a fixed number of products on a page by applying LINQ queries to the collection of products objects retrieved from the database.

Rule *Any user can view available products.

Scenario: Paging
    Given 100 products in the database
    When user open the homepage it supposes to show 10 products per page
    Then paging pages with navigation panel on the bottom of the page.

Scenario: Format listing products
    Given Product Nameame, Product Description, picture and price
    When user click on the Product Name 
    Then open the product's details	

Feature: **PRODUCTS PAGE 
	This page consists of product details. This page appears the same for both visitors and users.

Scenario: Purchase products
    Given Visitor and Registered users
    When Registered users open PRODUCT PAGE  
    Then they have the privilege to add the product to Shopping cart
	But Visitors have to register first
	
Rule *Visitor can view available products and register.	
	
Feature: **Shopping cart Page
	Registered users can order desired products from here.

Scenario: Order items
    Given button add to cart will be displayed next to each item in the catalog
    When user Clicking on it
    Then result in a summary of the items that have already been selected by the user, including their total cost.
	And user to buy or remove a product from the list
	At this point, the user can return to the product catalog with a button of the continue purchase,
	and with a button continue order - create an order and complete the purchase session.
	
Scenario Remove an item from the cart
	when user click remove the item
	then remove the item from the list of cart
	and update the total amount
	
Rule *Only registered member can purchase multiple products regardless of quantity.
	 *Add "Remove" button for each item in the cart
	
Feature: **Contact Us Page
Visitors and Registered users can contact website owners or administrators from here.

Scenario send message to the administrators
Given contact us Page
When User enters following credentials and submit
|Name         |Shod           |
|email        |test@test.com  |
|Message      |text           |
Then ‘Thank you to contact us’ message should be displayed
	

Rule *Contact Us page is available to contact Admin for queries.

Feature: **ABOUT US PAGE
	This page describes about website and owners

Feature: **REGISTER PAGE
	New users can register here.
	
Scenario register a new user
		Given empty fields First name, Middle Name, Last Name email as a login and password(confirm password)
		when user fill up all fields and click submit
		then send an email to the user to confirm user's email
		
Rule *Registred User can view and purchase products.
		Unregistered members can register by navigating to registration page.
		Once user register site, his default role will be User.

Feature: **LOGIN PAGE
	Login page for both users and administrators is the same

Rule *There are three roles available: Visitor, User and Admin.
	Anyone can view Online Shopping portal and available products, 
	but every user must login by his/her Username and password in order to purchase or order products.

Feature: **ORDER VIEW FOR USER
	when users order item 
	then they are able to see ordered products and total amount.

Feature: **PAYPAL FOR PAYMENT
	Once users orders products they are redirected to payment page.

Feature **Admin Page
	Only difference you see in this page is Role: Admin. 
	User and Admin role will be checked once the page was login and Session role will be either Admin or User.
	If credentials belong to Admin then role will be Admin and if credentials belong to User then role will be User.

Role *An Admin has some extra privilege including all privilege of visitor and user.
		- Admin can add products, edit product information and add/remove
		- Admin can add user, edit user information and can remove user.
		- Admin can ship order to user based on order placed by sending confirmation mail.
		- Only Admin will have access to modify roles, by default developer can only be an Admin;.

Feature **Success or Failed URL
	Inform user about success or failed transaction








**Data Management**

The database consists of

- Users: User and Admin information is added to database with Unique ID based on their roles.
- Shopping: Complete products information is stored in this table.
- Orders: Customer ordered products, status and delivery information is stored in this table.

**Data Objects**

**Users:** ID, UserName, Password, Email, Role, Block

**Products:** ID, Product, Cost, Category, Image, Description, Availability

**Orders:** ID, User ID, Product ID, Quantity, Price, Date, Status(Order, Shipped)