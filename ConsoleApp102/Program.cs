namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = Container.CreateInstance<App>();
            app.Run();
        }

    }
}
