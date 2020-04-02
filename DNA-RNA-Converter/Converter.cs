using System;
using System.Collections.Generic;
using System.Linq;
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
			} else
			{
				return false;
			}
		}

		public string ConvertToDNA(string input)
		{
			string inputStripped = input.Replace(" ", "");
			bool length = this.checkLength(inputStripped.Length);
			if (length == true)
			{
				string result = "";
				string inputEnter = inputStripped.ToUpper();

				foreach (char c in inputEnter)
				{
					if (c.ToString() == "U" || c.ToString() == "A" || c.ToString() == "C" || c.ToString() == "G")
					{
						if (c.ToString() == "U")
						{
							result = result + "A";
						}
						else if (c.ToString() == "A")
						{
							result = result + "T";
						}
						else if (c.ToString() == "C")
						{
							result = result + "G";
						}
						else if (c.ToString() == "G")
						{
							result = result + "C";
						}
					} else
					{
						return "203";
					}
				}

				return result;
			} else
			{
				return "202";
			}
		}


		public string ConvertToRNA(string input)
		{
			string inputStripped = input.Replace(" ", "");
			bool length = this.checkLength(inputStripped.Length);
			if (length == true)
			{
				string result = "";
				string inputEnter = inputStripped.ToUpper();

				foreach (char c in inputEnter)
				{
					if (c.ToString() == "U" || c.ToString() == "T" || c.ToString() == "C" || c.ToString() == "G")
					{
						if (c.ToString() == "U")
						{
							result = result + "A";
						}
						else if (c.ToString() == "T")
						{
							result = result + "A";
						}
						else if (c.ToString() == "G")
						{
							result = result + "C";
						}
						else if (c.ToString() == "C")
						{
							result = result + "G";
						}
					} else
					{
						return "203";
					}
				}

				return result;
			} else
			{
				return "202";
			}
		}
	}
}
