﻿// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;


Console.WriteLine("Hello, World!");

//https://github.com/2024-2025-nappali-13b/01-ismtles-adattipusok/commits/main/

int a = 1; int b = 2;
int x; //deklaráció
// Console.WriteLine($"Deklaráció után: {x}.");
// Hibaüzenet: Use of unassigned local variable 'x'
x = 10; //definíció
Console.WriteLine($"x={x}");
int y = 11; //deklaráció és definíció
Console.WriteLine($"y={y}");

int integer = 0; // Előjeles, 32 bites egész szám (–2147483648.. 2147483647).
float flóath = 6 / 2.3F; flóath = (float)5 / 4; // csak 7 számjegyig képes pontosan számolni.
double dábül = 6 / 2.3; dábül = 6 / 2.3D; // 15-17 számjegyig képes pontosan számolni.

byte bájt = 250; // Előjel nélküli 8 bites egész szám(0..255)
char karakter = 'X'; // Egy Unicode karakter(1etlen karakter meg fontos dolgok, volt ascii alapbol)
decimal decimál = 6 / 2.3M; decimál = Convert.ToDecimal(6 / 2.3); // 25-29 számjegyig képes pontosan számolni. 
                                                                  // FONTOS: Pénz értéket mindig decimalban tároljunk!

string sztring = "szöveg"; //Unicode karakterek összefűzve
object obdzsekt = new object(); //Minden más típus őse
var elso = "variéböl"; //Tetszőleges típusú változó, azonnal értéket kell adni neki


const string alma = "alma";

string semmi = "";
string nihil = null;
Console.WriteLine(semmi);
Console.WriteLine(nihil);
if (semmi != nihil)
    Console.WriteLine("A null nem egyenértékű a \"\" -jellel!");
