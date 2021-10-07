namespace FluentAPIExample.API3
{
    public interface ICanUseSmelly {
        /// <summary>
        /// You really need to get rid of that BO
        /// </summary>
        /// <param name="Deodorant">Name of deodorant</param>
        /// <returns></returns>
        ICanGreetCustomer UseBodySpray(string Deodorant);
        ICanGreetCustomer UseOverpoweringAftershave();
    }

    public interface ICanGreetCustomer
    {
        ICanMakePitch GreetCustomer();
        ICanUseSmelly And();
    }

    public interface ICanMakePitch
    {
        ICanOvercomeObjections MakePitch();
    }

    public interface ICanOvercomeObjections
    {
        ICanCloseSale OvercomeObjections();
    }

    public interface ICanCloseSale
    {
        void CloseSale();
    }

    public sealed class FluentSalesman : ICanUseSmelly, ICanGreetCustomer, ICanMakePitch, ICanOvercomeObjections, ICanCloseSale
    {
        private FluentSalesman()
        {

        }

        public static ICanUseSmelly CreateWithName(string Name)
        {
            return new FluentSalesman();
        }

        
        public ICanGreetCustomer UseBodySpray(string Deodorant)
        {
            return this;
        }

        public ICanGreetCustomer UseOverpoweringAftershave()
        {
            return this;
        }

        public ICanMakePitch GreetCustomer()
        {
            return this;
        }

        public ICanUseSmelly And()
        {
            return this;
        }

        public ICanOvercomeObjections MakePitch()
        {
            return this;
        }

        public ICanCloseSale OvercomeObjections()
        {
            return this;
        }

        public void CloseSale()
        {
            
        }

    }
}
