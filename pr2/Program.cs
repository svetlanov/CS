// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Jerry");
A();
Example();
Thread.Sleep(500);
Example();
Thread.Sleep(500);
Example();
Thread.Sleep(500);
A();

void Example()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    Console.WriteLine("Функция А");
    B();
    C();
}

void C()
{
    Console.WriteLine("Функция С");
}

void B()
{
    Console.WriteLine("Функция B");
}




