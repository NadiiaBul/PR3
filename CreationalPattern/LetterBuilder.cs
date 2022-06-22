using System;

namespace CreationalPattern
{
    class LetterBuilder : IBuilder
    {
        private readonly Letter _letter = new Letter();
        public void SetDate(DateTime date)
        {
            _letter.Date = date;
        }

        public void SetInfo(params string[] info)
        {
            _letter.Income = bool.Parse(info[0]);
            _letter.Correspondent = info[1];
        }

        public void SetNumber(uint number)
        {
            _letter.Number = number;
        }
        public Letter GetLetter()
        {
            return _letter;
        }
    }
}
