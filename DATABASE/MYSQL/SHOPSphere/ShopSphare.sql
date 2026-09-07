Create database ShopSphere;

Use ShopSphere;

Create Table Customers(Customer_ID int primary key auto_increment,
  First_Name varchar(20) not null ,Middle_Name varchar(20) default Null,Last_Name varchar(20) not null,
  Phone_number varchar(20) unique not null,Alter_phonenumber varchar(20) unique default null, Email varchar(100) unique not null,Date_Of_Birth date not null,
  Country_Code Char(4),Status varchar(20) default "Not verified",Verified_Status varchar(20) default "Not verified",
  Account_Created_Time datetime default current_timestamp,Last_updated datetime default current_timestamp on update current_timestamp,Last_Login_Date datetime default null);

Insert into Customers(First_Name,Middle_Name,Last_Name,Phone_Number,Email,Date_Of_Birth,Country_Code) values(
  "Naveen","Kumar","Kola","9087123465","Kolanaveen797@gamil.com","2005-07-12","+91")

  select * from `Customers`;

desc `Customers`;

create table Customers_Addresses(Address_ID int primary key auto_increment,
  Customer_ID int not null,Address_line1 varchar(30) not null,
  Address_line2 varchar(30) default null,Land_Mark varchar(20) default null,City varchar(30) not null,State varchar(20) not null,
  Pin_code char(10) not null,Country_code char(5) default null,Receipient_Name varchar(30) not null,
  Receipient_Phone varchar(12) not null, Is_default boolean default false,CreateD_Time datetime default current_timestamp,Updated_Time datetime  default current_timestamp on update current_timestamp ,
  foreign key (Customer_ID) references Customers(Customer_ID));

insert into `Customers_Addresses`(Customer_ID,Address_line1,Address_line2,
  Land_Mark,City,State,Pin_code,Country_code,Receipient_Name,Receipient_Phone) values(
  1,"Mainroad","opposite temple","School","Ongole","Andhra pradesh","523211","+91","Naveen","78945632")

  select Address_line1,address_line2,land_mark,state,city,pin_code from `Customers_Addresses` where Customer_ID=1;

create Table Sellers (Seller_ID int primary key auto_increment,
  Business_Name varchar(50) not null,
  Ownwer_first_Name varchar(20) not null,
  Owner_Middle_Name varchar(30) default null,Owner_Last_Name varchar(30) not null,
  Email varchar(40) unique not null,Phone_Number varchar(12) unique not null,
  Alter_PhoneNo varchar(12),
  Business_Registration varchar(30) unique not null ,Seller_Status varchar(20) default "Offline",
  Verification_Status varchar(30) default "Not verified",
  create_Time datetime default current_timestamp,
  updated_time datetime default current_timestamp on update current_timestamp,
  Last_Login datetime default null);
Insert into Sellers(Business_Name,Ownwer_first_Name,Owner_Last_Name,
  Email,Phone_Number,Business_Registrations) values("PVC pipes","Naveen","Kola","kola@gmail.com","8528515155","uv_1");

select * from Sellers;
Create Table Sellers_Address(Address_ID int primary key auto_increment,Seller_ID int not null,
  Addreess_Type varchar(20) default "Business" ,Address_line1 varchar(110) not null,
  Address_line2 varchar(100) not null,Land_Mark varchar(30) not null,City varchar(20) not null,
  State varchar(20) not null,pincode varchar(10) not null,Contact_Name varchar(30),Contact_Phone varchar(12), Country_Code Char(4) not null,
  Created_Date datetime default current_timestamp,Updated_Date datetime default current_timestamp on update current_timestamp,
  foreign key (Seller_ID) references `Sellers`(seller_ID));
insert into Sellers_Address(Seller_ID,Address_line1,Address_line2,Land_Mark,City,State,pincode
  ,Contact_Name,Contact_Phone,Country_Code) values(1,"Ongole main road","opposite power office"
  ,"Near school","ongole","AP","523211","Raghu","6781234567","+91")

select * from `Sellers_Address`;

create Table Admin(Admin_Id int primary key auto_increment,Role_ID int not null,First_Name varchar(20) not null,
  Middle_Name varchar(30) default null,Last_Name varchar(30) not null,Email varchar(30) unique not null,
  Phone_Number varchar(12) unique not null,password varchar(40) not null,Account_Status varchar(20) default "Deactive",
  Created_Date datetime default current_timestamp,Updated_Date datetime default current_timestamp on update current_timestamp);

