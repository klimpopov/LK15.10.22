int Max(int arg1, int arg2, int arg3) //Функция с 3-я аргументами.
{
    int result = arg1; //Приравниваем Результат к 1-ому аргументу.
    if (arg2>result) result = arg2; //Сравниваем
    if (arg3>result) result = arg3; //Сравниваем
    return result; //Выдаем результат.
}// Индексы:     0  1  2  3  4  5  6  7  8
int [] array = {11,21,31,41,15,61,17,18,19}; //Задаём массив

//Используем функцию с массивом
int max = Max(
    Max(array[0], array[1],array[2]), 
    Max(array[3], array[4],array[5]),
    Max(array[6], array[7],array[8])
);
Console.WriteLine(max);
