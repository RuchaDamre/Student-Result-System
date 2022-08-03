using System; 
using Humanizer;

//declare main class program

  public class Program {

  public static void Main(string[] args) {

//Take input from user 
    
    Console.WriteLine("Enter your name :");
         string name = Console.ReadLine();
           Console.WriteLine("Enter marks of a student in Maths subject :");
           int m = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter marks of a student in Science subject :");
           int s = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter marks of a student in English subject :");
           int e = Convert.ToInt32(Console.ReadLine());

//make base class object from derived class
    
        student i = new failed(name,m,s,e);

//make derived class object
    
        failed f = new failed (name,m,s,e);
        
// Write user input           
          
           Console.WriteLine("Name of a student : "+name);
           Console.WriteLine($"Marks of a student in Maths : {m}");
           Console.WriteLine($"Marks of a student in Science : {s}");
           Console.WriteLine($"Marks of a student in English : {e}");
           if(m<35)
           {
               f.grade(m,s,e);
                Console.WriteLine("\n");
          Console.WriteLine("Oh, you failed! Give the exam again and write your score.");
          ((wishes)f).wish2();
          i= null;
           }
           else if(s<35)
           {
               f.grade(m,s,e);
                Console.WriteLine("\n");
          Console.WriteLine("Oh, you failed! Give the exam again and write your score.");
           ((wishes)f).wish2();
          i= null;
           }
           else if(e<35)
           {
                f.grade(m,s,e);
                Console.WriteLine("\n");
          Console.WriteLine("Oh, you failed! Give the exam again and write your score.");
          
           ((wishes)f).wish2();
          i= null;
           }
           else
           {
           i.marks(m,s,e);
           i.per(m,s,e);
           i.grade(m,s,e);
           ((wishes)f).wish1();
           }
  }
}