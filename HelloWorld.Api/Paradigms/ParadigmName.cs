using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Api.Factory
{
    // See README.md for explanation of this design choice.
    public enum ParadigmName
    {
        Plaintext,
        WebApi,
        Console,
        WindowsService,
        Mobile
    }
}