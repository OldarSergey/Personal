﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


int nomer; // индекс в массиве
int d;
int j;
int i;// индекс в алфавите
int key; // смещение
string SMS; // входное сообщение
string Vivod; // вывод



Console.Write("Введите сообщение: ");
SMS = Console.ReadLine();
SMS = SMS.ToLower();
char[] charArray = SMS.ToCharArray();
char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
for (i = 0; i < charArray.Length; i++)
{
    for (j = 0; j < alfavit.Length; j++)
    {
        if (charArray[i] == alfavit[j])
        {
            break;
        };
    }
    if (j != 33)
    {
        nomer = j;
        d = nomer + 3;
        if (d > 32)
        {

            d = d - 33;
        }
        charArray[i] = alfavit[d];
    }



}
string s = new string(charArray);
Console.WriteLine(s);