using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Key
    {
        private int privateKey;
        public int[] PublicKey = new int[3];
    }

    class Signature
    {
        public int R { get; private set; }
        public int S { get; private set; }

        public Signature(int r,int s)
        {
            this.R = r;
            this.S = s;
        }
    }


    class Elgama
    {
        public void GenerateKey(int p,int g)
        {

        }

        public int[] Sign(string message,int x)
        {
            return new int[]{ };
        }

        public bool Verify(string message,Signature signature,int y)
        {
            return true;
        }







    }
}
