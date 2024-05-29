namespace Exercise315E
{
    internal class NumberGenerator
    {
        private int _startValue;
        private int _endValue;
        private int _change;
        private int _currentValue;

        public NumberGenerator(int startValue, int endValue, int change)
        {
            _change = change;
            _endValue = endValue;
            _startValue = startValue;
            _currentValue = startValue;
        }

        public int GetNumber()
        {
            return _currentValue;
        }

        public void Next()
        {
            var newCurrentValue = _currentValue + _change;
            if (newCurrentValue <= _endValue)
            {
                _currentValue = newCurrentValue;
            }
        }

        public void Previous()
        {
            var newCurrentValue = _currentValue - _change;
            if (newCurrentValue >= _startValue)
            {
                _currentValue = newCurrentValue;
            }
        }
    }
}
