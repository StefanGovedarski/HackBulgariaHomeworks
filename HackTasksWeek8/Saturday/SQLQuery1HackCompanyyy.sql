CREATE TABLE Departments 
(
DepartmentID int  NOT NULL PRIMARY KEY,
Name nvarchar(30) NOT NULL,
);
CREATE TABLE Employees
(
EmployeeID int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Email nvarchar(30),
DateOfBirth datetime,
Manager int,
Department int REFERENCES Departments(DepartmentID),
);
CREATE TABLE Category
(
CategoryID int NOT NULL	PRIMARY KEY,
Name nvarchar(40) NOT NULL,
);
CREATE TABLE Products
(
ProductID int NOT NULL PRIMARY KEY ,
Name nvarchar(40) NOT NULL,
SinglePrice int NOT NULL,
Category nvarchar(3) NOT NULL,
);
ALTER TABLE Products
ADD FOREIGN KEY (ProductID) REFERENCES Categories(CategoryID)
CREATE TABLE Customers
(
CustomerID int NOT NULL PRIMARY KEY,
Name nvarchar(45) NOT NULL,
Email nvarchar(30),
Adress nvarchar(80) NOT NULL,
Discount int
);
CREATE TABLE Orders
(
OrderID int NOT NULL PRIMARY KEY,
Customer int NOT NULL REFERENCES Customers(CustomerID),
TotalPrince int NOT NULL
);
CREATE TABLE OrderProducts
(
OrderProductsID int  NOT NULL PRIMARY KEY,
OrderIDs int NOT NULL,
ProductIDs int NOT NULL,
);
ALTER TABLE Products
ADD FOREIGN KEY (ProductID) REFERENCES OrderProducts(ProductIDs)
ALTER TABLE Orders
ADD FOREIGN KEY (OrderID) REFERENCES OrderProducts(OrderIDs)

