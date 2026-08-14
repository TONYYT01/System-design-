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

