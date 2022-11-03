namespace ZsutPwPatterns.Application.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZsutPw.Patterns.Application.Controller;
    [TestClass]
    public class Controller_LogicTests
    {

        [TestMethod]
        public void ShowList_ReturnsList()
        {

            Controller controler = new Controller(null, null);
            controler.ShowList(FakeApplicationState.stateNotList);

            ApplicationState state = controler.CurrentState;
            Assert.AreEqual(ApplicationState.List, state, "Application stateNotList should be {0} and not {1}", ApplicationState.List, state);
        }


    }
}
