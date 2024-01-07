using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo: A302", imei: "22222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsAPP");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo: 14", imei: "33333", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");