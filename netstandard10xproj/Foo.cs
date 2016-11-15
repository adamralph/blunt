#if NET45CSPROJ
namespace net45csproj
#elif NET45XPROJ
namespace net45xproj
#elif NETSTANDARD10CSPROJ
namespace netstandard10csproj
#elif NETSTANDARD10XPROJ
namespace netstandard10xproj
#endif
{
    public class Foo
    {
        public static void Bar(string baz)
        {
            // TODO: add some code which smoke tests compilation against your package
        }
    }
}
