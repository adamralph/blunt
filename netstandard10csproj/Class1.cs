namespace netstandard10csproj
{
    using LiteGuard;

    public class Class1
    {
        public void Foo(string bar)
        {
            Guard.AgainstNullArgument(nameof(bar), bar);
        }
    }
}
namespace LiteGuard
{
}
