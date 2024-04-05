internal class Program
{
    enum DayofWeek : uint
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturesday,
        Sunday
    }
    enum DayTime
    {
        Ночь = 0,
        Утро = 7,
        День = 13,
        Вечер = 18
    }
    static string Time(uint time, string txt)
    {
        if (time >= (uint)DayTime.Ночь & time < (uint)DayTime.Утро)
        {
            return txt + $", {DayTime.Ночь.ToString().ToLower()}";
        }
        else if (time >= (uint)DayTime.Утро & time < (uint)DayTime.День)
        {
            return txt + $", {DayTime.Утро.ToString().ToLower()}";
        }
        else if (time >= (uint)DayTime.День & time < (uint)DayTime.Вечер)
        {
            return txt + $", {DayTime.День.ToString().ToLower()}";
        }
        else if (time >= (uint)DayTime.Вечер & time < (uint)DayTime.Ночь)
        {
            return txt + $", {DayTime.Вечер.ToString().ToLower()}";
        }
        else
        {
            return txt + ", время неопределено";
        }
    }
    static string Day(uint day)
    {
        if (day == (uint)DayofWeek.Monday)
        {
            return $"Сейчас {DayofWeek.Monday.ToString().ToLower()}";
        }
        else if (day == (uint)DayofWeek.Tuesday)
        {
            return $"Сейчас {DayofWeek.Tuesday.ToString().ToLower()}";
        }
        else if (day == (uint)DayofWeek.Wednesday)
        {
            return $"Сейчас {DayofWeek.Wednesday.ToString().ToLower()}";
        }
        else if (day == (uint)DayofWeek.Thursday)
        {
            return $"Сейчас {DayofWeek.Thursday.ToString().ToLower()}";
        }
        else if (day == (uint)DayofWeek.Friday)
        {
            return $"Сейчас {DayofWeek.Friday.ToString().ToLower()}";
        }
        else if (day == (uint)DayofWeek.Saturesday)
        {
            return $"Сейчас {DayofWeek.Saturesday.ToString().ToLower()}";
        }
        else if (day == (int)DayofWeek.Sunday)
        {
            return $"Сейчас {DayofWeek.Sunday.ToString().ToLower()}";
        }
        else
        {
            return "День недели не определен";
        }
    }
    private static void Main(string[] args)
    {
        Console.Write($"Сейчас <день недели>:");
        uint day = Convert.ToUInt32(Console.ReadLine().ToLower());
        Console.Write("<время дня>:");
        uint time = Convert.ToUInt32(Console.ReadLine().ToLower());
        Console.WriteLine(Time(time, Day(day)));
    }
}