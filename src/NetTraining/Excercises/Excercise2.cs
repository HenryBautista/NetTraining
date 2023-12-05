namespace NetTraining.Exercises;

public class Excercise2
{
    public static string GetReadableTime(int seconds)
    {
        const int secondsOnAMinute = 60;
        const int secondsOnAnHour = 3600;

        int calculatedSeconds = seconds % secondsOnAMinute;
        int calculatedMinutes = (seconds % secondsOnAnHour) / secondsOnAMinute;
        int calculatedHours = seconds / secondsOnAnHour;

        return $"{calculatedHours:D2}:{calculatedMinutes:D2}:{calculatedSeconds:D2}";
    }
}