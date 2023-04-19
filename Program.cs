int UserInput (string message)
{
    Console.Write(message + "... ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (string[] arr)
{
    Console.Write("[");
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1) 
            Console.Write(", ");
        else
            Console.WriteLine("]\n");
    }
}

int CountNewLength(string[] sourceArray, int strLength)
{
    int newArrayLength = 0;

    for (int i = 0; i < sourceArray.Length; i++)
        if (sourceArray[i].Length <= strLength) newArrayLength++;

    return newArrayLength;
}

void FillNewArray (string[] sourceArray, int strLength, string[] newArray)
{
    int count = 0;

    for (int i = 0; i < sourceArray.Length; i++)
        if (sourceArray[i].Length <= strLength) 
        {
            newArray[count] = sourceArray[i];
            count++;
        }
}

string[] myArray = new string[] {
"Агафья", "Аглая", "Агния", "Агриппина", "Аза", "Акулина", "Алевтина", 
"Александра", "Алина", "Алиса", "Алла", "Анастасия", "Ангелина", 
"Анжела", "Анжелика", "Анна", "Антонина", "Анфиса", "Валентина", "Валерия", 
"Варвара", "Василиса", "Вера", "Вероника", "Виктория", "Владимира", "Галина", 
"Глафира", "Гликерия", "Дана", "Дарья", "Евгения", "Евдокия", "Евлалия", "Евлампия", 
"Евпраксия", "Евфросиния", "Екатерина", "Елена", "Елизавета", "Епистима", "Ермиония", 
"Жанна", "Зинаида", "Злата", "Зоя", "Инга", "Инесса", "Инна", "Иоанна", "Ираида", "Ирина", 
"Ия", "Капитолина", "Карина", "Каролина", "Кира", "Клавдия", "Ксения", "Лада", "Лариса", 
"Лидия", "Лилия", "Любовь", "Людмила", "Маргарита", "Марина", "Мария", "Марфа", "Матрёна", 
"Милана", "Милица", "Мирослава", "Надежда", "Наталья", "Нина", "Нонна", "Оксана", "Октябрина", 
"Олимпиада", "Ольга", "Павлина", "Пелагея", "Пинна", "Полина", "Прасковья", "Рада", "Раиса", 
"Регина", "Римма", "Рогнеда", "Руслана", "Светлана", "Серафима", "Снежана", "София", "Сусанна", 
"Таисия", "Тамара", "Татьяна", "Улита", "Ульяна", "Урсула", "Фаина", "Феврония", "Фёкла", 
"Феодора", "Целестина", "Юлия", "Яна", "Ярослава" 
};

System.Console.WriteLine("ИМЕЕТСЯ СПИСОК РУССКИХ ЖЕНСКИХ ИМЁН (111 штук):");
PrintArray(myArray);

int strLength = UserInput("Введите длину имени для нового списка (меньше или равно)");

string[] newArray = new string[CountNewLength(myArray, strLength)];
FillNewArray (myArray, strLength, newArray);

System.Console.WriteLine($"\nНОВЫЙ СПИСОК ИМЁН с длиной имени меньше или равно {strLength} (всего {newArray.Length} штук):");
PrintArray(newArray);
