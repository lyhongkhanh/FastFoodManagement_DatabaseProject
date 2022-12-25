CREATE DATABASE FASTFOOD_RESTAURANT_SYSTEM

GO
CREATE TABLE Menu
(
	Dish_ID varchar(50) PRIMARY KEY,
	Dish_Name varchar (50),
	Price float ,
	Dish_Status int
)

GO
CREATE TABLE Customer
(
		Cus_ID varchar(50) PRIMARY KEY,
		Cus_Name varchar (50),
		Cus_Phone_Number varchar(50),
		Cus_Address varchar (50),
)
GO
CREATE TABLE Bill
(
	Bill_ID varchar(50) PRIMARY KEY,
	Total_Price float,
	Sold_Date date
)
GO
CREATE TABLE Bill_Detail
(
	Bill_ID varchar(50),
	Dish_ID varchar(50),
	Dish_Num int,
	Price float,
	PRIMARY KEY (Bill_ID, Dish_ID)
)
alter table Bill_Detail add constraint FK_BillDetail_DishID foreign key (Dish_ID)  references Menu(Dish_ID) 
alter table Bill_Detail add constraint FK_BillDetail_BillID foreign key (Bill_ID) references Bill(Bill_ID)


GO
CREATE TABLE Delivery
(
	Bill_ID varchar(50) PRIMARY KEY,
	Cus_Address varchar(50),
	Delivery_Date Date,
	FOREIGN KEY (Bill_ID) REFERENCES Bill(Bill_ID)
)
alter table Delivery alter column Cus_Address nvarchar(50)
GO
CREATE TABLE Staff
(
	ID varchar(50) PRIMARY KEY,
	Staff_Name varchar(50),
	Phone_Number varchar(11),
	Salary float,
	ManagerID varchar(50),
	FOREIGN KEY (ManagerID) references Staff(ID)
)
alter table Staff alter column Staff_Name nvarchar(50)

GO
INSERT into Menu values ('B01','VEG.BURGER', 70, 50);
INSERT into Menu values ('B02','VEG.CHILLY BURGER', 70, 50);
INSERT into Menu values ('B03','CHICKEN BURGER', 110, 50);
INSERT into Menu values ('B04','MUTTON BURGER', 125,50);
INSERT into Menu values ('B05','HAM BURGER', 110,50);
INSERT into Menu values ('B06','SALAMI BURGER', 110,50);
INSERT into Menu values ('B07','FISH BURGER', 125,50);
INSERT into Menu values ('P01','PIZZA CHEESE', 180,50);
INSERT into Menu values ('P02','PIZZA TOMATO CHEESE', 180,50);
INSERT into Menu values ('P03','PIZZA MUSHROOM CHEESE', 210,50);
INSERT into Menu values ('P04','PIZZA CHICKEN CHEESE', 250,50);
INSERT into Menu values ('P05','PIZZA SAUSAGE', 250,50);
INSERT into Menu values ('S01','CHEESE SANDWICH', 130,50);
INSERT into Menu values ('S02','CHICKEN CHEESE SANDWICH', 145,50);
INSERT into Menu values ('S03','HAM CHEESE SANDWICH', 145,50);
INSERT into Menu values ('HD01','CHICKEN CHEESE HOTDOGS', 100,50);
INSERT into Menu values ('HD02','CHEESE HOTDOGS', 80,50);
INSERT into Menu values ('D01','PEPSI', 50,50);
INSERT into Menu values ('D02','COLD COFFEE', 90,50);
INSERT into Menu values ('D03','HOT COFFEE', 100,50);
INSERT into Menu values ('D04','ICE TEA', 70,50);
INSERT into Menu values ('D05','ICE LEMON', 70,50);
INSERT into Menu values ('D06','SODA', 130,50);

GO
INSERT INTO Customer values ('K0101', 'Nguyen Van A', '0345348321', 'TPHCM')
INSERT INTO Customer values ('K0102', 'Nguyen Van B', '0342132121', 'TPHCM')
INSERT INTO Customer values ('K0103', 'Nguyen Van C', '0342123981', 'TPHCM')
INSERT INTO Customer values ('K0104', 'Nguyen Van D', '0212341234', 'TP Thu Duc')
INSERT INTO Customer values ('K0105', 'Nguyen Van E', '0982721331', 'TP Thu Duc')
INSERT INTO Customer values ('K0201', 'Nguyen Van F', '0234214123', 'TP Thu Duc')
INSERT INTO Customer values ('K0202', 'Nguyen Van G', '0921324512', 'TPHCM')
INSERT INTO Customer values ('K0203', 'Nguyen Van H', '0721324215', 'TP Thu Duc')


