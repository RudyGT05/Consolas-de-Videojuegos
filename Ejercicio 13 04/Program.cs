using Ejercicio_13_04.ClaseHijo;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostarDetallesNintendo());
//instancia de psi
Playstation ps = new Playstation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloControlador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");
//Isntancia de Xbox
Xbox box = new Xbox();
box.Marca = "Xbox";
box.anioLanzamiento = 2020;
box.Almacenamiento = "512GB";
Console.WriteLine($"{box.MostrarDetalleXbox()}");
//Isntancia de Sega
SegaDreamCast sega = new SegaDreamCast();
sega.Marca = "Sega";
sega.anioLanzamiento = 1985;
sega.Color = "Blanco";
Console.WriteLine($"{sega.MostrarDetalleSega()}");

