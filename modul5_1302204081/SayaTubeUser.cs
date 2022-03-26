using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204081
{
	public class SayaTubeUser
	{
		private int id;
		private LinkedList<SayaTubeVideo> uploadedVideo;
		private String username;
		

		public SayaTubeUser(string user)
		{
			this.uploadedVideo = new LinkedList<SayaTubeVideo>();
			this.username = user;

			//mengenerate id number 5 digit
			Random generator = new Random();
			int randNum = generator.Next(100000);
			string fiveDigitsNumber = randNum.ToString("D5");
			this.id = Int32.Parse(fiveDigitsNumber);
		}
		public int getTotalVideoPlayCount()
		{
			int total = 0;
			for(int i = 0; i < uploadedVideo.Count; i++)
			{
				total = total + uploadedVideo.ElementAt(i).getPlayCount();	
			}
			return total;
		}

		public void AddVideo(SayaTubeVideo video)
		{
			this.uploadedVideo.AddFirst(video);
		}

		public void printAllVideoPlayCount()
		{
			Console.WriteLine("User : "+this.username);
			for(int i = 0; i < this.uploadedVideo.Count; i++)
			{
				Console.WriteLine("Video " + i + " " + this.uploadedVideo.ElementAt(i).getTitle());
			}
		}
	}
}
