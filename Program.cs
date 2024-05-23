using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("12345", "Modelo 1", "5558793", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");


Console.WriteLine("Nokia:");
Nokia nokia = new Nokia("678910", "Modelo 1", "879621456", 64); 
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");