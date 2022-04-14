namespace CounterTask
{
    public class Clock
    {
        private Counter _hours;
        private Counter _minutes;
        private Counter _seconds;

        //constructor that initializes all 3 values to 0
        public Clock()
        {
            _hours = new Counter("hours");
            _minutes = new Counter("minutes");
            _seconds = new Counter("seconds");
        }

        #region properties
        public Counter Hours
        { get { return _hours; } }
        
        public Counter Minutes
        { get { return _minutes; } }

        public Counter Seconds
        { get { return _seconds; } }
        #endregion

        public void Tick()
        {
            _seconds.Increment();
            if(_seconds.Tick >= 60)
            {
                _minutes.Increment();
                _seconds.Reset();
            }
            if (_minutes.Tick >= 60)
            {
                _hours.Increment();
                _minutes.Reset();
            }
        }

        public string GetTimeAsString()
        {
            string hoursString = _hours.Tick <= 10 ? $"0{_hours}" : _hours.ToString();
            string minutesString = _minutes.Tick <= 10 ? $"0{_minutes}" : _minutes.ToString();
            string secondsString = _seconds.Tick <= 10 ? $"0{_seconds}" : _seconds.ToString();

            return hoursString + ":" + minutesString + ":" + secondsString;
        }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }
    }
}
