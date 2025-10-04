using System.Runtime.CompilerServices;

Console.WriteLine(DialingCodes.FindLongestCountryName(
  DialingCodes.GetExistingDictionary()));
class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => [];
    public static Dictionary<int, string> GetExistingDictionary() =>
    new() { { 1, "US" }, { 55, "Brazil" }, { 91, "India" } };

    public static Dictionary<int, string>
    AddCountryToEmptyDictionary
    (
        int code,
        string name,
        Dictionary<int, string> dict
    )
    {
        dict.Add(code, name);
        return dict;
    }

    public static Dictionary<int, string>
        AddCountryToExistingDictionary
       (
           Dictionary<int, string> dict,
            int code,
           string name
       )
    {
        return dict = new()
        {
            { 1, "US" },
            { 55, "Brazil" },
            { 91, "India" },
            { code, name }
        };
    }
    public static string GetCountryNameFromDictionary
    (Dictionary<int, string> dict, int code)
    {
        if (dict.TryGetValue(code, out string? value)) return value;
        else return "No such key available";
    }
    public static Dictionary<int, string> UpdateDictionary
    (
        Dictionary<int, string> d,
        int code,
        string new_s
    )
    {
        //if exist change
        if (d.TryGetValue(code, out string? value))
        {
            d[code] = new_s;
            return d;
        }
        //else no change
        else return d;
    }
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> d, int code
    )
    {
        d.Remove(code);
        return d;
    }
    public static string FindLongestCountryName(
        Dictionary<int, string> d)
    {
        int the_key = -1;
        int max_length = -1;
        foreach (var item in d)
        {
            if (item.Value.Length > max_length)
            {
                max_length = item.Value.Length;
                the_key = item.Key;
            }
        }
        return d[the_key];   
    }

}