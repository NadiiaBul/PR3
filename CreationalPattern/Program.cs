using System;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            LetterBuilder letterBuilder = new LetterBuilder();
            director.Builder = letterBuilder;
            director.CreateDocument(1, DateTime.Parse("10.12.2021"), "true", "Shevchenko.N.M.");

            OfficialLetterBuilder officialLetterBuilder = new OfficialLetterBuilder();
            director.Builder = officialLetterBuilder;
            director.CreateDocument(2, DateTime.Parse("20.02.2022"), "Official letter");

            AppointmentBuilder appointmentBuilder = new AppointmentBuilder();
            director.Builder = appointmentBuilder;
            director.CreateDocument(3, DateTime.Parse("27.04.2022"), "27.05.2022", "unit 1");

            OrderLetterBuilder orderLetterBuilder = new OrderLetterBuilder();
            director.Builder = orderLetterBuilder;
            director.CreateDocument(4, DateTime.Parse("11.05.2022"), "11.06.2022", "unit 2", "Petrenko O.V.");

            ResourceRequestBuilder resourceRequestBuilder = new ResourceRequestBuilder();
            director.Builder = resourceRequestBuilder;
            director.CreateDocument(5, DateTime.Parse("05.05.2022"), "Tarapata M.O.", "resource 1, resourse 2, resourse 3");
        }
    }
}
