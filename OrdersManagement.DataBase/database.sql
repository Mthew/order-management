CREATE DATABASE db_orders;
GO;

USE db_orders;


CREATE TABLE orders (
	 id int identity(1,1) primary key,
	 orderNumber varchar(100) NOT NULL unique,	 
	 omNumber varchar(100) NOT NULL unique,
	 campaignNumber varchar(100) NOT NULL,
	 generic varchar(100) NOT NULL,
	 orderState int NOT NULL,
	 created_at smalldatetime default getdate()
);


CREATE TABLE orderDetails (
	id int identity(1,1) primary key,
	orderId int NOT NULL FOREIGN KEY(orderId) REFERENCES orders(id) ON DELETE CASCADE,
	barCode varchar(100) NOT NULL unique,
	SKU varchar(100) NOT NULL,
	ofNumber varchar(100) NOT NULL,
	color varchar(100) NOT NULL,
	colorCode varchar(100) NOT NULL,
	variant varchar(100) NOT NULL, 
	size varchar(25) NOT NULL,
	umQuantity int NOT NULL,
	realQuantity int NOT NULL,
	confirmedQuantity int default 0,
	printedQuantity int default 0,
	[description] varchar(255),
	price decimal(18,2) NOT NULL
);


CREATE TABLE billAccount (
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	orderId int NULL,
	billNumber int NOT NULL,
	price decimal(18,2) NOT NULL,
	createdAt smalldatetime DEFAULT GETDATE()
);


--DROP TABLE orderDetails
--DROP TABLE billAccount 
--DROP TABLE orders

ALTER TABLE orderDetails ADD printedQuantity int default 0;
ALTER TABLE orderDetails ADD [description] varchar(255);
ALTER TABLE orderDetails ADD price decimal(18,2) NOT NULL DEFAULT 0;


UPDATE orderDetails SET printedQuantity = 0, confirmedQuantity = 0;
UPDATE orderDetails SET printedQuantity = 4 WHERE id = 7

SELECT * FROM orderDetails;

INSERT INTO orders(orderNumber, omNumber, generic, orderState, campaignNumber) VALUES('4500088101','127901','25001368','0', '2023/08/NM');

INSERT INTO orderDetails(orderId, barCode, SKU, ofNumber, color, colorCode, variant, size, umQuantity, realQuantity, price) VALUES
(3, '7703794910007', '677371', '10415694', 'PALO DE ROSA', 'pro_233', '25001368017', 'S', '51', '45', 0),
(3, '7703794910014', '677372', '10415695', 'PALO DE ROSA', 'pro_233', '25001368018', 'M', '102', '88', 0);


SELECT * FROM orderDetails od
	INNER JOIN orders o ON od.orderId = o.id
WHERE od.id = 1

select * from orders


INSERT INTO billAccount(billNumber, price) values (2995, 0)

select * from billAccount 

use db_orders;

SELECT Fn_NumberToWords('22');

 --public string OrderNumber { get; set; } = null!;

 --       public string OmNumber { get; set; } = null!;

 --       public string Generic { get; set; } = null!;

 --       public int OrderState { get; set; }

 --       public DateTime? CreatedAt { get; set; }


 
CREATE FUNCTION fn_NumberToWords(@Number as BIGINT)
	RETURNS VARCHAR(1024)
