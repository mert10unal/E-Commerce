# E-Commerce Database

The problems to be solved about E-Commerce database are shown :

Let's design an e-commerce database
  -  It has categories, name, number of products, number of companies, etc.
  - There are companies. companies have a name and a category to which they belong. A company also has more than one
  can sell products from category
  - Products are available, the product has categories, companies, name, code, price
  - Orders are available. Order has a code, an address, an estimated delivery date, delivered
  persons name and surname. An order may contain many products.
  - There is a bill. A bill can have many products and one order. One bill for each order is cut off.

E-Commerce database scheme is designed : 

![Bildschirmfoto 2023-02-15 um 15 08 20](https://user-images.githubusercontent.com/120198895/219023503-266c696a-afc6-4639-9795-49dc43b1a29f.png)

In line with this design, some datas that answer the frequently asked questions :

create table Category(
Id int primary key GENERATED ALWAYS AS IDENTITY,
CategoryName character varying(100)
);
drop table Category
insert into Category (CategoryName) values ('Food')
insert into Category (CategoryName) values ('Cosmetics')
insert into Category (CategoryName) values ('Soft Drinks')
insert into Category (CategoryName) values ('Candy')
insert into Category (CategoryName) values ('Magazine')
select * from Category

create table Company(
Id int primary key GENERATED ALWAYS AS IDENTITY,
CompanyName character varying(100)
);

insert into Company (CompanyName) values ('Eat More')
insert into Company (CompanyName) values ('LOreal')
insert into Company (CompanyName) values ('Powerade')
insert into Company (CompanyName) values ('M&M')
insert into Company (CompanyName) values ('Daily Magazine')
select * from Company

create table Bill(
Id int primary key GENERATED ALWAYS AS IDENTITY,
Code int
);

insert into Bill (Code) values (12345)
insert into Bill (Code) values (34950)
insert into Bill (Code) values (29840)
insert into Bill (Code) values (20945)
insert into Bill (Code) values (75192)
select * from Bill

create table CompanyProduct(
Id int primary key GENERATED ALWAYS AS IDENTITY,
Price float,
CompanyId int,
FOREIGN KEY (CompanyId) REFERENCES Company(Id)
);

insert into CompanyProduct(Price,CompanyId) values (12.90,3)
insert into CompanyProduct(Price,CompanyId) values (7.75,1)
insert into CompanyProduct(Price,CompanyId) values (5.55,2)
insert into CompanyProduct(Price,CompanyId) values (10.50,5)
insert into CompanyProduct(Price,CompanyId) values (3.75,4)
create table Product(
Id int primary key GENERATED ALWAYS AS IDENTITY,
ProductName character varying (100),
CategoryId int,
CompanyProductId int,
FOREIGN KEY (CategoryId) REFERENCES Category(Id),
FOREIGN KEY (CompanyProductId) REFERENCES CompanyProduct(Id)
);
drop table Product
insert into Product(ProductName,CategoryId, CompanyProductId) values ('Hamburger',1,2)
insert into Product(ProductName,CategoryId, CompanyProductId) values ('Mountain Dew',3,5)
insert into Product(ProductName,CategoryId, CompanyProductId) values ('Lipstick',2,4)
insert into Product(ProductName,CategoryId, CompanyProductId) values ('Haribo',4,3)
insert into Product(ProductName,CategoryId, CompanyProductId) values ('Vogue',5,1)
select * from Product
alter table Product set Product.Id = 1
WHERE Product.Id = 7

create table Orders(
Id int primary key GENERATED ALWAYS AS IDENTITY,
Code int,
Address character varying (150),
DeliveryTime time,
CustomerName character varying (100),
CustomerSurname character varying (100),
BillId int,
FOREIGN KEY (BillId) REFERENCES Bill(Id)
);

insert into Orders (Code,Address, DeliveryTime, CustomerName, CustomerSurname, BillId) values (112, 'Times Square 5th Avenue','15:41','Mert','Unal',2)
insert into Orders (Code,Address, DeliveryTime, CustomerName, CustomerSurname, BillId) values (132, 'New Street 6th Avenue','15:10','Efe','Taycı',4)
insert into Orders (Code,Address, DeliveryTime, CustomerName, CustomerSurname, BillId) values (143, 'İstanbul Madenler X Apartmanı','10:00','Ege','Perçinel',1)
insert into Orders (Code,Address, DeliveryTime, CustomerName, CustomerSurname, BillId) values (156, 'Göztepe Özgürlük Parkı','05:01','Burak','Keskin',3)
insert into Orders (Code,Address, DeliveryTime, CustomerName, CustomerSurname, BillId) values (196, 'Anfield Towers','20:12','Kerem','Öztekin',5)
select * from Orders

create table ProductOrder(
Id int primary key GENERATED ALWAYS AS IDENTITY,
OrdersId int,
ProductId int,
FOREIGN KEY (OrdersId) REFERENCES Orders(Id),
FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

insert into ProductOrder(OrdersId, ProductId) values (1,5)
insert into ProductOrder(OrdersId, ProductId) values (3,2)
insert into ProductOrder(OrdersId, ProductId) values (4,4)
insert into ProductOrder(OrdersId, ProductId) values (2,3)
insert into ProductOrder(OrdersId, ProductId) values (5,6)
select * from ProductOrder

--address of the order whose company name is 'Eat More'
select Address from Company,CompanyProduct,Product,ProductOrder,Orders
where Company.Id=CompanyProduct.CompanyId
and CompanyProduct.Id = Product.Id
and Product.Id=ProductOrder.ProductId
and ProductOrder.OrdersId = Orders.Id
and CompanyName = 'Eat More'

--Name of the product with the bill code '20945'
select ProductName from Product,ProductOrder,Orders,Bill
where Product.Id = ProductOrder.ProductId
and ProductOrder.OrdersId = Orders.Id
and Orders.BillId = Bill.Id
and Bill.Code = 20945
