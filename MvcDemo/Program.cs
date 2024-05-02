using MvcDemo.Model;

namespace MvcDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var model = new TextModel();
            var main = new MvcDemoMain(model);
            CreateSatelliteForms(main, model);

            Application.Run(main);
        }

        private static void CreateSatelliteForms(MvcDemoMain main, TextModel model)
        {
            var param = new TextParameterView(model);
            var content = new ContentView(model);
            var editor = new EditorViewController(model);

            param.Show();
            param.Location = new(main.Location.X + main.Width, main.Location.Y);

            content.Show();
            content.Location = new(main.Location.X + main.Width, main.Location.Y + param.Height);

            editor.Show();
            editor.Location = new(main.Location.X - editor.Width, main.Location.Y);
        }
    }
}