using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("11999999999", "G20", "1234567890", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("11999999999", "13 Pro", "0987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");