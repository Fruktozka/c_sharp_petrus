/*
 * У всіх завданнях даного пункту потрібно вивести логічне значення True, 
 * якщо приведений вислів для запропонованих початкових даних є істинним, 
 * і значення False у супротивному випадку. Всі числа, для яких вказано 
 * кількість цифр (двозначне число, тризначне число і т.д.), вважаються цілими.
 *   19.	Дані координати (як цілі від 1 до 8) двох різних полів шахівниці. 
 *       Якщо слон за один хід може перейти з одного поля на інше, 
 *       вивести логічне значення True, інакше вивести значення False.
 */

int x1 = 0;
int y1 = 0;
int x2 = 0;
int y2 = 0;

while (x1 < 1 || x1 > 8) {
    Console.WriteLine("input x1 from 1 to 8");
    x1 = Convert.ToInt32(Console.ReadLine());
}

while (y1 < 1 || y1 > 8) {
    Console.WriteLine("input y1 from 1 to 8");
    y1 = Convert.ToInt32(Console.ReadLine());
}

while (x2 < 1 || x2 > 8) {
    Console.WriteLine("input x2 from 1 to 8");
    x2 = Convert.ToInt32(Console.ReadLine());
}

while (y2 < 1 || y2 > 8) {
    Console.WriteLine("input y2 from 1 to 8");
    y2 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("x1 = " + x1 + " y1 = " + y1 + " x2 = " + x2 + " y2 = " + y2);

if (Math.Abs(x2-x1) == Math.Abs(y2-y1))
{ 
    Console.WriteLine(true);
} else {
    Console.WriteLine(false);
}


