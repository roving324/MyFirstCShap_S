using MyFirstCSharp;

namespace MyFirstCShap
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
            Application.Run(new Chap16_Switch_Test4()); //이 앱을 실행 전 Chap01_Hello부터 실행
        }
    }
}