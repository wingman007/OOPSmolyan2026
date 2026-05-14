using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace OOPSmolyan2026
{
    internal class Executor
    {
        IIntroducable entity;

        public IIntroducable Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public Executor(IIntroducable entity)
        {
            this.entity = entity;
        }

        public void MakeItSpeak()
        {
            Console.WriteLine("------------- Hahahha I will make you speak! ----------------");
            entity.Introduce();
        }
    }
}

