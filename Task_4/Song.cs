using System;
namespace Task_4
{
    public delegate void AlbumHandler(string message);
 
    public class Album
    {
        public event AlbumHandler? Notify;
        public int songCounter = 0;
        public void AddSong()
        {
            Console.WriteLine("Добавлена песня");
            songCounter += 1;
            if (songCounter == 10)
            {
                Notify?.Invoke("Добавлено 10 песен. Альбом готов");
                songCounter = 0;
            }
        }

        
    }
   
}

