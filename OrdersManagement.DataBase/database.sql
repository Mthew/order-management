CREATE DATABASE db_orders;
GO;

USE db_orders;


CREATE TABLE orders (
	 id int identity(1,1) primary key,
	 orderNumber varchar(100) NOT NULL unique,
	 omNumber varchar(100) NOT NULL unique,
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
	confirmedQuantity int default 0
);




INSERT INTO orders(orderNumber, omNumber, generic, orderState) VALUES('4500088101','127901','25001368','0');

INSERT INTO orderDetails(orderId, barCode, SKU, ofNumber, color, colorCode, variant, size, umQuantity, realQuantity) VALUES
(2, '7703794910007', '677371', '10415694', 'PALO DE ROSA', 'pro_233', '25001368017', 'S', '51', '45'),
(2, '7703794910014', '677372', '10415695', 'PALO DE ROSA', 'pro_233', '25001368018', 'M', '102', '88');


 --public string OrderNumber { get; set; } = null!;

 --       public string OmNumber { get; set; } = null!;

 --       public string Generic { get; set; } = null!;

 --       public int OrderState { get; set; }

 --       public DateTime? CreatedAt { get; set; }
