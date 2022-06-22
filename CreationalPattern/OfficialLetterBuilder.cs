using System;

namespace CreationalPattern
{
    class OfficialLetterBuilder : IBuilder
    {
        private readonly OfficialLetter _officialLetter = new OfficialLetter();
        public void SetDate(DateTime date)
        {
            _officialLetter.Date = date;
        }

        public void SetInfo(params string[] info)
        {
            _officialLetter.Text = info[0];
        }

        public void SetNumber(uint number)
        {
            _officialLetter.Number = number;
        }
        public OfficialLetter GetOfficialLetter()
        {
            return _officialLetter;
        }
    }
}
