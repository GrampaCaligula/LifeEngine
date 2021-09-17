using LifeEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeFormTypes
{
    class IReptiles : ILifeObject
    {
        public LifeObject.LifeFormGender Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Id => throw new NotImplementedException();

        public bool IsAlive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxAge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void TerminateLifeForm()
        {
            throw new NotImplementedException();
        }
    }
}
