namespace SharpAmia.Tests.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAmia.Agents;

    [TestClass]
    public class RandomVacuumAgentTests
    {
        [TestMethod]
        public void GetOneAction()
        {
            RandomVacuumAgent agent = new RandomVacuumAgent();
            VacuumPerception perception = new VacuumPerception(VacuumLocation.A, VacuumLocationState.Clean);

            var result = agent.GetAction(perception);

            Assert.IsTrue(result == VacuumAction.NoOp || result == VacuumAction.Left || result == VacuumAction.Rigth || result == VacuumAction.Suck);
        }
    }
}
