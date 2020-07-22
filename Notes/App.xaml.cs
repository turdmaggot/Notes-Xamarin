using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
