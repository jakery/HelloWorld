using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Api.Tests.Mocks
{
    class MockSettings : ISettings
    {
        public string defaultParadigm => "plaintext";
    }
}
