using System;
public enum Color
{
   Red, Blue, Green
}
public struct Point 
{ 
   public int x, y; 
}
public interface IBase
{
   void F();
}
public interface IDerived: IBase
{
   void G();
}
public class A
{
   protected virtual void H() {
      Console.WriteLine("A.H");
   }
}
public class B: A, IDerived 
{
   public void F() {
      Console.WriteLine("B.F, implementation of IDerived.F");
   }
   public void G() {
      Console.WriteLine("B.G, implementation of IDerived.G");
   }
   override protected void H() {
      Console.WriteLine("B.H, override of A.H");
   }
}
public delegate void EmptyDelegate();


class Test
{
   static void Main() {
      int val1 = 0;
      int val2 = val1;
      Console.WriteLine("Values: {0}, {1}", val1, val2);
   }
}
