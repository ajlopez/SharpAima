namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VacuumPerceptionList
    {
        private static int hashcode = typeof(VacuumPerceptionList).GetHashCode();

        private IList<VacuumPerception> perceptions = new List<VacuumPerception>();

        public VacuumPerceptionList(params VacuumPerception[] perceptions)
        {
            foreach (var perception in perceptions)
                this.perceptions.Add(perception);
        }

        public void Add(VacuumPerception perception)
        {
            this.perceptions.Add(perception);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is VacuumPerceptionList)
            {
                var list = (VacuumPerceptionList)obj;

                if (this.perceptions.Count != list.perceptions.Count)
                    return false;

                for (int k = 0; k < this.perceptions.Count; k++)
                    if (!this.perceptions[k].Equals(list.perceptions[k]))
                        return false;

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int result = hashcode;

            foreach (var perception in this.perceptions)
            {
                result *= 17;
                result += perception.GetHashCode();
            }

            return result;
        }
    }
}
