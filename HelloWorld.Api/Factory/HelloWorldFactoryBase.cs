namespace HelloWorld.Api.Factory
{
    public abstract class HelloWorldFactoryBase
    {
        public abstract IParadigm CreateHelloWorldGetter();
        public abstract IParadigm CreateHelloWorldGetter(string paradigm);
        public abstract IParadigm CreateHelloWorldGetter(ParadigmName? applicationParadigm);
    }
}