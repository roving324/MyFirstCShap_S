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
            //Application.Run(new Chap01_Hello()); //이 앱을 실행 전 Chap01_Hello부터 실행
            //Application.Run(new Chap03_DataTypeChang());
            //Application.Run(new Chap04_Operator());
            //Application.Run(new Chap05_StringChang());
            //Application.Run(new Chap06_StringFind());
            //Application.Run(new Chap07_StringSplit());
            //Application.Run(new Chap08_Test());
            //Application.Run(new Chap09_Null());
            Application.Run(new Chap10_Class2());
        }
    }
}