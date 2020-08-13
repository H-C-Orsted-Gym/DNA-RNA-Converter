using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DNA_RNA_Converter
{
	class Converter
	{

		private bool checkLength(int length)
		{
			int result = length % 3;

			if (result == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


        public static readonly Dictionary<char, char> RnaToDnaDictionary;

        static Converter() => RnaToDnaDictionary = new Dictionary<char, char>
            {
                { 'A', 'T'},
                { 'C', 'G' },
                { 'G', 'C' },
                { 'T', 'A' },
            };

        public static string From(string RNA)
        {
            var output = new StringBuilder();

            // for hver char i stringen
            for (int A = 0; A < RNA.Length; A++)
            {
                //for hvert bogstav i dictionariet
                foreach (var item in RnaToDnaDictionary)
                {

                    if (item.Key == RNA[A])
                    {
                        output.Append(item.Value);
                    }
                }

            }

            return output.ToString();
        }
    }
}


	
