using System;
using System.Diagnostics;

namespace TraceSpy;

public static class TimeProvider
{
    private static readonly DateTime StartTime = DateTime.Now;
    private static readonly long StartTimestamp = Stopwatch.GetTimestamp();

    public static DateTime GetRelativeTime(long ticks)
    {
        var elapsedTicks = ticks - StartTimestamp;
        var elapsedSeconds = elapsedTicks / Stopwatch.Frequency;
        return StartTime.AddSeconds(elapsedSeconds);
    }
}