Insert into Admin (Role_ID,First_name,Last_name,Email,Phone_number,password) values(1,"Naveen","kola","kola@gmail.com","9632587415","pass@123");

Create Table Roles(Role_ID int unique not null primary key,Role_Name varchar(20) unique not null);

insert into Roles values(1,"SuperAdmin");

Insert into Roles values(2,"CustomerSupport");

Create table Permissions(Permission_Id int auto_increment primary key,permission_Name varchar(20) unique);

INSERT into `Permissions`(permission_Name) values("ViewCustomers")

INSERT into `Permissions`(permission_Name) values("DELETE CUSTOMER")
Create Table Role_permission(Role_ID int not null ,Permission_ID int not null);

Insert Into `Role_permission` values(1,2);
insert into `Role_permission` values(2,1);
select * from `Role_permission`;

Create Table Categories (Categorie_ID int auto_increment primary key,Categorie_Name varchar(40) unique not null)

Insert into `Categories`(Categorie_Name) values("Electronics");

Create Table Brands(Brand_Id int auto_increment primary key,Categorie_ID int not null,Brand_Name varchar(40) unique not null,
  foreign key(Categorie_ID) references `Categories`(Categorie_ID))

Insert Into `Brands`(Categorie_ID,Brand_Name) values(1,"Apple");


Create Table Products(Product_ID int auto_increment primary key,Brand_ID int not null,Product_Name varchar(40) unique not null,
  Launch_Date datetime default null,Created_Date datetime default current_timestamp,
  updated_Time datetime default current_timestamp on update current_timestamp, foreign key (Brand_ID) references Brands(Brand_ID));


Insert into Products(Brand_ID,Product_Name)values(1,"IPhone")
  
create table Product_Variants(Variant_ID int auto_increment primary key,Product_Id int not null,
  Variant_Name varchar(40)  not null,SKU varchar(40) unique not null,color varchar(20) default null,
  storage varchar(20) default null,Size varchar(20) default null,created_Date datetime default current_timestamp,
  updated_date datetime default current_timestamp on update current_timestamp ,
  foreign key (Product_Id) references `Products`(product_ID))

insert into `Product_Variants`(Product_Id,Variant_Name,SKU,color,storage) values(
  1,"256 Blue","ipf-1092x","Blue","128GB"
)
select *from `Product_Variants`;

Create Table Product_Image(Image_ID int auto_increment primary key,Product_Id int not null,
  Image_Name varchar(30) not null,Image_Location varchar(100) not null,Display_order int not null,
  Is_primary boolean default false,created_Date datetime default current_timestamp,updated_date datetime default current_timestamp,
  foreign key (`Product_Id`) references `Products`(`Product_Id`));

Insert into `Product_Image`(Product_ID,Image_Name,Image_Location,Display_Order,Is_primary) values(
  1,"Front_full_photo","C:\Users\Naveen\Desktop\Naveen\10th.jpeg",1,TRUE)

select *from `Product_Image`;

Create Table product_category(Product_Id int not null ,
  Categorie_ID int not null ,
  created_Date datetime default current_timestamp,foreign key(Product_Id) references Products(Product_Id),
  foreign key (Categorie_ID) references Categories(Categorie_ID))

insert into product_category(Product_ID,Categorie_ID) values(1,1);

select * from product_category;

Create table Inventory (Inventory_Id int auto_increment primary key,Variant_ID int unique not null,
  Quantity_On_Hand int not null,Reserved_Quantity int not null,Reorder_Level int not null,
  created_Date datetime default current_timestamp,update_Date datetime default current_timestamp on update current_timestamp,
  foreign key (Variant_ID) references Product_Variants(Variant_ID))

Create table Inventory_movements(Movement_ID int auto_increment primary key,Inventory_ID int not null,
  Moment_Type varchar(30) not null,Quantity int not null,Reason varchar(30) not null,
  reference_ID int,Created_Date datetime default current_timestamp, foreign key (Inventory_ID) references `Inventory`(Inventory_Id))

  Create table Cart (Cart_ID int auto_increment primary key,Customer_ID int not null unique,
  created_Date datetime default current_timestamp,updated_Date datetime default current_timestamp on update current_timestamp,
  foreign key (Customer_ID) references `Customers`(Customer_ID));

  Create table Cart_Items(cart_Item_ID int auto_increment primary key,Cart_ID int not null,
    Variant_ID int not null,Quantity int not null,Added_Date datetime default current_timestamp,
    updated_date datetime default current_timestamp on update current_timestamp,
    foreign key (Variant_ID) references `Product_Variants`(Variant_ID),foreign key (Cart_ID) references `Cart`(Cart_ID));

