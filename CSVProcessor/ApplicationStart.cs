using Unity;

namespace CSVProcessor
{
    public class ApplicationStart
    {
        public static UnityContainer Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<ICSVReader, CSVReader>();

            return container;
        }
    }
}