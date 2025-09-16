namespace Lab1_Spel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" __      __       .__                               \r\n/  \\    /  \\ ____ |  |   ____  ____   _____   ____  \r\n\\   \\/\\/   // __ \\|  | _/ ___\\/  _ \\ /     \\_/ __ \\ \r\n \\        /\\  ___/|  |_\\  \\__(  <_> )  Y Y  \\  ___/ \r\n  \\__/\\  /  \\___  >____/\\___  >____/|__|_|  /\\___  >\r\n       \\/       \\/          \\/            \\/     \\/ ");
            Console.WriteLine("___________                             .__    .__  __    __                                          \r\n\\__    ___/___     _____ ___.__.   _____|  |__ |__|/  |__/  |_ ___.__.    _________    _____   ____   \r\n  |    | /  _ \\   /     <   |  |  /  ___/  |  \\|  \\   __\\   __<   |  |   / ___\\__  \\  /     \\_/ __ \\  \r\n  |    |(  <_> ) |  Y Y  \\___  |  \\___ \\|   Y  \\  ||  |  |  |  \\___  |  / /_/  > __ \\|  Y Y  \\  ___/  \r\n  |____| \\____/  |__|_|  / ____| /____  >___|  /__||__|  |__|  / ____|  \\___  (____  /__|_|  /\\___  > \r\n                       \\/\\/           \\/     \\/                \\/      /_____/     \\/      \\/     \\/  ");
            var characterCreator = new CreateCharacter();
            characterCreator.RunCreation();

            var player = characterCreator.player;
            MainMenu menu = new MainMenu(player);
            menu.Run();
        }
    }
}
