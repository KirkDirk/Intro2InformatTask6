﻿// Код к задаче "Описать блок-схему перевода десятичного представления числа в двоичное"

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());  //например, вводим "5"

int i1 = 1; 
while (num >= Math.Pow(2, i1)) i1++;  // операция для определения количества знаков в двоичной записи, при 5: i = 3, потому что 2^2 < 5 < 2^3

int[] array = new int[i1];  // таким образом, для записи 5 в двоичном виде - массив с 3 элементами

int i2 = 0;
int num2 = num;

while (i2 < i1)  // выходим, когда i2 сравняется с 3
{
    array[i2] = (num2 % 2);  // для 5 в массиве получаем: 0 эл = 1, 1 эл = 0, 2 эл = 1
    num2 = num2 / 2;
    i2++;
}
Console.WriteLine($"Число {num} в двоичном виде запишется как: ");
int i3 = i1 - 1;
while (i3 >= 0)
{
    Console.Write(array[i3]);
    i3--;
}