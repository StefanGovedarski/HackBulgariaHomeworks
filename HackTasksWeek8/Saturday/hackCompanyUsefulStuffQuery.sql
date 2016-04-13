ALTER TABLE Products
DROP CONSTRAINT FK__Products__Produc__1A14E395

ALTER TABLE Products
ADD FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)

ALTER TABLE OrderProducts 
ADD CONSTRAINT pk_ PRIMARY KEY (OrderId,ProductID); 

DELETE FROM OrderProducts WHERE OrderId>0