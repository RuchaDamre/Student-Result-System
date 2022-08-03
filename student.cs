//create class named student

public class student
{
    private string name{get; set;}
    public int math{get; set;}
     public int sci{get; set;}
      public int eng{get; set;}

//declare parameterize constructor
  
      public student(string n, int m, int s, int e)
      {
          this.name=n;
          this.math=m;
          this.sci=s;
          this.eng=e;
      }

//create method marks() which calculate total marks
  
      public void marks(int m, int s, int e)
      {
          int t=0;
          t=m+s+e ;
           Console.WriteLine($"The total marks of a student : {t}/300");
        Console.WriteLine(t.ToWords());
      }

//create method per() which calculate percentage from marks
  
      public void per(int m, int s, int e)
      {
           double total =0;
          total=m+s+e ;
          double p;
          p=total/3;
          p=Math.Round(p);
          Console.WriteLine($"Percentage of a student : {p}%");
      }

//create method grade() which calculate grade from percentage
  
      public void grade(int m, int s, int e)
      {
          double total =0;
          total=m+s+e ;
          double p;
          p=total/3;
          if(p>=80)
          Console.WriteLine($"Grade of a student : \"A\" ");
          else if((p>=60) && (p<=80))
           Console.WriteLine($"Grade of a student : \"B\" ");
            else if((p>=40) && (p<=60))
           Console.WriteLine($"Grade of a student : \"C\" ");
           else
           Console.WriteLine($"Grade of a student : \"D\" ");
      }
}

