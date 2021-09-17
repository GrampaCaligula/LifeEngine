using System;
using System.Collections.Generic;
using System.Text;

namespace LifeEngine
{
    public abstract class LifeObject : ILifeObject
    {
        // Constants
        public string Id { get; private set; }
        public bool IsAlive { get; set; }

        public int MaxAge { get; set; }
        public LifeFormGender Gender { get; set; }
        public int Age { get; set; }

        public LifeObject()
        {
            GenerateID();
            IsAlive = true;
        }

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

        private void GenerateID()
        {
            this.Id = Guid.NewGuid().ToString();
        }

    }


}
