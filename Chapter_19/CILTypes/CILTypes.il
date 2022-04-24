// List of referenced assemblies.
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 5:0:0:0
}

// Our assembly
.assembly CILTypes
{
  .ver 1:0:0:0
}

// The module of our single-file assembly.
.module CILTypes.dll

// Our assembly has a single namespace.
.namespace MyNamespace
{
  .class public MyBaseClass {
    .field private string stringField = "Hello!"
    .field private int32 intField = int32(42)

    .method public hidebysig specialname rtspecialname instance void .ctor (string s, int32 i) cil managed 
    {
      //TODO: Add implementation code
    }

    .method public hidebysig specialname instance string get_TheString() cil managed 
    {
      //TODO: Add implementation code
    }

    .method public hidebysig specialname instance void set_TheString(string 'value') cil managed 
    {
      //TODO: Add implementation code
    }

    .property instance string TheString() 
    {
      .get instance string MyNamespace.MyBaseClass::get_TheString()
      .set instance void MyNamespace.MyBaseClass::set_TheString(string)
    }

    .method public hidebysig static void MyMethod(int32 inputInt, int32& refInt, class [System.Runtime.Extensions]System.Collections.ArrayList ar, [out] int32& outputInt) cil managed
    {
      //TODO: Add implementation
    }

    .method public hidebysig instance void Speak() cil managed {
      // During the scope of this method, exactly 1 value (string literal) is on the stack.
      .maxstack 1
      ldstr "Hello there ..."
      call void [mscorlib]System.Console::WriteLine(string)
      ret
    }

    .method public hidebysig static void MyLocalVariables() cil managed {
      .maxstack 8
      // Define three local variables
      .locals init (string myStr, int32 myInt, object myObj)
      // Load a string onto the virtual execution stack
      ldstr "CIL code is fun!"
      // Pop off current value and store in local variable [0]
      stloc.0

      // Load a constant of type "i4"
      // (shorsthand for int32) set to the value 33
      ldc.i4.s 33
      // Pop off current value and store in local variable [1]
      stloc.1

      // Create a new object and place on stack
      newobj instance void [mscorlib]System.Object::.ctor()
      // Pop off current value and store in local variable [2]
      stloc.2
      ret
    }

    .method public hidebysig static int32 Add(int32 a, int32 b) cil managed {
      .maxstack 2
      ldarg.0 // Load "a" onto the stack.
      ldarg.1 // Load "b" onto the stack
      add // Add both values
      ret
    }

    
}

  .class public interface IMyInterface {}

  .class public interface IMyOtherInterface implements MyNamespace.IMyInterface {}

  .class public sealed MyStruct extends [System.Runtime]System.ValueType {}

  // Shorthand notation for declaring a structure

  .class public sealed value MyOtherStruct {}

  .class public sealed MyEnum extends [System.Runtime]System.Enum {}

  .class public sealed enum MyOtherEnum {
    .field public static literal valuetype MyNamespace.MyOtherEnum A = int32(0)
    .field public static literal valuetype MyNamespace.MyOtherEnum B = int32(1)
    .field public static literal valuetype MyNamespace.MyOtherEnum C = int32(2)
  }

  .class public MyDerivedClass extends MyNamespace.MyBaseClass implements MyNamespace.IMyInterface {}

}