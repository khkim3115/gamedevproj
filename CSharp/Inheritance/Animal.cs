using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal : IAttackable
    {
        public static string Species = string.Empty;
        
        

        public void Attack()
        {
            Console.WriteLine($"동물 {Species} (이)가 공격했다.");
        }

        
    }
}
