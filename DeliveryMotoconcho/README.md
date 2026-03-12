# 🛵 DeliveryMotoconcho

Sistema de logística y liquidación de delivery desarrollado en C# con arquitectura en capas y SQL Server.

**Estudiante:** Maiquelys González | UCE 2026 | 2023-3613  
**Tema:** #19 Motoconcho/Delivery

---

## 🗄️ Query SQL
```sql
CREATE DATABASE DeliveryMotoconcho;
GO

USE DeliveryMotoconcho;

CREATE TABLE Zona (
    ZonaID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(200)
);

CREATE TABLE Tarifa (
    TarifaID INT PRIMARY KEY IDENTITY,
    ZonaID INT FOREIGN KEY REFERENCES Zona(ZonaID),
    PrecioPorEntrega DECIMAL(10,2) NOT NULL
);

CREATE TABLE Repartidor (
    RepartidorID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(150) NOT NULL,
    Telefono VARCHAR(20),
    ZonaID INT FOREIGN KEY REFERENCES Zona(ZonaID),
    Disponible BIT DEFAULT 1
);

CREATE TABLE Pedido (
    PedidoID INT PRIMARY KEY IDENTITY,
    RepartidorID INT FOREIGN KEY REFERENCES Repartidor(RepartidorID),
    ZonaID INT FOREIGN KEY REFERENCES Zona(ZonaID),
    FechaPedido DATETIME DEFAULT GETDATE(),
    DireccionEntrega VARCHAR(250),
    Estado VARCHAR(50) DEFAULT 'Pendiente'
);

CREATE TABLE LiquidacionDiaria (
    LiquidacionID INT PRIMARY KEY IDENTITY,
    RepartidorID INT FOREIGN KEY REFERENCES Repartidor(RepartidorID),
    Fecha DATE,
    TotalEntregas INT,
    TotalGanado DECIMAL(10,2),
    Cerrada BIT DEFAULT 0
);

-- Datos de prueba
INSERT INTO Zona VALUES ('Norte', 'Zona Norte');
INSERT INTO Zona VALUES ('Sur', 'Zona Sur');
INSERT INTO Zona VALUES ('Este', 'Zona Este');

INSERT INTO Tarifa VALUES (1, 150.00);
INSERT INTO Tarifa VALUES (2, 120.00);
INSERT INTO Tarifa VALUES (3, 130.00);

INSERT INTO Repartidor VALUES ('Juan Pérez', '809-000-0001', 1, 1);
INSERT INTO Repartidor VALUES ('Carlos Díaz', '809-000-0002', 2, 1);
INSERT INTO Repartidor VALUES ('Luis Martínez', '809-000-0003', 3, 1);
```

