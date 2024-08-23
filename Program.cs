using DesafioPOO.Models;

Iphone iphone1 = new Iphone("47 9108-8443", "iPhone 3", "0123456789101112", 128);
Nokia nokia1 = new Nokia("47 9937-5844", "2280", "0123456789101113", 2);
Console.WriteLine($"iPhone: {iphone1.Numero} {iphone1.Modelo} {iphone1.Imei} {iphone1.Memoria}");
Console.WriteLine($"Nokia: {nokia1.Numero} {nokia1.Modelo} {nokia1.Imei} {nokia1.Memoria}");

//Teste para verificar se Número pode ser alterado:
iphone1.Numero = "929347248";

Console.WriteLine($"{iphone1.Numero} {iphone1.Modelo} {iphone1.Imei} {iphone1.Memoria}");

//teste para verificar se a propriedade somente leitura funcionou:
//iphone1.Modelo = "iPhone 60";

//Testando as funçoes:
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Tinder");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Snake");