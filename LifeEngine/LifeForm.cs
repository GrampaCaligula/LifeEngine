using System;
using System.Collections.Generic;
using System.Text;

namespace LifeEngine
{
    public abstract class LifeObject
    {
        public string Id { get; set; }
        private int LifeAge { get; set; }
        public bool IsAlive { get; set; }


        public LifeFormGender Gender { get; set; }

        // How healthy is the life form?
        public double HealthQuotient { get; set; }

        // How likeable is the life form?
        public double CharismaQuotient { get; set; }

        //Quotient to determine adherence to gender
        public double GenderQuotient { get; set; }

        /// <summary>
        /// Identifies life form gender
        /// </summary>
        public enum LifeFormGender
        {
            None,
            Male,
            Female,
            Both
        }

        public void IncrementAgeByMonth() 
        {
            if (VerifyIsAlive())
                this.LifeAge++;
        }

        public Decimal Age()
        {
                return (Convert.ToDecimal(this.LifeAge) / 10);
        }

        public void TerminateLifeForm()
        {
            if (VerifyIsAlive())
                this.IsAlive = false;

        }

        private bool VerifyIsAlive()
        {
            if (this.IsAlive)
                return true;
            else
                throw (new Exception("CODE: LIFEFORM TERMINATED"));
        }

    }

}
