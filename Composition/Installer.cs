namespace Composition
{
    public class Installer
    {
        private readonly Logger _Logger;

        public Installer(Logger _logger)
        {
            _Logger = _logger;
        }

        public void Install()
        {
            System.Console.WriteLine("We are installing stuff");
        }

    }
}
