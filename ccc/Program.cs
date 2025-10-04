using System.Reflection.Metadata.Ecma335;

System.Console.WriteLine
(
    Appointment.AnniversaryDate()
);
class Appointment()
{
    public DateTime Datetime { get; set; }
    public static DateTime Schedule(string s) => DateTime.Parse(s);
    public static Boolean HasPassed(DateTime dt)
    {
        if (DateTime.Now.CompareTo(dt) > 0) return true;
        else return false;
    }
    public static bool IsAfternoonAppointment(DateTime dt)
    => (dt.Hour < 18 && dt.Hour >= 12);
    public static string Description(DateTime dt)
        => $"You have an appointment on {dt}";

    public static DateTime AnniversaryDate()
    => new(DateTime.Now.Year, 9, 15, 0, 0, 0);
    
}