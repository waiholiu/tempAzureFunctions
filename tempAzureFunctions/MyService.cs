using System;
using System.Collections.Generic;
using System.Text;

namespace tempAzureFunctions
{
    public interface  IMyService
    {
        string MyMethod();

    }

    public class MyService : IMyService
    {
        public string MyMethod()
        {
            return "hello";
        }

    }
}
