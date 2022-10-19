namespace DoubleTapHost
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());

            Library gameLibrary = new Library();

            Game game1 = new Game("Test Game", "C:", "Test Desc", "Singleplayer", "Adventure", "Music");
            gameLibrary.addGame(game1);
        }
    }
}