namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String height = Console.ReadLine(); 
            int heightINT = int.Parse(height);
            String width = Console.ReadLine();
            int widthINT = int.Parse(width);
            Console.WriteLine(heightINT);
            Console.WriteLine(widthINT); ;

            for (int i = 0; i < heightINT; i++)
            {
                if(i != 0 || i != heightINT - 1)
                {
                    Console.WriteLine("|");
                }
                for (int j = 0; j < widthINT; j++)
                {
                    if (i == 0 || i == widthINT - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        j += 2;
                        Console.Write(" ");
                    }
                    
                       
                  
                }
            }



            
        }
    }
}
