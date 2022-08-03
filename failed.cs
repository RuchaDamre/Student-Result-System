//declare class named failed inheritaed from class student and interface wishes

public class failed : student , wishes
{
     public failed(string n, int m, int s, int e): base(n,m,s,e)
     {
         
     }

//method overriding-failed.grade() method display different output than student.grade()

     public void grade(int m, int s, int e)
      {
          if((m<35)||(s<35)||(e<35))
          Console.WriteLine($"Grade of a student : \"F\" ");
          
      }

//define methods which are declare in interface wishes

        void wishes.wish1()
     {
         Console.WriteLine("CONGRATULATIONS !!!");
     }
      void wishes.wish2()
     {
         Console.WriteLine("ALL THE BEST !!!");
     }
}