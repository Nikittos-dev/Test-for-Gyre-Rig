Task3:

interface ISomeInterface
{
    void Call();
}
struct SomeStruct : ISomeInterface
{
    public void Call()
    { 
    
    }
}
class SomeClass
{
    public void Run()
    {
        var someStruct = new SomeStruct();
        this.SomeMethod(someStruct);
    }
    public void SomeMethod(ISomeInterface @interface)
    {
        @interface.Call();
    }
}
Task4:
