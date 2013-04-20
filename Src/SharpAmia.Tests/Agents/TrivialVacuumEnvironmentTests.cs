namespace SharpAmia.Tests.Agents
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAmia.Agents;

    [TestClass]
    public class TrivialVacuumEnvironmentTests
    {
        [TestMethod]
        public void GetAgentPerception()
        {
            TrivialVacuumEnvironment environment = new TrivialVacuumEnvironment();
            environment.SetStatus(VacuumLocation.A, VacuumStatus.Clean);
            var agent = new RandomVacuumAgent();
            agent.Location = VacuumLocation.A;

            var result = environment.GetPerception(agent);

            Assert.AreEqual(VacuumLocation.A, result.Location);
            Assert.AreEqual(VacuumStatus.Clean, result.Status);
        }

        [TestMethod]
        public void ExecuteSuckActionOnDirtyStatus()
        {
            TrivialVacuumEnvironment environment = new TrivialVacuumEnvironment();
            environment.SetStatus(VacuumLocation.A, VacuumStatus.Dirty);
            var agent = new RandomVacuumAgent();
            agent.Location = VacuumLocation.A;

            environment.ExecuteAction(agent, VacuumAction.Suck);

            Assert.AreEqual(VacuumLocation.A, agent.Location);
            Assert.AreEqual(10, agent.Performance);
            Assert.AreEqual(VacuumStatus.Clean, environment.GetStatus(VacuumLocation.A));
        }

        [TestMethod]
        public void ExecuteSuckActionOnCleanStatus()
        {
            TrivialVacuumEnvironment environment = new TrivialVacuumEnvironment();
            environment.SetStatus(VacuumLocation.A, VacuumStatus.Clean);
            var agent = new RandomVacuumAgent();
            agent.Location = VacuumLocation.A;

            environment.ExecuteAction(agent, VacuumAction.Suck);

            Assert.AreEqual(VacuumLocation.A, agent.Location);
            Assert.AreEqual(0, agent.Performance);
            Assert.AreEqual(VacuumStatus.Clean, environment.GetStatus(VacuumLocation.A));
        }

        [TestMethod]
        public void ExecuteRightAction()
        {
            TrivialVacuumEnvironment environment = new TrivialVacuumEnvironment();
            environment.SetStatus(VacuumLocation.A, VacuumStatus.Clean);
            var agent = new RandomVacuumAgent();
            agent.Location = VacuumLocation.A;

            environment.ExecuteAction(agent, VacuumAction.Right);

            Assert.AreEqual(VacuumLocation.B, agent.Location);
            Assert.AreEqual(-1, agent.Performance);
            Assert.AreEqual(VacuumStatus.Clean, environment.GetStatus(VacuumLocation.A));
        }

        [TestMethod]
        public void ExecuteLeftAction()
        {
            TrivialVacuumEnvironment environment = new TrivialVacuumEnvironment();
            environment.SetStatus(VacuumLocation.A, VacuumStatus.Clean);
            var agent = new RandomVacuumAgent();
            agent.Location = VacuumLocation.B;

            environment.ExecuteAction(agent, VacuumAction.Left);

            Assert.AreEqual(VacuumLocation.A, agent.Location);
            Assert.AreEqual(-1, agent.Performance);
            Assert.AreEqual(VacuumStatus.Clean, environment.GetStatus(VacuumLocation.A));
        }
    }
}
