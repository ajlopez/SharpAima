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
            VacuumPerception perception = new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean);

            var result = agent.GetAction(perception);

            Assert.IsTrue(result == VacuumAction.NoOp || result == VacuumAction.Left || result == VacuumAction.Right || result == VacuumAction.Suck);
        }

        [TestMethod]
        public void GetOneHundredActions()
        {
            RandomVacuumAgent agent = new RandomVacuumAgent();
            VacuumPerception perception = new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean);

            IList<VacuumAction> actions = new List<VacuumAction>();

            for (int k = 0; k < 100; k++)
                actions.Add(agent.GetAction(perception));

            Assert.IsTrue(actions.Any(action => action == VacuumAction.NoOp));
            Assert.IsTrue(actions.Any(action => action == VacuumAction.Suck));
            Assert.IsTrue(actions.Any(action => action == VacuumAction.Left));
            Assert.IsTrue(actions.Any(action => action == VacuumAction.Right));
        }
    }
}
