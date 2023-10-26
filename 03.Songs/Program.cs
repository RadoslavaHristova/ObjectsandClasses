namespace _03.Songs
{
    internal class Program
    {
        public class Song
        {
            public Song(string type,string name,string time) 
            {
                TypeList=type; 

                Name=name;

                Time=time;
            }
            public string TypeList  {get;set;}
            public string Name { get;set;}
            public string Time { get;set;}
        }
        static void Main(string[] args)
        {
            int songsCount=int.Parse(Console.ReadLine());
            List<Song> songsPlaylist = new List<Song>();

             for (int i = 0; i < songsCount; i++) 
            {
            string[] inputSongs=Console.ReadLine().Split("_");
                 
                string type = inputSongs[0];
                string name = inputSongs[1];
                string time = inputSongs[2];

                Song song=new Song(type,name,time);

                songsPlaylist.Add(song);
            }

             string command=Console.ReadLine();

            if(command == "all")
            {
                foreach (Song song in songsPlaylist)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else

            { foreach(Song song in songsPlaylist)
                {
                    if(song.TypeList==command)
                    { Console.WriteLine(song.Name); }
                }
            }
        }
    }
}