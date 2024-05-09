using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Nokia
Smartphone nokia = new Nokia(numero: "16999999999", modelo: "Tijolão", imei: "asdqwezxc", memoria: 12);
nokia.Ligar();
nokia.InstalarAplicativo("Roblox");

Console.WriteLine("-x-x-x-x-x-x-x-x-x-");

Smartphone iphone = new Iphone(numero: "1688888888", modelo: "15 PRO MAX TURBO", imei: "poijklmnb", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Notion");