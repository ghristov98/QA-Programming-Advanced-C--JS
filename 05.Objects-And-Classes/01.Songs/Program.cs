namespace Song_01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Song> songsList = new List<Song>();

            int countSongs = int.Parse(Console.ReadLine()); 

            for (int count = 1; count <= countSongs; count++)
            {
                string data = Console.ReadLine();

                string typeList = data.Split("_")[0]; 
                string name = data.Split("_")[1]; 
                string time = data.Split("_")[2]; 

                Song song = new Song(typeList, name, time);

                songsList.Add(song);
            }


            string typeSongToPrint = Console.ReadLine(); 

            foreach (Song song in songsList)
            {
                if (typeSongToPrint == "all" || typeSongToPrint == song.TypeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}