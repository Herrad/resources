using StructureMap;

namespace Resources.Web.StructureMap
{
    public class ResourcesStructureMapConfiguration
    {
        public void Configure()
        {
            ObjectFactory.Configure(x => x.AddRegistry<ResourcesStructureMapRegistry>());
        }
    }
}