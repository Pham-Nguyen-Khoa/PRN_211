using PRN212_NERONMEN;

internal class Program
{
    private static void Main(string[] args)
    {
        //Class1<String> name = new Class1<String>()
        //{
        //    Value="Jack97"
        //};
        //Console.WriteLine(name);

        //Class1<float> version = new Class1<float>()
        //{
        //    Value=5.5f
        //};
        //Console.WriteLine(version);


        //dynamic obj = new { Id = 1, Name = "Neronmen" };
        //Class1<dynamic> myClass = new Class1<dynamic>()
        //{
        //    Value=obj
        //};
        //Console.WriteLine(myClass);
        //Console.ReadLine();

        //myClass obj = new myClass();
        //obj.Display<string, int>("Integer", 6969);
        //obj.Display<double, char>(323.323, 'K');
        //obj.Display<float, double>(23.93233F, 23323.3232);


        MyFirstClass firstClass = new MyFirstClass();
        dynamic r = firstClass.add(10, 20);
        Console.WriteLine(r);
        MySecondClass secondClass = new MySecondClass();
         r = secondClass.add(10.5, 20.5);
        Console.WriteLine(r);
        Console.ReadLine();
    }


    class MyFirstClass : IBasic<int>
    {
        public int add(int a, int b) => a+ b;


    }


    class MySecondClass : IBasic<double>
    {
        public double add(double a, double b) => a+ b;


    }

    //public class myClass
    //{

    //    public void Display<T,U>(T key, U value)
    //    {
    //        Console.WriteLine($"{key} : {value}");
    //    }
    //}

    //public static void  MyMethod(int a, ref int b,out int c)
    //{
    //    a = 3;
    //    b = 4;
    //    c = 5;
    //}



    //private static bool checkSoHoanHao(int hoanHao)
    //{
    //    int[] listUocCHung = danhSachUocCHungCuaN(hoanHao);
    //    int total = 0;
    //    for (int i = 0; i < listUocCHung.Length; i++)
    //    {
    //        total += listUocCHung[i];
    //    }
    //    if (total == hoanHao)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //private  static int[] danhSachUocCHungCuaN(int n)
    //{
    //    int[] danhSachUocChung = new int[n];
    //    for (int i = 1; i <= n; i++)
    //    {
    //        if (n % i == 0)
    //        {
    //            danhSachUocChung[i-1 ] =i;

    //        }
    //    }
    //    return danhSachUocChung;
    //}








}

