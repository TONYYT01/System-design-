### In project table stractures


#### Data storage table

```mysql
Create table if not exists DATA(
  User_id int primary key auto_increment,
  User_Name varchar(20) not null unique,
  Email  character(50) not null unique,
  password varchar(20) not null default "User@123",
  Created_time timestamp default current_timestamp,
  Loin_time timestamp default current_timestamp,
  active bool default 0
)
```

