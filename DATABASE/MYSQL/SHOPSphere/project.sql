Create database ShopSphere;

Use ShopSphere;

Create Table Customers(Customer_ID int primary key auto_increment,
  First_Name varchar(20) not null ,Middle_Name varchar(20) default Null,Last_Name varchar(20) not null,
  Phone_number varchar(20) unique not null,Alter_phonenumber varchar(20) default null, Email varchar(100) unique not null,Date_Of_Birth date not null,
  Country_Code Char(4),Status varchar(20) default "Not verified",Verified_Status varchar(20) default "Not verified",
  Account_Created_Time datetime default current_timestamp,Last_updated datetime default current_timestamp on update current_timestamp,Last_Login_Date datetime default null);

Insert into Customers(First_Name,Middle_Name,Last_Name,Phone_Number,Email,Date_Of_Birth,Country_Code) values(
  "Naveen","Kumar","Kola","9087123465","Kolanaveen797@gamil.com","2005-07-12","+91")

  select * from `Customers`;
)



create table Customers_Addresses(Address_ID int primary key auto_increment,
  Customer_ID int not null,Address_line1 varchar(30) not null,
  Address_line2 varchar(30) default null,Land_Mark varchar(20) default null,City varchar(30) not null,State varchar(20) not null,
  Pin_code char(10) not null,Country_code char(5) default null,Receipient_Name varchar(30) not null,
  Receipient_Phone varchar(12) not null, Is_default boolean default false,CreateD_Time datetime default current_timestamp,Updated_Time datetime  default current_timestamp on update current_timestamp ,
  foreign key (Address_ID) references Customers(Customer_ID));

insert into `Customers_Addresses`(Customer_ID,Address_line1,Address_line2,
  Land_Mark,City,State,Pin_code,Country_code,Receipient_Name,Receipient_Phone) values(
  1,"Mainroad","opposite temple","School","Ongole","Andhra pradesh","523211","+91","Naveen","78945632")
select * from `Customers_Addresses`;

create Table Sellers (Seller_ID int primary key auto_increment,Business_Name varchar(50) not null,Ownwer_first_Name varchar(20) not null,
  Owner_Middle_Name varchar(30) default null,Owner_Last_Name varchar(30) not null,
  Email varchar(40) unique not null,Phone_Number varchar(12) unique not null,Alter_PhoneNo varchar(12),
  Business_Registration varchar(30) unique not null ,Seller_Status varchar(20) default "Offline",
  Verification_Status varchar(30) default "Not verified",create_Time datetime default current_timestamp,updated_time datetime default current_timestamp on update current_timestamp,
  Last_Login datetime default null);
INSERT INTO Sellers
(
    Business_Name,
    Ownwer_first_Name,
    Owner_Middle_Name,
    Owner_Last_Name,
    Email,
    Phone_Number,
    Alter_PhoneNo,
    Business_Registration
)
VALUES
(
    'Naveen Electronics',
    'Naveen',
    'Kumar',
    'Kola',
    'naveen.electronics@gmail.com',
    '9087123465',
    NULL,
    'REG-AND-1001'
);

Insert into Sellers(Business_Name,Ownwer_first_Name,Owner_Last_Name,
  Email,Phone_Number,Business_Registrations) values("PVC pipes","Naveen","Kola","kola@gmail.com","8528515155","uv_1");
select * from Sellers;  

Create Table Sellers_Address(Address_ID int primary key auto_increment,Seller_ID int not null,
  Addreess_Type varchar(20) default "Business" ,Address_line1 varchar(40) not null,
  Address_line2 varchar(40) not null,Land_Mark varchar(30) not null,City varchar(20) not null,
  State varchar(20) not null, Contact_Name varchar(30),Contact_Phone varchar(12), Country_Code Char(4) not null,
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
  
create table Product_Variants(Variants_ID int auto_increment primary key,Product_Id int not null,
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
  foreign key (`Product_Id`) references `Product_Variants`(`Product_Id`));

Insert into `Product_Image`(Product_ID,Image_Name,Image_Location,Display_Order,Is_primary) values(
  1,"Front_full_photo","C:\Users\Naveen\Desktop\Naveen\10th.jpeg",1,TRUE)

select *from `Product_Image`;

Create Table product_category(Product_Id int not null ,
  Categorie_ID int not null ,
  created_Date datetime default current_timestamp,foreign key(Product_Id) references Products(Product_Id),
  foreign key (Categorie_ID) references Categories(Categorie_ID))

insert into product_category(Product_ID,Categorie_ID) values(1,1);

select * from product_category;