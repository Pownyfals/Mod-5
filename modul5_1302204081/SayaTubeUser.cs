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
			if (user.Length < 100 && user != null)
			{
				this.username = user;
				//mengenerate id number 5 digit
				Random generator = new Random();
				int randNum = generator.Next(100000);
				string fiveDigitsNumber = randNum.ToString("D5");
				this.id = Int32.Parse(fiveDigitsNumber);
			}
			else
			{
				Console.WriteLine("Invalid Username");
			}

			
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
			//try and catch saat penambahan video
			try
			{
				if(video != null && video.getPlayCount() != 2147483647){

				this.uploadedVideo.AddFirst(video);
			}
				else
				{
					Console.WriteLine("Invalid Video");
				}
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void printAllVideoPlayCount()
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("User : "+this.username);
			for(int i = 0; i < this.uploadedVideo.Count; i++)
			{
				//maksimal video di print 8
				if (i <= 8)
				{
				Console.WriteLine("Video " + (i+1) + " " + this.uploadedVideo.ElementAt(i).getTitle());
				}
			}
		}
	}
}
