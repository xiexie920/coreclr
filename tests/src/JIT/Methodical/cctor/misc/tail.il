// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}
.assembly extern mscorlib {}
.assembly precise3 {}
.class private auto ansi beforefieldinit measure
       extends [mscorlib]System.Object
{
  .field public static int32 a
  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    .maxstack  1
    IL_0000:  ldc.i4.0
    IL_0001:  stsfld     int32 measure::a
    IL_0006:  ret
  } 

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } 

} 

.class private auto ansi test
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual 
          instance void  f(unsigned int8& b) cil managed
  {
    .maxstack  0
    IL_0000:  br.s       IL_0002

    IL_0002:  ret
  } 

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    .maxstack  2
    IL_0000:  ldsfld     int32 measure::a
    IL_0005:  brfalse.s  IL_002b

    IL_0007:  ldstr      "in .cctor(), measure.a is {0}"
    IL_000c:  ldsfld     int32 measure::a
    IL_0011:  box        [mscorlib]System.Int32
    IL_0016:  call       void [System.Console]System.Console::WriteLine(string,
                                                                  object)
    IL_001b:  ldstr      "FAILED"
    IL_0020:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0025:  newobj     instance void [mscorlib]System.Exception::.ctor()
    IL_002a:  throw

    IL_002b:  ldstr      "in .cctor(), measure.a is {0}"
    IL_0030:  ldsfld     int32 measure::a
    IL_0035:  box        [mscorlib]System.Int32
    IL_003a:  call       void [System.Console]System.Console::WriteLine(string,
                                                                  object)
    IL_003f:  ldsfld     int32 measure::a
    IL_0044:  ldc.i4.8
    IL_0045:  add
    IL_0046:  stsfld     int32 measure::a
    IL_004b:  ldsfld     int32 measure::a
    IL_0050:  ldc.i4.8
    IL_0051:  beq.s      IL_0077

    IL_0053:  ldstr      "in .cctor() after measure.a=8, measure.a is {0}"
    IL_0058:  ldsfld     int32 measure::a
    IL_005d:  box        [mscorlib]System.Int32
    IL_0062:  call       void [System.Console]System.Console::WriteLine(string,
                                                                  object)
    IL_0067:  ldstr      "FAILED"
    IL_006c:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0071:  newobj     instance void [mscorlib]System.Exception::.ctor()
    IL_0076:  throw

    IL_0077:  ldstr      "in .cctor() after measure.a=8, measure.a is {0}"
    IL_007c:  ldsfld     int32 measure::a
    IL_0081:  box        [mscorlib]System.Int32
    IL_0086:  tail. call       void [System.Console]System.Console::WriteLine(string,
                                                                  object) 
    ret                                                              
  } 

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } 

} 

.class private auto ansi beforefieldinit test2
       extends test
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } 

} 

.class private auto ansi beforefieldinit Driver
       extends [mscorlib]System.Object
{
  .method public hidebysig static int32  Main() cil managed
  {
    .entrypoint
    .maxstack  2
    .locals init (unsigned int8 V_0,
             class test2 V_1,
             class [mscorlib]System.Exception V_2,
             int32 V_3)
    .try
    {
      ldstr      "Testing .cctor() invocation by calling virtual method"
      call       void [System.Console]System.Console::WriteLine(string)
      ldnull
      call       void [System.Console]System.Console::WriteLine(string)
      IL_0000:  ldc.i4.s   15
      IL_0002:  stloc.0
      IL_0003:  newobj     instance void test2::.ctor()
      IL_0008:  stloc.1
      IL_0009:  ldsfld     int32 measure::a
      IL_000e:  brfalse.s  IL_0032

      IL_0010:  ldstr      "in Main(), measure.a is {0}"
      IL_0015:  ldsfld     int32 measure::a
      IL_001a:  box        [mscorlib]System.Int32
      IL_001f:  call       void [System.Console]System.Console::WriteLine(string,
                                                                    object)
      IL_0024:  ldstr      "FAILED"
      IL_0029:  call       void [System.Console]System.Console::WriteLine(string)
      IL_002e:  ldc.i4.1
      IL_002f:  stloc.3
      IL_0030:  leave.s    IL_009e

      IL_0032:  ldstr      "Before running virtual method"
      IL_0037:  call       void [System.Console]System.Console::WriteLine(string)
      IL_003c:  ldloc.1
      IL_003d:  ldloca.s   V_0
      IL_003f:  callvirt   instance void test::f(unsigned int8&)
      IL_0044:  ldstr      "After running virtual method"
      IL_0049:  call       void [System.Console]System.Console::WriteLine(string)
      IL_004e:  ldsfld     int32 measure::a
      IL_0053:  ldc.i4.8
      IL_0054:  beq.s      IL_0078

      IL_0056:  ldstr      "in Main() after f(ref b), measure.a is {0}"
      IL_005b:  ldsfld     int32 measure::a
      IL_0060:  box        [mscorlib]System.Int32
      IL_0065:  call       void [System.Console]System.Console::WriteLine(string,
                                                                    object)
      IL_006a:  ldstr      "FAILED"
      IL_006f:  call       void [System.Console]System.Console::WriteLine(string)
      IL_0074:  ldc.i4.m1
      IL_0075:  stloc.3
      IL_0076:  leave.s    IL_009e

      IL_0078:  leave.s    IL_008a

    }  
    catch [mscorlib]System.Exception 
    {
      IL_007a:  stloc.2
      IL_007b:  ldloc.2
      IL_007c:  callvirt   instance string [mscorlib]System.Exception::get_StackTrace()
      IL_0081:  call       void [System.Console]System.Console::WriteLine(string)
      IL_0086:  ldc.i4.m1
      IL_0087:  stloc.3
      IL_0088:  leave.s    IL_009e

    }  
    IL_008a:  call       void [System.Console]System.Console::WriteLine()
    IL_008f:  ldstr      "PASSED"
    IL_0094:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0099:  ldc.i4.s   100
    IL_009b:  stloc.3
    IL_009c:  br.s       IL_009e

    IL_009e:  ldloc.3
    IL_009f:  ret
  } 

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } 
}
