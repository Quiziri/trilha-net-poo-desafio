using DesafioPOO.Models;

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "11999887766", modelo: "Modelo 1", imei: "123456789", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Aplciativo 1");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "11555443322", modelo: "Modelo 2", imei: "987654321", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Aplicativo 2");