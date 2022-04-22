namespace Calculator.DpMark.Logic
{
    public class Calculator
    {

        private decimal _individualAssignment;

        private decimal _groupAssignment;

        private decimal _testMark;

        public Calculator(decimal individualAssignment, decimal groupAssignment, decimal testMark)
        {
            _individualAssignment = individualAssignment;
            _groupAssignment = groupAssignment;
            _testMark = testMark;
        }

        public decimal DpMark { get; private set; }

        public void Calculate()
        {
            DpMark = _individualAssignment + _groupAssignment+ _testMark;
        }
    }
}