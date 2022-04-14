namespace CounterTask
{
    public class Clock
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        //constructor that initializes all 3 values to 0
        public Clock()
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
        }

        #region properties
        public int Hours
        { get { return _hours; } }
        
        public int Minutes
        { get { return _minutes; } }

        public int Seconds
        { get { return _seconds; } }
        #endregion

        public void Tick()
        {
            _seconds++;
            if(_seconds >= 60)
            {
                _minutes++;
                _seconds = 0;
            }
            if (_minutes >= 60)
            {
                _hours++;
                _minutes = 0;
            }
        }

        public string GetTimeAsString()
        {
            string hoursString = _hours <= 10 ? $"0{_hours}" : _hours.ToString();
            string minutesString = _minutes <= 10 ? $"0{_minutes}" : _minutes.ToString();
            string secondsString = _seconds <= 10 ? $"0{_seconds}" : _seconds.ToString();

            return hoursString + ":" + minutesString + ":" + secondsString;
        }

        public void Reset()
        {
            _seconds = 0;
            _minutes = 0;
            _hours = 0;
        }
    }
}
