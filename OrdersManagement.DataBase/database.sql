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

ALTER TABLE orderDetails ADD printedQuantity int default 0;
ALTER TABLE orderDetails ADD [description] varchar(255);
ALTER TABLE orderDetails ADD price decimal(18,2) NOT NULL DEFAULT 0;


UPDATE orderDetails SET printedQuantity = 0, confirmedQuantity = 0;
UPDATE orderDetails SET [description] = 'Camiseta', price = 1997;


INSERT INTO orders(orderNumber, omNumber, generic, orderState, campaignNumber) VALUES('4500088101','127901','25001368','0', '2023/08/NM');

INSERT INTO orderDetails(orderId, barCode, SKU, ofNumber, color, colorCode, variant, size, umQuantity, realQuantity) VALUES
(1, '7703794910007', '677371', '10415694', 'PALO DE ROSA', 'pro_233', '25001368017', 'S', '51', '45'),
(1, '7703794910014', '677372', '10415695', 'PALO DE ROSA', 'pro_233', '25001368018', 'M', '102', '88');


SELECT * FROM orderDetails od
	INNER JOIN orders o ON od.orderId = o.id
WHERE od.id = 1



 --public string OrderNumber { get; set; } = null!;

 --       public string OmNumber { get; set; } = null!;

 --       public string Generic { get; set; } = null!;

 --       public int OrderState { get; set; }

 --       public DateTime? CreatedAt { get; set; }
