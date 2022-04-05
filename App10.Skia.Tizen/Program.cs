using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace App10.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new App10.App(), args);
            host.Run();
        }
    }
}
