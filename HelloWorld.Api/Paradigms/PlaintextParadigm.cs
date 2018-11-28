namespace HelloWorld.Api.Factory
{
    public class PlaintextParadigm : IParadigm
    {
        private string message = "Hello, world!";
        public PlaintextParadigm() { }

        public virtual string GetHelloWorld()
        {
            return message;
        }
    }
}