AS BEGIN
    -- Crear tablas temporales para guardar numeros y palabras especificas
      DECLARE @Below20 TABLE (ID int identity(0,1), Word varchar(32))
      DECLARE @Below100 TABLE (ID int identity(2,1), Word varchar(32))
      DECLARE @Below1000 TABLE (ID int identity(1,1), Word varchar(32))
    -- Insertar los numero del 0 al 19 en la primera tabla
      INSERT @Below20 (Word) VALUES
                        ( 'Cero'), ('Uno'),( 'Dos' ), ( 'Tres'),
                        ( 'Cuatro' ), ( 'Cinco' ), ( 'Seis' ), ( 'Siete' ),
                        ( 'Ocho'), ( 'Nueve'), ( 'Dies'), ( 'Once' ),
                        ( 'Doce' ), ( 'Trece' ), ( 'Catorce'),
                        ( 'Quince' ), ('Dieciseis' ), ( 'Diecisiete'),
                        ('Dieciocho' ), ( 'Diecinueve' )
    -- Insertar los multiplos de 10 hasta el 90 en la segunda tabla
       INSERT @Below100 VALUES ('Veinte'), ('Treinta'),('Cuarenta'), ('Cincuenta'),
                               ('Sesenta'), ('Setenta'), ('Ochenta'), ('Noventa')
    -- Inserte los multiplos de 100 hasta el 900 en la tercera tabla
       INSERT @Below1000 VALUES ('Ciento'), ('Docientos'), ('Trecientos'), ('Cuatrocientos'),
                               ('Quinientos'), ('Seiscientos'), ('Setecientos'), ('Ochocientos') , ('Novecientos')

	DECLARE @Words varchar(1024) = 
	(

	  SELECT CASE
		WHEN @Number = 0 THEN  ''

		WHEN @Number BETWEEN 1 AND 19
		  THEN (SELECT Word FROM @Below20 WHERE ID=@Number)

		WHEN @Number BETWEEN 20 AND 99  
		 THEN CASE WHEN @Number BETWEEN 21 AND 29
				   THEN 'Veinti' + dbo.fn_NumberToWords( @Number % 10) 
				   ELSE (SELECT Word FROM @Below100 WHERE ID=@Number/10)+ ' y ' +
				   dbo.fn_NumberToWords( @Number % 10)
			   END

	   WHEN @Number BETWEEN 100 AND 999  
		 THEN  CASE WHEN @Number = 100 
					THEN 'Cien' 
					ELSE (SELECT Word FROM @Below1000 WHERE ID=@Number/100)+' '+
					dbo.fn_NumberToWords( @Number % 100)
			   END

	   WHEN @Number BETWEEN 1000 AND 999999  
		 THEN  CASE WHEN @Number BETWEEN 1000 AND 1199 
					THEN 'Mil ' + dbo.fn_NumberToWords( @Number % 1000) 
					ELSE (dbo.fn_NumberToWords( @Number / 1000))+' Mil '+
					dbo.fn_NumberToWords( @Number % 1000) 
			   END

	   WHEN @Number BETWEEN 1000000 AND 999999999  
		 THEN CASE WHEN @Number BETWEEN 1000000 AND 1999999 
				   THEN 'Un Million '+
						dbo.fn_NumberToWords( @Number % 1000000)
				   ELSE (dbo.fn_NumberToWords( @Number / 1000000))+' Milliones '+
						dbo.fn_NumberToWords( @Number % 1000000)
			  END

	   WHEN @Number BETWEEN 1000000000 AND 999999999999  
		THEN  (dbo.fn_NumberToWords( @Number / 1000000000))+' Billion '+
			 dbo.fn_NumberToWords( @Number % 1000000000)
	   ELSE 'NUMERO INVALIDO' 
	   END
	)

	SET @Words = RTRIM(@Words)
	SELECT @Words = RTRIM(LEFT(@Words,len(@Words)-1))
					 WHERE RIGHT(@Words,1)='-'
RETURN (@Words)
END





CREATE PROCEDURE sp_CreateAndGetBillAccount(
	@orderID INT
) AS BEGIN

--calcular presio de cuenta de cobro
	DECLARE @price decimal(18,2) = (SELECT SUM(printedQuantity * price) FROM orderDetails WHERE orderID = @orderID),
		@billAccountnumber int = (SELECT MAX(billNumber) + 1 FROM billAccount);

--crear cuenta de cobro, insertar presio
	INSERT INTO billAccount(orderId, billNumber, price) VALUES(@orderID, @billAccountnumber, @price);


	SELECT od.id, 
		od.barCode, 
		od.SKU, 
		od.ofNumber, 
		od.color, 
		od.colorCode, 
		od.variant, 
		od.size, 
		od.umQuantity, 
		od.realQuantity, 
		od.confirmedQuantity, 
		o.id AS orderId, 
		o.orderNumber, 
		o.omNumber, 
		o.generic, 
		o.orderState, 
		o.created_at,
		b.price as totalPrice,
		dbo.fn_NumberToWords(b.price) as wordPrice
	FROM orderDetails AS od 
		INNER JOIN orders AS o ON od.orderId = o.id
		INNER JOIN billAccount AS b ON o.id = b.orderId
	WHERE  o.id = @orderID;
END


