namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TableDrivenVacuumAgent : VacuumAgent
    {
        private IDictionary<VacuumPerceptionList, VacuumAction> table;
        private VacuumPerceptionList perceptions = new VacuumPerceptionList();

        public TableDrivenVacuumAgent(IDictionary<VacuumPerceptionList, VacuumAction> table)
        {
            this.table = table;
        }

        public override VacuumAction GetAction(VacuumPerception perception)
        {
            this.perceptions.Add(perception);

            if (this.table.ContainsKey(this.perceptions))
                return this.table[this.perceptions];

            return VacuumAction.NoOp;
        }
    }
}
