namespace BlazorInjectBindModelApp.Services
{
    public interface ITimeService
    {
        string GetTime();
    }

    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
