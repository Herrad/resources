using StructureMap.Configuration.DSL;

namespace Resources.Web.StructureMap
{
    public class ResourcesStructureMapRegistry : Registry
    {
        public ResourcesStructureMapRegistry()
        {
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
        }
    }
}