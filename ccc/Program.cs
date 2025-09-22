// get number of element
var n_o_elem = int.Parse(Console.ReadLine());
//get the array
var numbers = new int[n_o_elem];
for (int i = 0; i < n_o_elem; i++)
{
    Console.Write($"give me elemenet number{i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
var num_freq = new Dictionary<int, int> { };

foreach (var key in numbers)
{
    //if doesn't keys.contain count
    if (!num_freq.ContainsKey(key))
    {
        int count = 0;
        foreach (var num in numbers)
        {
            if (num == key)
            {
                count++;
            }
        }
        num_freq[key] = count;
    }
}
foreach (var nf in num_freq)
{
    Console.WriteLine($"{nf}");
}













