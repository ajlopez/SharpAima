namespace SharpAmia.Tests.Agents
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAmia.Agents;

    [TestClass]
    public class ModelBasedVacuumAgentTests
    {
        [TestMethod]
        public void GetActionWhenLocationIsDirty()
        {
            ModelBasedVacuumAgent agent = new ModelBasedVacuumAgent();
            VacuumPerception perception1 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Dirty);
            VacuumPerception perception2 = new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty);

            Assert.AreEqual(VacuumAction.Suck, agent.GetAction(perception1));
            Assert.AreEqual(VacuumAction.Suck, agent.GetAction(perception2));
        }
    }
}
