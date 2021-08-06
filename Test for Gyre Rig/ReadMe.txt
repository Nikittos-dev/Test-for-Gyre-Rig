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

Task4: // что-то сложно для juna можно решение на почту потом скинуть, я не очень знаком с этой темой.
public struct ApiSetup<T>
{

}
class Api
{
    public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }
}
interface ISomeInterfaceA
{
    void SetupObjectA();
}
interface ISomeInterfaceB
{
    void SetupObjectB();
}
class ObjectA : ISomeInterfaceA
{
    public void SetupObjectA()
    {

    }
}
public class ObjectB : ISomeInterfaceB
{
    public void SetupObjectB()
    {

    }
}
class SomeClass : MonoBehaviour
{

    public void Setup()
    {
        Api apiObject = new Api();

        apiObject.For(new ObjectA()).SetupObjectA();
        apiObject.For(new ObjectB()).SetupObjectB();
    }
}
