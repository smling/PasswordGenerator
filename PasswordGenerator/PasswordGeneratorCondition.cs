using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PasswordGeneratorCondition
    {
        public int UppercaseCount { get; set; }
        public int LowercaseCount { get; set; }
        public int AlphanCharacterCount { get; set; }
        public int DigitCount { get; set; }

        public PasswordGeneratorCondition()
        {
            this.UppercaseCount = 2;
            this.LowercaseCount = 3;
            this.AlphanCharacterCount = 3;
            this.DigitCount = 2;
        }
    }
}
