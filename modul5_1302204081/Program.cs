using modul5_1302204081;
// See https://aka.ms/new-console-template for more information
SayaTubeUser user = new SayaTubeUser("user1");
SayaTubeUser user2 = new SayaTubeUser("");
SayaTubeVideo video1 = new SayaTubeVideo("tutorial c#");
SayaTubeVideo video2 = new SayaTubeVideo("tutorial java");
SayaTubeVideo video4 = new SayaTubeVideo("");
SayaTubeVideo video3 = null;
user.AddVideo(video3);
int j = 2147483647;
for(int i = 1;i <= 10; i++)
{
	video1.increasePlayCount(j);
	j = j + 2147483647;
}
user.AddVideo(video1);
user.AddVideo(video2);
user.printAllVideoPlayCount();