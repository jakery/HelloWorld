using System;

namespace HelloWorld.Api.Factory
{
    public class HelloWorldFactory : HelloWorldFactoryBase
    {
        private ISettings settings;

        public HelloWorldFactory(ISettings configSettings = null)
        {
            settings = configSettings ?? new Settings();
        }

        public override IParadigm CreateHelloWorldGetter()
        {
            return CreateHelloWorldGetter(settings.defaultParadigm);
        }

        public override IParadigm CreateHelloWorldGetter(string paradigm)
        {
            try
            {
                var paradigmName = (ParadigmName)Enum.Parse(typeof(ParadigmName), paradigm, true);
                return CreateHelloWorldGetter(paradigmName);
            }
            catch (ArgumentException exception)
            {
                throw new ArgumentException("The paradigmName argument specified is not valid.", exception);
            }
        }


        public override IParadigm CreateHelloWorldGetter(ParadigmName? paradigm)
        {
            switch (paradigm)
            {
                case ParadigmName.Plaintext:
                    return new PlaintextParadigm();
                case ParadigmName.WebApi:
                    throw new NotImplementedException("The web API is not yet implemented.");
                case ParadigmName.Console:
                    throw new NotImplementedException("Console applications are not yet supported.");
                case ParadigmName.WindowsService:
                    throw new NotImplementedException("Windows services are not yet supported.");
                case ParadigmName.Mobile:
                    throw new NotImplementedException("Mobile Applications are not yet supported.");
                default:
                    throw new NotImplementedException("The selected ParadigmName is not yet supported.");
            }
        }

    }
}