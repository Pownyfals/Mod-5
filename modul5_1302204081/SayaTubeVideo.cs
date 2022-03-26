using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204081
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;
		

		public SayaTubeVideo(String title)
		{
			int totalStrJudul = title.Length;
			
			if (totalStrJudul <= 200 & title != null&& title != "")
			{
				this.title = title;
			}
			else
			{
				Console.WriteLine("Judul Invalid");
				Console.WriteLine("Judul tidak kosong dan karakter judul tidak boleh lebih dari 200 karakter");
			}


			//mengenerate id number 5 digit
			Random generator = new Random();
			int randNum = generator.Next(100000);
			string fiveDigitsNumber = randNum.ToString("D5");
			this.id = Int32.Parse(fiveDigitsNumber);
			//mengisi playcount = 0
			this.playCount = 0;

		}

		public void increasePlayCount(int playCount)
		{
			try
			{
				if(playCount <= 25000000 && playCount > 0)
				{
				this.playCount = playCount;
				}
				else
				{
					Console.WriteLine("invalid PlayCount");
				}
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
		public int getPlayCount()
		{
			return this.playCount;
		}
		public string getTitle()
		{
			return this.title;
		}
		public void PrintVideoDetails()
		{
			Console.WriteLine("Judul Video = " + this.title);
			
		}
	}
}
