
    void exc(int a)
    {
        if (a < 0)
            throw new Exception("jlskdjfljalf;dd");
    }
do
{
    Console.WriteLine("What is it?");
    var num = int.Parse(Console.ReadLine());
    try
    {
        exc(num);
    }
    catch(Exception e)
    {
        Console.WriteLine($"{e.Message}");
    }
} while (true);



