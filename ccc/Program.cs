//get the string
while (true)
{
    int s_ts()
    {
        var input = Console.ReadLine();
        string[] nums = input.Split(',');

        var a = int.Parse(nums[0].Trim());
        var b = int.Parse(nums[1].Trim());

        //if  not  the same compute sum
        if (a == b) return 3 * (a + b);
        //else triple sum
        else return a + b;
    }

    Console.WriteLine($"this is your anwser: {s_ts()}");
}