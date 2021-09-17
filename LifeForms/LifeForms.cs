using System;
using LifeEngine;

namespace LifeForms
{

    public class Human : LifeObject
    {
        int maxAge = 125;

        // How healthy is the Life form?
        public double HealthQuotient { get; set; }
        // How likeable is the life form?
        public double CharismaQuotient { get; set; }
        //Quotient to determine adherence to gender
        public double GenderQuotient { get; set; }

        public Human()
        {
            MaxAge = maxAge;

            Random r = new Random();

            // set random gender
            int randGender = r.Next(0, 4);

            Gender = (LifeFormGender)randGender;

            // set random gender adherence
            GenderQuotient = (r.NextDouble() * 100);

            // set random Charisma
            CharismaQuotient = (r.NextDouble() * 100);

            //set random health
            HealthQuotient = (r.NextDouble() * 100);
        }

    }



}
