 using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int height = get_rows();
    get_stair(height);
  }
  
  public static int get_rows()
  {
      bool running = true;
    Console.WriteLine("height:");
    string r = Console.ReadLine();    
    try {
      int n = Convert.ToInt32(r);
      while(running)
      {
          if (n >= 1 && n <= 8)
        {
            running = false;
        }
        else
        {
            Console.WriteLine("Invalid Input");
            Console.WriteLine("height:");
            n = Convert.ToInt32(Console.ReadLine());
        }
      }
      return n;

    }
    catch(FormatException ) {
      Console.WriteLine("Invalid Input");
      int n = get_rows();
      return n;
    }  
  }

  public static void get_stair(int height)
  {
    int space_num  = height -1;
    while(space_num >= 0)
    {
      string space = string.Concat(Enumerable.Repeat(" ", space_num));
      Console.Write(space);

      string hash = string.Concat(Enumerable.Repeat("#", height - space_num));
      Console.Write(hash);

        Console.Write("  ");

      string hash_2 = string.Concat(Enumerable.Repeat("#", height - space_num));
      Console.WriteLine(hash_2);
      
      space_num--;
    }
  }  
}