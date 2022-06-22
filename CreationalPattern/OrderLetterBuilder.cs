using System;

namespace CreationalPattern
{
    class OrderLetterBuilder : IBuilder
    {
        private readonly OrderLetter _orderLetter = new OrderLetter();
        public void SetDate(DateTime date)
        {
            _orderLetter.Date = date;
        }

        public void SetInfo(params string[] info)
        {
            _orderLetter.Deadline = DateTime.Parse(info[0]);
            _orderLetter.Unit = info[1];
            _orderLetter.Executant = info[2];
        }

        public void SetNumber(uint number)
        {
            _orderLetter.Number = number;
        }
        public OrderLetter GetOrderLetter()
        {
            return _orderLetter;
        }
    }
}
