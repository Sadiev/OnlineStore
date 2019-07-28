**Design and Implementation of Online Store**

**Description**

- Any member can register and view available products.
- Only registered member can purchase multiple products regardless of quantity.
- Contact Us page is available to contact Admin for queries.
- There are three roles available: Visitor, User and Admin.

• Visitor can view available products and register.

• User can view and purchase products.

• An Admin has some extra privilege including all privilege of visitor and user.

- Admin can add products, edit product information and add/remove
- Admin can add user, edit user information and can remove user.
- Admin can ship order to user based on order placed by sending confirmation mail.

**ONLINE STORE APPLICATION:**

Anyone can view Online Shopping portal and available products, but every user must login by his/her Username and password in order to purchase or order products. Unregistered members can register by navigating to registration page. Only Admin will have access to modify roles, by default developer can only be an &#39;Admin&#39;. Once user register site, his default role will be &#39;User&#39;.

**Web Pages details:**

**HOMEPAGE:** The Home Screen will consist of screen were one can browse through the products which we have on our website.

**PRODUCTS PAGE:** This page consists of product details. This page appears same for both visitors and users.

**Shopping cart Page:** Registered users can order desired products from here.

**Contact Us Page:** Visitors and Registered users can contact website owners or

administrators from here.

**ABOUT US PAGE:** This page describes about website and owners

**REGISTER PAGE:** New users can register here.

**LOGIN PAGE:** Login page for both users and administrators.

**ORDER VIEW FOR USER:** Once users order item they are able to see ordered products and grand total.

**PAYPAL FOR PAYMENT:** Once users orders products they are redirected to payment page.

**Admin Page:** Only difference you see in this page is Role: Admin. User and Admin role will be checked once the page was login and Session [&quot;role&quot;] will be either Admin or User. If credentials belong to Admin then role will be Admin and if credentials belong to User then role will be User.

**Success or Failed URL:** Inform user about success or failed transaction

**Data Management**

The database consists of

- Users: User and Admin information is added to database with Unique ID based on their roles.
- Shopping: Complete products information is stored in this table.
- Orders: Customer ordered products, status and delivery information is stored in this table.

**Data Objects**

**Users:** ID, UserName, Password, Email, Role, Block

**Products:** ID, Product, Cost, Category, Image, Description, Availability

**Orders:** ID, User ID, Product ID, Quantity, Price, Date, Status(Order, Shipped)