namespace Foo;
public class FooService : IFooService
{
  
  private readonly Foo foo = new Foo(1,"hello world");

    public string GetFoo(){ return foo.ToString(); }

    record Foo(int id, string blah);
}
