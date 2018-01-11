using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chat.Utility;
using Chat.Interfaces;
using Chat.Stub;

namespace Chat.Tests
{   
    public static class Test
    {
        public static void SetUp()
        {
            ServiceContainer.Register<IWebService>(() => new StubWebService { SleepDuration = 0 });
            ServiceContainer.Register<ISettings>(() => new StubSettings());
        }
    }
}