Create table Wishlists(Wishlist_ID int auto_increment primary key,Customer_ID int not null,
  Wishlist_Name varchar(30) not null,created_Date datetime default current_timestamp,
  updated_date datetime default current_timestamp on update current_timestamp,
  foreign key (Customer_ID) references `Customers`(Customer_ID))

create table Wishlist_Items(wishlist_Item_ID int auto_increment primary key,
  Wishlist_ID int not null,Variant_ID int not null,Added_Date datetime default current_timestamp,
  foreign key (wishlist_ID) references `Wishlists`(Wishlist_ID),foreign key (Variant_ID) references `Product_Variants`(Variant_ID),
  unique(Wishlist_ID,Variant_ID))

create table Orders(Order_ID int auto_increment primary key,Customer_ID int not null,order_Date datetime
   default current_timestamp,order_Status varchar(40) default "Pending", Total_Amount decimal(10,3) not null,Shipping_Amount decimal(10,3) default 0 not null,Discount_Amount decimal(10,3) not null default  0,
  Final_Amount decimal(10,3) not null,Created_Date datetime default current_timestamp,Updated_Date datetime default current_timestamp on update current_timestamp,
  foreign key (Customer_ID) references `Customers`(Customer_ID));

create table Order_Items(OrderItem_ID int auto_increment primary key,Order_ID int not null,
  Variant_Id int not null,Quantity int not null,Unit_Price decimal(10,3) not null,Discount_Amount decimal(10,3) default 0,
  SubTotal decimal(10,3) default 0,Created_Date datetime default current_timestamp,
  foreign key (Order_ID) references Orders(Order_ID) ,foreign key (Variant_ID) references `Product_Variants`(Variant_ID));

Create table Order_status_History(Status_History_ID int auto_increment primary key,
  Order_ID int not null,order_Status varchar(40) default "Pending",status_changed_Date datetime default current_timestamp,
  Changed_By varchar(50) default "Seller",Remarks varchar(100) ,foreign key(Order_ID) references `Orders`(Order_ID));

Create table Payments(Payment_ID int auto_increment primary key,
  Order_ID int not null,Payment_Method varchar(40) default "UPI",Payment_Status varchar(40) default "Pending",
  Amount decimal(10,3),Currency varchar(20) not null,Created_Date datetime default current_timestamp,
  updated_date datetime default current_timestamp on update current_timestamp,
  foreign key (Order_ID) references `Orders`(Order_ID));

Create table Payment_Transaction (Transaction_ID int auto_increment primary key,Payment_ID int not null,
  Transaction_Reference varchar(100) not null,Tranction_Type varchar(30) not null,
  Transaction_Status varchar(50) default "Pending", Amount decimal(10,3) ,Transaction_Date datetime default current_timestamp,
  foreign key (Payment_Id) references `Payments`(Payment_ID));

Create Table Refunds(Refund_ID int auto_increment primary key,Payment_ID int not null,
  Order_ID int not null,Refund_Amount decimal(10,3) not null,Refund_Reason varchar(150) not null,
  Refund_Status varchar(30) default "Pending",Refund_Date datetime default current_timestamp,
  foreign key(Payment_Id) references `Payments`(Payment_ID) ,foreign key (Order_ID) references `Orders`(Order_ID));


Create table Shipment_Methods(Shipment_method_ID int auto_increment primary key,
  Method_Name varchar(40) not null,Description varchar(100) not null,Estimate_Delivery_Days int not null,
  Shiping_Cost decimal(10,3) default 0,Status varchar(20) default "Active",created_Date datetime default current_timestamp,
  updated_Date datetime default current_timestamp on update current_timestamp)

Create table Shipments(Shipment_ID int auto_increment primary key,Order_ID int not null,
  Shipment_method_ID int not null,Shipment_Status varchar(20) not null,Tracking_Number varchar(40) not null,
  Shipped_Date datetime default null,Estamated_Delivery_Date datetime default null,Delivery_Date datetime default null,
  Created_Date datetime default current_timestamp,Updated_date datetime default current_timestamp on update current_timestamp,
  foreign key (Order_ID) references `Orders`(Order_ID),foreign key (Shipment_method_ID) references `Shipment_Methods`(Shipment_method_ID))

