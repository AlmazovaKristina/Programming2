Console.Write("Введите цифру дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

void print(int day) {
    if (day < 1 || day > 7) {
        Console.WriteLine("Некорректное значение. Введите значение от 1 до 7.");
        return;
    }
    if (day == 6 || day == 7) {
        Console.WriteLine("Да");
    } else {
        Console.WriteLine("Нет");
    }
}

print(num);
