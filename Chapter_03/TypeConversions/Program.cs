using System;

Console.WriteLine("***** Fun with type conversions *****");
// Add two shorts and print the result.
// short numb1 = 9, numb2 = 10;
// Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
// Console.ReadLine();
// NarrowingAttempt();


//short numb1 = 30000, numb2 = 30000;

// Explicit cast with loss of data
// short answer = (short)Add(numb1, numb2);
//
// Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
// NarrowingAttempt();
//ProcessBytes();
//ProcessBytesWithOverflowCheck();
//ProcessBytesWithOverflowCheckScope();
ProcessBytesWithUncheckedScope();

Console.ReadLine();

static int Add(int x, int y)
{
    return x + y;
}

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    
    // Explicitly cast the int into a byte (no loss of data).
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}

static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    byte sum = (byte)Add(b1, b2);

    Console.WriteLine("sum = {0}", sum);
}

static void ProcessBytesWithOverflowCheck()
{
    byte b1 = 100;
    byte b2 = 250;
    
    // throw exception in case overflow
    try
    {
        byte sum = checked((byte)Add(b1,b2));
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void ProcessBytesWithOverflowCheckScope()
{
    byte b1 = 100;
    byte b2 = 250;
    try
    {
        checked
        {
            byte sum = (byte)Add(b1, b2);
            Console.WriteLine("sum = {0}", sum);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Assuming /checked is enabled,
// this block will not trigger
// a runtime exception.
static void ProcessBytesWithUncheckedScope()
{
    byte b1 = 100;
    byte b2 = 250;
    unchecked
    {
        byte sum = (byte)(b1 + b2);
        Console.WriteLine("sum = {0}", sum);
    }
}


















