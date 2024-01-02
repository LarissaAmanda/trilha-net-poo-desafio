using System.ComponentModel;
using DesafioPOO.Models;

   // Implementado 

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(nome: "Nokia23", modelo: "Candybar", imei: "12345", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(nome: "Iphone23", modelo: "X-S", imei: "123456789", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");