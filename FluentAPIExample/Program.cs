
namespace FluentAPIExample
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void UseAPI1()
        {
            var salesman = new API1.Salesman(Name: "Eric");
            salesman.UseBodySpray("Lidl Cien");
            salesman.GreetCustomer();
            salesman.MakePitch();
            salesman.OvercomeObjections();
            salesman.CloseSale();
        }

        static void UseAPI2()
        {
            var chainedSalesman = new API2.ChainedSalesman(Name: "Jon");
            chainedSalesman
                .UseBodySpray("Lynx Africa")
                .GreetCustomer()
                .MakePitch()
                .OvercomeObjections()
                .CloseSale();
        }

        static void UseAPI3()
        {
            API3.FluentSalesman
                .CreateWithName("Pete")
                .UseBodySpray("David Beckham")
                .And().UseOverpoweringAftershave()
                .GreetCustomer()
                .MakePitch()
                .OvercomeObjections()
                .CloseSale();
        }
    }
}
