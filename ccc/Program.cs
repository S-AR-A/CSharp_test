// get num 
//if read is not null continue
//else covert to int
do
{
    Console.WriteLine("gimme the int: ");
    string num_str = Console.ReadLine();
    if (num_str.Length == 0)
    {
        Console.WriteLine("no number received");
        continue;
    }
    else
    {
        int num_int = int.Parse(num_str);
        //convet to binary
        string num_bin = Convert.ToString(num_int, 2);
        // count 1s and 0s
        int zeros = num_bin.Count(c => c == '0');
        int ones = num_bin.Count(c => c == '1');
        //write the results      
        Console.Write($"it has {zeros} zeros and {ones} ones\n");
    }

} while (true);