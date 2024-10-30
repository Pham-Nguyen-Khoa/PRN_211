using Bussiness_Object;

namespace PRN211_Bai1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Book_DAO test = new Book_DAO() { BookID = "002", BrandBook="adidas",ColorBook="red",NameBook="Naruto",PriceBook="1111"};

            Console.Write(test);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}