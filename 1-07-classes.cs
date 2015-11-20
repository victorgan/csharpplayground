using System;
class MyClass
{
   public MyClass() {
      Console.WriteLine("Instance constructor");
   }
   public MyClass(int value) {
      MyField = value;
      Console.WriteLine("Instance constructor");
   }
   ~MyClass() {
      Console.WriteLine("Destructor");
   }
   public const int MyConst = 12;
   public int MyField = 34;
   public void MyMethod(){
      Console.WriteLine("MyClass.MyMethod");
   }
   public int MyProperty {
      get {
         return MyField;
      }
      set {
         MyField = value;
      }
   }
   public int this[int index] {
      get {
         return 0;
      }
      set {
         Console.WriteLine("this[{0}] = {1}", index, value);
      }
   }
   public event EventHandler MyEvent;
   public static MyClass operator+(MyClass a, MyClass b) {
      return new MyClass(a.MyField + b.MyField);
   }
   internal class MyNestedClass
   {}
}
class Test
{
   static void Main() {
      // Instance constructor usage
      MyClass a = new MyClass();
      MyClass b = new MyClass(123);
      // Constant usage
      Console.WriteLine("MyConst = {0}", MyClass.MyConst);
      // Field usage
      a.MyField++;
      Console.WriteLine("a.MyField = {0}", a.MyField);
      // Method usage
      a.MyMethod();
      // Property usage
      a.MyProperty++;
      Console.WriteLine("a.MyProperty = {0}", a.MyProperty);
      // Indexer usage
      a[3] = a[1] = a[2];
      Console.WriteLine("a[3] = {0}", a[3]);
      // Event usage
      a.MyEvent += new EventHandler(MyHandler);
      // Overloaded operator usage
      MyClass c = a + b;
   }
   static void MyHandler(object sender, EventArgs e) {
      Console.WriteLine("Test.MyHandler");
   }
   internal class MyNestedClass
   {}
}
