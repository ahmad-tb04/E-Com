using Microsoft.Extensions.DependencyInjection;




namespace E_Com.Infrastructure
{
    public static class infrastructureRegisteration
    {
        public static IServiceCollection infrastructureConfiguration(this IServiceCollection services)
        {
            return services;
        }
    }

    interface IToolUse {

        public void SetHammer(Hammer hammer);
        public void SetNail(Nail nail);
    }

    public class Builder : IToolUse
    {
        private Hammer _hammer;
        private Nail _nail;

        public Builder(Hammer hammer , Nail nail)
        {
            _Hammer = hammer;
            _Nail = nail;
        }

        public void Build()
        {
            Console.WriteLine("hammer");
        }

        public void Buildhouse()
        {
            _Hammer.Use();
            _Nail.Use();
        }
    }
    public class Hammer {

        public void Use()
        {
            Console.WriteLine("hammring");
        }
    }

    public class Nail { 
    
    public void Use()
        {
            Console.WriteLine("nailed");
        }
    }

}
