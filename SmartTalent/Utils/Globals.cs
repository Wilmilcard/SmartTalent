namespace SmartTalent.Utils
{
    public class Globals
    {
        public static DateTime ActualDate() => DateTime.UtcNow.AddHours(-5);
        public static string UserSystem() => "Smart Talent API";
        public static double Tax() => 0.19;
    }
}
