using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var elgamal = new ElGamal();

            // p must be prime, g a primitive root of p
            Key key = elgamal.GenerateKey(p: 23, g: 5);
            Console.WriteLine($"Private key x={key.X}, Public key y={key.Y}");

            string message = "Hello, ElGamal!";
            Signature sig = elgamal.Sign(message, key);
            Console.WriteLine($"Signature: {sig}");

            bool valid = elgamal.Verify(message, sig, key);
            Console.WriteLine($"Valid: {valid}");           // True

            bool tampered = elgamal.Verify("Tampered!", sig, key);
            Console.WriteLine($"Tampered valid: {tampered}"); // False
        }
    }
}
