namespace ZsutPwPatterns.WindowsApplication.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZsutPw.Patterns.WindowsApplication.Controller;
    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPw.Patterns.WindowsApplication.Utilities;

    public class Controler_LogicTests
    {
        [TestMethod]
        public void ShowList_ReturnsList() {

            Controller controler = new Controller(null, null);
            controler.ShowList(FakeApplicationState.state);

            ApplicationState state =  controler.CurrentState;
            Assert.AreEqual(ApplicationState.List, state,  "Node count should be {0} and not {1}", ApplicationState.List, state );
        }

    }
}
