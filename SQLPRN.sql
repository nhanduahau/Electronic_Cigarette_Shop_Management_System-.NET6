CREATE DATABASE VapeShop;
GO

USE VapeShop;
GO

-- Create the customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    PhoneNumber NVARCHAR(15) NOT NULL, 
	CustomerName NVARCHAR(100) NOT NULL
);

-- Create the items table
CREATE TABLE Items (
    ItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName NVARCHAR(200) NOT NULL,
    Price DECIMAL(18,0) NOT NULL,
    Quantity INT NOT NULL
);

-- Create the employees table
CREATE TABLE Employees (
   EmployeeID int PRIMARY KEY IDENTITY(1,1),
   EmployeeName varchar(50) NOT NULL,
   EmployeeUsername varchar(50) NOT NULL UNIQUE,
   EmployeePassword varchar(50) NOT NULL,
   Role bit NOT NULL,
   AccountStatus BIT not null
);

-- Create the invoices table
CREATE TABLE Invoices (
    InvoiceID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    EmployeeID INT NOT NULL,
    InvoiceDate DATE NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers (CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID)
);

-- Create the invoice items table
CREATE TABLE InvoiceItems (
    InvoiceItemID INT PRIMARY KEY IDENTITY(1,1),
    InvoiceID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (InvoiceID) REFERENCES Invoices (InvoiceID),
    FOREIGN KEY (ItemID) REFERENCES Items (ItemID)
);

-- Create the Revenue table
CREATE TABLE Revenue (
   RevenueID int PRIMARY KEY IDENTITY(1,1),
   Date datetime NOT NULL,
   Amount decimal(10,2) NOT NULL
);

INSERT INTO Employees (EmployeeName, Role, EmployeeUsername, EmployeePassword, AccountStatus)
VALUES
    ('John Doe', 1, 'cashier1', 'pass123',1),
    ('Jane Doe', 0, 'admin', 'pass456',1),
    ('Jim Smith', 1, 'cashier2', 'pass789',1);


INSERT INTO Items (ItemName, Quantity, Price)
VALUES
('Pod System Kit Lost Vape Orion', 20, 750000),
('Pod System Kit Smok Novo', 15, 600000),
('Pod System Kit Smok RPM', 25, 650000),
('Pod System Kit Smok Nord', 30, 700000),
('Pod System Kit Smok RPM 2', 35, 750000),
('Pod System Kit Smok Fetch', 10, 650000),
('Pod System Kit Smok Nfix', 25, 680000),
('Pod System Kit Smok Nfix Mate', 15, 650000),
('Pod System Kit Smok Trinity Alpha', 20, 650000),
('Pod System Kit Smok Mico', 25, 600000),
('Pod System Kit Smok Infinix', 20, 650000),
('Pod System Kit Smok Stick', 25, 650000),
('Pod System Kit Smok Pozz X', 20, 670000),
('Pod System Kit Smok Pozz X RPM', 15, 670000),
('Pod System Kit Smok Pozz X Nord', 30, 690000),
('Pod System Kit Smok Pozz X RGC', 25, 690000),
('Pod System Kit Smok Pozz X RPM 2', 35, 720000),
('Pod System Kit Smok Pozz X Fetch', 10, 670000),
('Pod System Kit Smok Pozz X Nfix', 25, 700000),
('Pod System Kit Smok Pozz X Nfix Mate', 15, 670000),
('Pod System Kit Smok Pozz X Trinity Alpha', 20, 670000),
('Pod System Kit Smok Pozz X Mico', 25, 600000),
('Pod System Kit Smok Pozz X Infinix', 20, 670000),
('Pod System Kit Smok Pozz X Stick', 25, 670000),
('Pod System Kit Smok Pozz X Pozz X', 20, 670000),
('Pod System Kit Smok Pozz X Pozz X RPM', 15, 670000),
('Pod System Kit Smok Pozz X Pozz X Nord', 30, 670000),
('Pod System Kit Smok Pozz X Pozz X RGC', 25, 670000)


INSERT INTO Customers (PhoneNumber, CustomerName)
VALUES 
('0901234567', N'Nguyễn Văn A'),
('0902345678', N'Phạm Thị B'),
('0903456789', N'Lê Văn C'),
('0904567890', N'Trần Thị D'),
('0905678901', N'Vũ Văn E'),
('0906789012', N'Nguyễn Thị F'),
('0907890123', N'Hoàng Văn G'),
('0908901234', N'Trần Thị H'),
('0909012345', N'Nguyễn Văn I'),
('0900123456', N'Lê Thị K'),
('0902233445', N'Đặng Văn L'),
('0903344556', N'Ngô Thị M'),
('0904455667', N'Huỳnh Văn N'),
('0905566778', N'Lý Thị O'),
('0906677889', N'Bùi Văn P'),
('0907788990', N'Phan Thị Q'),
('0908899001', N'Trương Văn R'),
('0909900112', N'Phạm Thị S'),
('0900011223', N'Lương Văn T'),
('0901122334', N'Hồ Thị U'),
('0902233445', N'Trần Văn V'),
('0903344556', N'Lê Thị X'),
('0904455667', N'Võ Văn Y'),
('0905566778', N'Nguyễn Thị Z'),
('0906677889', N'Hoàng Văn A1'),
('0907788990', N'Đặng Thị B1'),
('0908899001', N'Lê Văn C1'),
('0909900112', N'Nguyễn Thị D1'),
('0900011223', N'Vũ Văn E1'),
('0901122334', N'Lê Thị F1'),
('0902233445', N'Trần Văn G1'),
('0903344556', N'Phạm Thị H1'),
('0904455667', N'Nguyễn Văn I1'),
('0905566778', N'Trần Thị K1'),
('0906677889', N'Phan Văn L1'),
('0907788990', N'Hồ Thị M1'),
('0908899001', N'Bùi Văn N1'),
('0909900112', N'Đặng Thị O1'),
('0900011223', N'Trần Văn P1'),
('0901122334', N'Lê Thị Q1'),
('0902233445', N'Nguyễn Văn R1'),
('0903344556', N'Vũ Thị S1'),
('0904455667', N'Trần Văn T1'),
('0905566778', N'Hoàng Thị U1'),
('0906677889', N'Ngô Văn V1')