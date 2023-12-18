internal class Program
{
    static void MyThreadTurtle()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Черепаха прошла: " + i);
        }
    }
    private static void Main(string[] args)
    {
        Thread turtle = new(MyThreadTurtle);   В методе MyThreadTurtle определена функция, которая будет выполняться в отдельном потоке. В данном случае функция просто выводит на консоль сообщение о текущем шаге черепахи.
        turtle.Start();

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Кролик прошел: " + i);
        }
    }
}
