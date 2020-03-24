using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;


namespace oop2sh
{
	class Row
	{
		private string row;
		
		public Row()
			{
				row = "";
			}
		public Row(string r)
		{
			row = r;
		}
		public char this[int index]
		{
			get
			{
				return row[index];
			}
		}
		public int length()
		{
			return row.Length;
		}
		public void set(string r)
		{
			row = r;
		}
		public string get()
		{
				return row;
		}
	}
	class Text
	{
		private List<Row> rows = new List<Row> { };

		public Text(Row r)
		{
			rows.Add(r);
		}
		public void addIt(Row r)
		{
			rows.Add(r);
		}
		public void deleteLast()
		{
			rows.RemoveAt(rows.Count-1);
		}
		public void clearIt()
		{
			rows.Clear();
		}
		public Row this[int index]
		{
			get 
			{
				return rows[index];
			}
			set
			{
				rows[index] = value;
			}
		}
		public float symFreq(char ch)
		{
			Row temp = new Row();
			float frequency = 0;
			float counter = 0;
			for (int i = 0; i < rows.Count; i++)
			{
				temp.set(rows[i].get());
				for (int j = 0; j < temp.length(); j++)
				{
					counter++;
					if (temp[j] == ch)
					{
						frequency++;
					}
				}
			}
			return frequency / counter;
		}
		public void deleteIt(int ind)
		{
			rows.RemoveAt(ind);
		}
		public void replace(int ind, Row r)
		{
			rows[ind] = r;
		}
		public void deleteDublicate()
		{
			bool flag = false;
			string temp;
			for (int i = 0; i < rows.Count; i++)
			{
				temp = rows[i].get();
				for (int j = i; j < rows.Count(); j++)
				{
					for (int k = 0; k < temp.Length && k < rows[j].get().Length; k++)
					{
						if (temp[k] != rows[j].get()[k])
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					deleteIt(i);
				}
				flag = false;
			}
		}
		public void Show()
		{
			Console.WriteLine("--------------------------------------\n");
			for (int i = 0; i < rows.Count; i++)
			{
				Console.WriteLine(rows[i].get(), "\n");
			}
			Console.WriteLine("--------------------------------------\n");
		}
}

class Program
    {
        static void Main(string[] args)
        {
        
		Row first = new Row("There once was a boy named Harry");
		Row second = new Row("Destined to be a star");
		Row third = new Row("His parents were killed by Voldemort");
		Row fourth = new Row("Who gave him a lightning scar");
		Text text = new Text(first);
		text.addIt(second);
		text.addIt(third);
		text.addIt(fourth);
		Console.WriteLine("Strings we added:\n");
		text.Show();
		Console.WriteLine("Enter symbol to search it's frequency - ");
		char ask = Convert.ToChar(Console.ReadLine());
		Console.WriteLine(Convert.ToString(text.symFreq(ask) * 100) + "%\n");
		Console.WriteLine("Enter which row to delete - \n");
		int del = Convert.ToInt32(Console.ReadLine());
		text.deleteIt(del-1);
		text.Show();
		Console.WriteLine("Entering first row to last row\n");
		text.addIt(first);
		text.Show();
		Console.WriteLine("Delete string dublicates\n");
		text.deleteDublicate();
		text.Show();
        }
    }
}
