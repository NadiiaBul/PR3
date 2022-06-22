using System;

namespace CreationalPattern
{
    class Director
    {
        public IBuilder Builder { get; set; }
        public void CreateDocument(uint number, DateTime date, params string[] info)
        {
            Builder.SetNumber(number);
            Builder.SetDate(date);
            Builder.SetInfo(info);
        }
    }
}
