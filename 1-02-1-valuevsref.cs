using System;
class Class1
{
   public int Value = 0;
}
class Test
{
   static void Main() {

      // value types directly contain data
      int val1 = 0;
      int val2 = val1;
      val2 = 123;

      // reference types are references to objects
      Class1 ref1 = new Class1();
      Class1 ref2 = ref1;
      ref2.Value = 123; //ref1.Value is also changed to 123

      // {0} and {1} are arguments
      Console.WriteLine("Values: {0}, {1}", val1, val2);
      Console.WriteLine("Refs: {0}, {1}", ref1.Value, ref2.Value);


      string s = "Test";
      string t = string.Copy(s);
      Console.WriteLine(s == t); // true, because same value
      Console.WriteLine((object)s == (object)t); // false, because points to different objects
   }
}

// There are two predefined reference types: object and string
// There are predefined value types: signed/unsigned integers (sbyte, short,
// int, long, byte, ushort, uint, ulong), floating points (float, double),
// bool, char, and decimal.
//
// signed integer types
// sbyte    8-bit
// short    16-bit
// int      32-bit
// long     64-bit
// unsigned integer types
// byte     8
// ushort   16
// uint     32
// ulong    64
// floating
// float    single precision
// double   double precision
// decimal  precise 28 significant digits
//
// int is a struct for System.Int32
