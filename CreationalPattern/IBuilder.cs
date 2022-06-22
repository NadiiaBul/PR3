using System;

namespace CreationalPattern
{
    interface IBuilder
    {
        void SetNumber(uint number);
        void SetDate(DateTime date);
        void SetInfo(params string[] info);
    }
}
