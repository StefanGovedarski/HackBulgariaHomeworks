SELECT Name FROM Employees WHERE EmployeeID = 1

SELECT Name,Email FROM Employees WHERE Manager = 1

SELECT Name FROM Employees WHERE Department = 1 ORDER BY Name

SELECT Departments.Name FROM Departments JOIN Employees ON Employees.DateOfBirth >= CAST(N'1990-1-1' AS DATE)


SELECT Departments.Name FROM Employees INNER JOIN Departments
ON DepartmentID = EmployeeID
GROUP BY Departments.Name
HAVING COUNT(*) > 3

SELECT TOP 1 Departments.Name , COUNT(*) AS 'Employee count'
FROM Employees INNER JOIN Departments
ON DepartmentID = Employees.Department
GROUP BY Departments.Name

SELECT TOP 1 Orders.OrderID , COUNT(*) AS 'PRODUCTS IN ORDER'
FROM Orders INNER JOIN OrderProducts
ON Orders.OrderID = OrderProducts.OrderId
GROUP BY Orders.OrderID
ORDER BY [PRODUCTS IN ORDER] DESC

SELECT AVG(Customers.Discount) AS 'AVERG DISCOUNT'
FROM Customers

UPDATE Employees
SET DateOfBirth = DATEADD(YYYY,1,DateOfBirth)


UPDATE c
SET c.Discount = c.Discount*2 
FROM Customers c
WHERE c.CustomerID = ( 
SELECT TOP 1 Orders.Customer
FROM Orders INNER JOIN Customers
ON Orders.Customer = Customers.CustomerID
GROUP BY Orders.Customer
) ;

DELETE FROM Products
WHERE ProductID NOT IN
(SELECT OrderProducts.ProductID FROM HackCompany.DBO.OrderProducts)