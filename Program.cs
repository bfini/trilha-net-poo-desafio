using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine ("SmarthPhone Iphone:");
Smartphone iphone = new Iphone(numero:"987654", modelo: " Modelo 2", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");