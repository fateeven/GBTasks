﻿//Программа, которая выводит случайное трехзначное число 
//и показывает вторую цифру этого числа.
using System;
using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
WriteLine($"{number}->{(number / 10) % 10}");
