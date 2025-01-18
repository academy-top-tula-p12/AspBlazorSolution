namespace BlazorInjectBindModelApp.Services
{
    public interface ITimeFormatter
    {
        string FormatTime();
    }

    public class TimeFormatter : ITimeFormatter
    {
        ITimeService _timeService;
        public TimeFormatter(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string FormatTime() => $"Current time: {_timeService.GetTime()}";
    }
}
