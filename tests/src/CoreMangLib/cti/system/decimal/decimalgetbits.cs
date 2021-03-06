using System;
using System.Globalization;
/// <summary>
///GetBits(System.Decimal)
/// </summary>
public class DecimalGetBits
{
    #region const
    const string dataFmt = "{0,31}  {1,10:X8}{2,10:X8}{3,10:X8}{4,10:X8}";
    #endregion
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;

        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1:  Calling GetBits method.");

        try
        {
            retVal = VerifyHelper(0x00000001, 0x00000000, 0x00000000, false, 0x00000000, "001.1"); //1M
            retVal = VerifyHelper(0x107A4000, 0x00005AF3, 0x00000000, false, 0x00000000, "001.2");         //100000000000000M
            retVal = VerifyHelper(0x10000000, 0x03E250261, 0x204FCE5E, false, 0x00000000, "001.3");//10000000000000000000000000000M

            retVal = VerifyHelper(0x10000000, 0x3E250261, 0x204FCE5E, false, 0x000E0000 >> 16, "001.4");

            retVal = VerifyHelper(0x107A4000, 0x00005AF3, 0x00000000, false, 0x00000000, "001.5"); //100000000000000.00000000000000
            retVal = VerifyHelper(0x10000000, 0x3E250261, 0x204FCE5E, false, 0x001C0000 >> 16, "001.6"); //1.0000000000000000000000000000

            retVal = VerifyHelper(0x075BCD15, 0x00000000, 0x00000000, false, 0x00000000, "001.7"); //123456789
            retVal = VerifyHelper(0x075BCD15, 0x00000000, 0x00000000, false, 0x00090000 >> 16, "001.8"); //0.123456789

            retVal = VerifyHelper(0x075BCD15, 0x00000000, 0x00000000, false, 0x00120000 >> 16, "001.9"); //0.000000000123456789

            retVal = VerifyHelper(0x075BCD15, 0x00000000, 0x00000000, false, 0x001B0000 >> 16, "001.10"); //0.000000000000000000123456789
            retVal = VerifyHelper(unchecked((int)0xFFFFFFFF), 0x00000000, 0x00000000, false, 0x00000000 >> 16, "001.11"); //4294967295

            retVal = VerifyHelper(unchecked((int)0xFFFFFFFF), unchecked((int)0xFFFFFFFF), 0x00000000, false, 0x00000000 >> 16, "001.12"); //18446744073709551615
            retVal = VerifyHelper(unchecked((int)0xFFFFFFFF), unchecked((int)0xFFFFFFFF), unchecked((int)0xFFFFFFFF), false, 0x00000000, "001.13"); //decimal.MaxValue
            retVal = VerifyUintHelper(unchecked((int)0xFFFFFFFF), unchecked((int)0xFFFFFFFF), unchecked((int)0xFFFFFFFF), true, 0x00000000 >> 16, "001.14");  //decimal.MinValue
   
         }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

    #endregion

    #endregion

    public static int Main()
    {
        DecimalGetBits test = new DecimalGetBits();

        TestLibrary.TestFramework.BeginTestCase("DecimalGetBits");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    #region private method
   

    // Display the decimal.GetBits argument and the result array.
    private static void ShowDecimalGetBits(decimal Argument)
    {
        int[] Bits = decimal.GetBits(Argument);

        Console.WriteLine(dataFmt, Argument,
            Bits[3], Bits[2], Bits[1], Bits[0]);
    }
    private bool VerifyHelper(int lo, int mid, int hi, bool isNegative, byte scale,string errorNO)
    {
        bool retVal = true;
        decimal myDecimal = new decimal(lo, mid, hi, isNegative, scale);
        try{
        int [] myArray = Decimal.GetBits(myDecimal);
        if (myArray[0] != lo || myArray[1] != mid || myArray[2] != hi || myArray[3] != scale<<16 )
        {
            TestLibrary.TestFramework.LogError(errorNO, "An error occurs when  GetBits method is called.");
            retVal = false;
        }
        ShowDecimalGetBits(myDecimal);
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError(errorNO+".0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    private bool VerifyUintHelper(int lo, int mid, int hi, bool isNegative, byte scale, string errorNO)
    {
        bool retVal = true;
        decimal myDecimal = new decimal(lo, mid, hi, isNegative, scale);
        try
        {
            int[] myArray = Decimal.GetBits(myDecimal);
            if (myArray[0] != lo || myArray[1] != mid || myArray[2] != hi || myArray[3] != -(scale + 0x80000000))
            {
                TestLibrary.TestFramework.LogError(errorNO, "An error occurs when  GetBits method is called.");
                retVal = false;
            }
            ShowDecimalGetBits(myDecimal);
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError(errorNO + ".0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion


}
