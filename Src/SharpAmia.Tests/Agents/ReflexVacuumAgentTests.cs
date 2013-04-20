namespace SharpAmia.Tests.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAmia.Agents;

    [TestClass]
    public class ReflexVacuumAgentTests
    {
        [TestMethod]
        public void GetActionWhenLocationIsDirty()
        {
            ReflexVacuumAgent agent = new ReflexVacuumAgent();
            VacuumPerception perception1 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Dirty);
            VacuumPerception perception2 = new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty);

            Assert.AreEqual(VacuumAction.Suck, agent.GetAction(perception1));
            Assert.AreEqual(VacuumAction.Suck, agent.GetAction(perception2));
        }

        [TestMethod]
        public void GetActionWhenLocationIsClean()
        {
            ReflexVacuumAgent agent = new ReflexVacuumAgent();
            VacuumPerception perception1 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean);
            VacuumPerception perception2 = new VacuumPerception(VacuumLocation.B, VacuumStatus.Clean);

            Assert.AreEqual(VacuumAction.Right, agent.GetAction(perception1));
            Assert.AreEqual(VacuumAction.Left, agent.GetAction(perception2));
        }
    }
}