GO
INSERT INTO Bill values ('Bi01', 160, '2022-03-01')
INSERT INTO Bill values ('Bi02', 355, '2022-03-01')
INSERT INTO Bill values ('Bi03', 440, '2022-03-01')
INSERT INTO Bill values ('Bi04', 390, '2022-03-02')
INSERT INTO Bill values ('Bi05', 450, '2022-03-03')
INSERT INTO Bill values ('Bi06', 600, '2022-03-04')
INSERT INTO Bill values ('Bi07', 480, '2022-03-05')
INSERT INTO Bill values ('Bi08', 145, '2022-03-06')
GO
INSERT INTO Bill_Detail values ('Bi01', 'B01', 1, 70)
INSERT INTO Bill_Detail values ('Bi01', 'D02', 1,90)
INSERT INTO Bill_Detail values ('Bi02', 'B02', 1, 70)
INSERT INTO Bill_Detail values ('Bi02', 'S03', 1, 145)
INSERT INTO Bill_Detail values ('Bi02', 'D05', 2, 140)
INSERT INTO Bill_Detail values ('Bi03', 'P02',  1, 180)
INSERT INTO Bill_Detail values ('Bi03', 'D06',  2, 260)
INSERT INTO Bill_Detail values ('Bi04', 'P04', 1,250)
INSERT INTO Bill_Detail values ('Bi04','D04', 2, 140)
INSERT INTO Bill_Detail values ('Bi05', 'HD01',  3,300)
INSERT INTO Bill_Detail values ('Bi05', 'D01', 3, 150)
INSERT INTO Bill_Detail values ('Bi06', 'HD02',  4,320)
INSERT INTO Bill_Detail values ('Bi06', 'D05',  4, 280 )
INSERT INTO Bill_Detail values ('Bi07','B03', 2, 220)
INSERT INTO Bill_Detail values ('Bi07', 'P02', 1 ,210)
INSERT INTO Bill_Detail values ('Bi07','D01',4 , 50)

GO
INSERT INTO Delivery values('Bi01',  '01 Võ Văn Ngân TP. Thủ Đức', '2022-03-01')
INSERT INTO Delivery values('Bi02',  '01 Võ Văn Ngân TP. Thủ Đức', '2022-03-01')
INSERT INTO Delivery values('Bi04',  '02 Hoàng Diệu 2 TP. Thủ Đức', '2022-03-02')
INSERT INTO Delivery values('Bi06',  '02 Hoàng Diệu 2 TP. Thủ Đức', '2022-03-04')
INSERT INTO Delivery values('Bi08',  '02 Hoàng Diệu 2 TP. Thủ Đức', '2022-03-06')

ALTER TABLE Staff drop constraint [FK__Staff__ManagerID__4316F928]
ALTER TABLE Staff Drop column ManagerID
ALTER TABLE Staff Add Type varchar(50)
GO
INSERT INTO Staff values ('EMP01', 'Tom Hiddleston', '034534821', 10000, 'manager')
INSERT INTO Staff values ('EMP02', 'Calantha', '022412341', 10000,  'manager')
INSERT INTO Staff values ('EMP03', 'Tryphena', '012435134', 5000, 'employee')
INSERT INTO Staff values ('EMP04', 'Vera', '024124213', 5000, 'employee')
INSERT INTO Staff values ('EMP05', 'Theodora', '019282134', 5000,  'employee')
INSERT INTO Staff values ('EMP06', 'Stella', '093832123', 5000, 'employee')

GO
create trigger dbo.update_status on [dbo].[Bill_Detail]
for insert
as
begin
	declare @dish_Id varchar(50), @dish_num int
	
	select @dish_Id=inserted.Dish_ID, @dish_num=inserted.Dish_Num
	from inserted

	update Menu
	set Dish_Status=Dish_Status-@dish_num
	where Dish_ID=@dish_Id
end

GO
INSERT INTO Bill_Detail values ('Bi09','D06',2,260)
INSERT INTO Bill values ('Bi09',260,'2022-03-07')


GO
alter trigger dbo.update_status on [dbo].[Bill_Detail]
for insert
as
begin
	declare @dish_Id varchar(50), @dish_num int, @dish_status int
	
	select @dish_Id=inserted.Dish_ID, @dish_num=inserted.Dish_Num
	from inserted
	
	select @dish_status=menu.Dish_Status
	from menu
	where Dish_ID=@dish_Id

	if (@dish_status=0)
	begin
		print('Sold out!')
		rollback 
	end
	else
	begin
		update Menu
		set Dish_Status=Dish_Status-@dish_num
		where Dish_ID=@dish_Id
	end
end

Insert into menu values ('SP1', 'SPAGHETTI',100,0)
INSERT into Bill values ('Bi10', 100, '2022-03-08')
insert into Bill_Detail values ('Bi10', 'SP1', 1, 100)


INSERT INTO Bill values ('Bi11',260,'2022-03-07') 
INSERT INTO Bill_Detail values ('Bi11','D06',2,260)

INSERT into Bill values ('Bi12', 100, '2022-03-08')
insert into Bill_Detail values ('Bi12', 'SP1', 1, 100)

GO
alter table Bill_Detail add constraint Check_DishNum Check(Dish_Num>0)
alter table Bill add constraint Check_Price Check(Total_Price > 0)

