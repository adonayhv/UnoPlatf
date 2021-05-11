using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoPlatf.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoPlatf.App(), args);
            host.Run();
        }
    }
}
