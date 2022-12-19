namespace Portfolio.Services
{
    public class UniqueService
    {
        public UniqueService()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }
    public class DelimitateService
    {
        public DelimitateService()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }
    public class TransitoryService
    {
        public TransitoryService()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }

}
        

