# DOTNET_TEST

Comandos para ejecutar el proyecto:

1.- Configurar la cadena de conexion a la base de datos (Mysql)
  1.1.- Acceder al archivo Web.API/Properties/launchSettings.json y cambiar la propiedad environmentVariables.MySqlDataBase (yourconnectionstring) por tu conexion.
  1.2.- Acceder al archivo Infrastructure/Contextos/CineContexto.cs y reemplazar la cadena "yourconnectionstring" por tu conexion.

2.- En la raiz del proyecto ejecutar el comando "dotnet run -p Infrastructure/" el cual creara la base de datos mysql y todas las relaciones entre tablas.

3.- Ejecutar el siguiente script para poblar las tablas de la base de datos:


INSERT INTO `RoomEntities` (`Id`, `Name`, `Number`, `Status`, `Available`, `Unavailable`) VALUES
(1, 'Sala 1', 1, 1, 50, 50),
(2, 'Sala 2', 2, 1, 100, 0);

INSERT INTO `MovieEntities` (`Id`, `Name`, `Genre`, `AllowedAge`, `LengthMinutes`, `Status`) VALUES
(1, 'ET', 11, 12, 120, 1),
(2, 'WITCH', 11, 18, 140, 1),
(3, 'Scarface', 3, 18, 150, 1),
(4, 'La llorona', 11, 18, 110, 1);

INSERT INTO `CustomerEntities` (`Id`, `DocumentNumber`, `Name`, `Lastname`, `Age`, `PhoneNumber`, `Email`, `Status`) VALUES
(1, '11111111', 'Douglas', 'Natha', 33, '12345678', 'dnatha@eluniverso.com', 1),
(2, '22222222', 'Juan', 'Perez', 30, '12345678', 'juan@perez.com', 1),
(3, '33333333', 'Maria', 'DB', 23, '12345678', 'maria@db.com', 1),
(4, '44444444', 'Miguel', 'Lopez', 40, '12345678', 'miguel@lopez.com', 1);

INSERT INTO `SeatEntities` (`Id`, `Number`, `RowNumber`, `RoomId`, `Status`) VALUES
(1, 1, 1, 1, 1),
(2, 2, 1, 1, 1),
(3, 3, 1, 1, 1),
(4, 4, 1, 1, 1),
(5, 1, 1, 2, 1);

INSERT INTO `BillboardEntities` (`Id`, `Date`, `StartTime`, `EndTime`, `MovieId`, `RoomId`, `Status`) VALUES
(1, '2023-10-01 12:34:53.000000', '00:37:14.000000', '01:37:14.000000', 1, 1, 1),
(2, '2023-10-08 12:00:00.000000', '12:37:14.000000', '14:37:14.000000', 2, 2, 1);

INSERT INTO `BookingEntities` (`Id`, `Date`, `CustomerId`, `SeatId`, `BillboardId`, `Status`) VALUES
(1, '2023-09-01 12:34:53.000000', 1, 1, 1, 1),
(2, '2023-10-06 21:03:40.000000', 2, 2, 1, 1),
(3, '2023-10-06 21:03:40.000000', 3, 3, 2, 1);


3.- Ejecutar el comando "dotnet run -p Web.API" el cual levantara el backend con el swagger y todos los servicios.

4.- Acceder a http://localhost:5183/swagger/index.html para conocer la ruta de los endpoints
