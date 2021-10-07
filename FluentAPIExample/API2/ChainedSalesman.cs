namespace FluentAPIExample.API2
{
    public class ChainedSalesman
    {
        public ChainedSalesman(string Name)
        {

        }
        public ChainedSalesman UseBodySpray(string Deodorant) { return this; }
        public ChainedSalesman GreetCustomer() { return this; }
        public ChainedSalesman MakePitch() { return this; }
        public ChainedSalesman OvercomeObjections() { return this; }
        public void CloseSale() { }
    }
}
