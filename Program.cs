using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone



Console.WriteLine("============================================");

Nokia Nokia1 = new Nokia(numero: "982626387", modelo: "version1", imei: "1234", memoria: 64);
Nokia1.Ligar();
Nokia1.ReceberLigacao();
Nokia1.InstalarAplicativo("Biblia");

Console.WriteLine("============================================");

Iphone Iphone1 = new Iphone(numero: "982626387", modelo: "XR", imei: "1234", memoria: 132);
Iphone1.Ligar();
Iphone1.ReceberLigacao();
Iphone1.InstalarAplicativo("Netflix");