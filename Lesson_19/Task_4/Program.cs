namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            // Добавление дисков и песен
            catalog.AddDisk("Rock Hits");
            catalog.AddSong("Rock Hits", "Stairway to Heaven");
            catalog.AddSong("Rock Hits", "Bohemian Rhapsody");
            catalog.AddSong("Rock Hits", "Hotel California");

            catalog.AddDisk("Pop Favorites");
            catalog.AddSong("Pop Favorites", "Shape of You");
            catalog.AddSong("Pop Favorites", "Believer");
            catalog.AddSong("Pop Favorites", "Love Yourself");

            // Вывод каталога на экран
            catalog.PrintCatalog();

            // Вывод содержимого диска на экран
            catalog.PrintDisk("Rock Hits");

            // Удаление песни и диска
            catalog.RemoveSong("Rock Hits", "Bohemian Rhapsody");
            catalog.RemoveDisk("Pop Favorites");

            // Вывод каталога на экран после удаления
            catalog.PrintCatalog();
        }
    }
}