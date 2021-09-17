using System;
using System.Collections.Generic;
using System.Text;
using LifeForms;


namespace LifeFormApplication
{
    public static class LifeFactory
    {
        public static IHuman CreateNewHuman()
        {
            return new Human();
        }
    }
}
