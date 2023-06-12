void Number1()
{
    Console.WriteLine("Введите первое число: ");
    int num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2=Convert.ToInt32(Console.ReadLine());
    int count=1;
    int num3=num;
    while(count<num2)
    {
        num3=num3*num;
        count++;
    }

    Console.WriteLine("Результат: "+ num3); 
}
void Number2()
{
    Console.WriteLine("Введите число: ");
    int num4 = Convert.ToInt32(Console.ReadLine());
    int sum=0;
    int num5=num4;
    while(num5>0)
    {
        sum=sum+num5%10;
        num5=num5/10;
    }
    Console.WriteLine("Сумма всех чисел: "+sum);
}
void Number3()
{
    System.Console.WriteLine("Массив сгенерирован: ");
    int[] array= new int[8];
    int count = 0;
    Console.Write("[");
    while(count<array.Length-1)
    {
        array[count]= new Random().Next(0,101);
        Console.Write(array[count]+",");
        count++;
    }
    array[count]= new Random().Next(0,101);
    Console.Write(array[count]+"]");
}
Console.WriteLine("Какое задание вас интересует?(1,2,3): ");
int menu=Convert.ToInt32(Console.ReadLine());
if(menu==1)
{
    Number1();
}
else if(menu==2)
{
    Number2();
}
else if(menu==3)
{
    Number3();
}
else
{
    Console.WriteLine("Такого задания нет");
}
