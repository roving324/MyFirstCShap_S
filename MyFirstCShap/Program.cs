using CHAP04_MiddleExam;
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
            Application.Run(new Chap24_Algorithm_Exam02()); //�� ���� ���� �� Chap01_Hello���� ����
        }
    }
}