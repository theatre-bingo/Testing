using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormsAssignment2.Utils
{
    public static class IdGenerator
    {
        private static Random random = new Random();

        public static string GenerateId(string prefix, int length = 6)
        {
            //generate random numeric string
            string numbers = "";
            for (int i = 0; i < length; i++)
            {
                numbers += random.Next(0,10);
            }
            return $"{prefix}{numbers}";
        }
    }
}
