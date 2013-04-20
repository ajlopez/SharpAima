namespace SharpAmia.Tests.Agents
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAmia.Agents;

    [TestClass]
    public class TableDrivenVacuumAgentTests
    {
        [TestMethod]
        public void GetActionFromSimplePerception()
        {
            VacuumPerceptionList list = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean));
            IDictionary<VacuumPerceptionList, VacuumAction> table = new Dictionary<VacuumPerceptionList, VacuumAction>();

            table[list] = VacuumAction.Left;

            TableDrivenVacuumAgent agent = new TableDrivenVacuumAgent(table);

            Assert.AreEqual(VacuumAction.Left, agent.GetAction(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean)));
        }

        [TestMethod]
        public void GetActionFromTwoPerceptions()
        {
            VacuumPerceptionList list1 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean));
            VacuumPerceptionList list2 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean), new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty));
            IDictionary<VacuumPerceptionList, VacuumAction> table = new Dictionary<VacuumPerceptionList, VacuumAction>();

            table[list1] = VacuumAction.Left;
            table[list2] = VacuumAction.Right;

            TableDrivenVacuumAgent agent = new TableDrivenVacuumAgent(table);

            Assert.AreEqual(VacuumAction.Left, agent.GetAction(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean)));
            Assert.AreEqual(VacuumAction.Right, agent.GetAction(new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty)));
        }

        [TestMethod]
        public void GetNoOpActionWhenEmptyTable()
        {
            IDictionary<VacuumPerceptionList, VacuumAction> table = new Dictionary<VacuumPerceptionList, VacuumAction>();

            TableDrivenVacuumAgent agent = new TableDrivenVacuumAgent(table);

            Assert.AreEqual(VacuumAction.NoOp, agent.GetAction(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean)));
            Assert.AreEqual(VacuumAction.NoOp, agent.GetAction(new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty)));
        }
    }
}
