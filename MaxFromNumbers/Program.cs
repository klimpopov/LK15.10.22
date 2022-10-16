int Max(int arg1, int arg2, int arg3) //Функция с 3-я аргументами.
{
    int result = arg1; //Приравниваем Результат к 1-ому аргументу.
    if (arg2>result) result = arg2; //Сравниваем
    if (arg3>result) result = arg3; //Сравниваем
    return result; //Выдаем результат.
}


int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33; // Переменные и их значения, которые у нас есть.

//int max1 = Max(a1,b1,c1); // Используем функцию Max(с подставленными соответствующими аргументами). Максимальное значение записываем в переменную max.
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);
int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));

Console.WriteLine (max);