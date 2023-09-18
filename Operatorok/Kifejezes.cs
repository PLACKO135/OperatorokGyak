using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Operatorok
{
    internal class Kifejezes
    {
        int elsoOperandus;
        string oPerator;
        int masodikOperandus;

        public Kifejezes(int elsoOperandus, string oPerator, int masodikOperandus)
        {
            this.elsoOperandus = elsoOperandus;
            this.oPerator = oPerator;
            this.masodikOperandus = masodikOperandus;
        }

        public int ElsoOperandus { get => elsoOperandus; }
        public string OPerator { get => oPerator; }
        public int MasodikOperandus { get => masodikOperandus; }
    }
}
