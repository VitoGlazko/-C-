// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int function = Fackt(m, n);

Console.Write($"Функция Аккермана = {function} ");

int Fackt(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Fackt(m - 1, 1);
  else return Fackt(m - 1, Fackt(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
