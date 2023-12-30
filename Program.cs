using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"81997757903",modelo:"Nokia G60 5G",imei:"1111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"81998874321",modelo:"Iphone 15",imei:"2222222",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");