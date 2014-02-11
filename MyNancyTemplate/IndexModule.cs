using Nancy;

namespace MyNancyTemplate
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return "Hi";
            };
        }
    }
}