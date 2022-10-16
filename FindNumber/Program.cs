int [] array = {1, 12, 31, 4, 15, 16, 17, 18}; //Задаём массив

int n = array.Length; //Выявляет длину массива
int find = 18; //Ищем это число

int index = 0; //Позиция элемента

while (index<n)
{
    if(array[index] == find) //Ищем совпадение с числом 
    {
        Console.WriteLine(index); //Выводим индекс числа
    }
    index++; //Увеличиваем счётчик на 1
}