Create table Delivery_Tracking(Tracking_ID int auto_increment primary key,
  Shipment_ID int not null,Tracking_Status varchar(30) not null,location varchar(50) default null,
  Description varchar(50) default null,Tracking_Date datetime default current_timestamp,
  foreign key (Shipment_ID) references Shipments(Shipment_ID))

create table Coupons (coupone_ID int auto_increment primary key,Coupone_Code varchar(40) unique not null,
  Description varchar(120) default "This is the coupone",Discount_Type varchar(40) not null,
  Discount_Value int default 0,
  Minimum_Order_Amount decimal(10,3) default 0 ,Max_Discount_Amount decimal (10,3) default 0,
  Start_Date datetime default current_timestamp,End_date datetime not null,usage_limt int default 1000,percustomer_Limit int default 1,
  Coupone_Status varchar(40) default "Active",Created_Date datetime default current_timestamp,
  updated_Date datetime default current_timestamp on update current_timestamp ,check(Start_Date<=End_date))


create table Coupone_Usage (Usage_ID int auto_increment primary key,Coupone_ID int not null,Customer_ID int not null,
  order_ID int unique not null,Discount_Amount decimal(10,3) default 0,used_Date datetime default current_timestamp,
  foreign key(Coupone_ID) references `Coupons`(coupone_ID),foreign key (order_ID) references `Orders`(Order_ID),foreign key (Customer_ID) references `Customers`(Customer_ID));

create table customer_Feedback(Feedback_ID int auto_increment primary key,Customer_ID int not null,
  Product_ID int not null,Order_ID int not null,Ratings int check(Ratings between 1 And 5) default null,Review varchar(30) default null,
  FeedBack_Status varchar(40) not null,Created_Date datetime default current_timestamp,Updated_date datetime default current_timestamp on update current_timestamp,
  foreign key (Customer_ID) references `Customers`(Customer_ID),foreign key (Product_ID) references `Products`(Product_ID),
  foreign key (Order_ID) references `Orders`(Order_ID),unique(Customer_ID,Order_ID,Product_ID))

create table Returns (return_ID int auto_increment  primary key,Order_ID int not null,Customer_ID int not null,
  Return_status varchar(30) default "Requested",Return_Reason varchar(100) not null,
  Return_Date datetime default null,Approved_Date datetime default null,completed_Date datetime default null,Created_Date datetime default current_timestamp,
  Updated_Date datetime default current_timestamp on update current_timestamp,
  foreign key (Order_ID) references `Orders`(Order_ID),foreign key (Customer_ID) references `Customers`(Customer_ID));

Create table Return_Item (Return_Item_ID int auto_increment primary key,Return_ID int not null,
  OrderItem_ID int not null,Quantity int not null,Item_reason varchar(30) not null,Item_Status varchar(30) not null,
  Create_Date datetime default current_timestamp ,Updated_Time datetime default current_timestamp on update current_timestamp,
  foreign key (Return_ID) references `Returns`(Return_ID),foreign key (OrderItem_ID) references `Order_Items`(OrderItem_ID));

Create table Users(User_ID int auto_increment primary key,Email varchar(50) not null unique,
  password_Hash varchar(255) not null,User_Type varchar(20) not null,Account_Status varchar(30) default "Active",
  Last_Login datetime default null,Created_Date datetime default current_timestamp,Updated_Date datetime default current_timestamp on update current_timestamp);

Create table Notifications(Notification_ID int auto_increment primary key,User_ID int not null,
  Notification_Type varchar(30) not null,Title varchar(30) not null,
  Message varchar(100) not null,Is_Read boolean default false,Created_Date datetime default current_timestamp,
  Read_Date datetime default null,foreign key(User_ID) references Users(User_ID))

Create table Audit_Logs(Audit_ID int auto_increment primary key,
  Actor_ID int not null,Actor_Type varchar(30) not null,Action varchar(50) not null,Table_Name varchar(30) not null,
  Record_ID int not null,Old_Value  varchar(30) default null,New_Value varchar(30) default null,Action_Date datetime default current_timestamp,
  Description varchar(255) not null ,foreign key (Actor_ID) references `Users`(User_ID))


