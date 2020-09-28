### C# Facts

---

- Case Sensitive
- Object Oriented Paradigm
- One of the Popular Language - > Dotnet Fx based Solution
- C # can be used as Script
- C# - Dotnet Core -> Platform independent
- C# Compilers
  - **Dotnet Fx - Compiler**
  - Dotnet Core - Roslyn Compiler from Dotnet Foundation

### C# Role - Dotnet Framework / Dotnet Core

---

- C# Compiler generates MSIL Code

  - MSIL Code Generator
  - Macro Processor

  

```C#
// CSharp Code
public class A
{
	public static void Main()
	{
		
	}
}


```

```C#


Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.33440
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// 



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly r0pzzpax
{
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module r0pzzpax.dll
// MVID: {1AB44607-E0AC-451F-9586-A13B41E7700D}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01050000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit A
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main() cil managed
  {
    // 
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method A::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // 
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method A::.ctor

} // end of class A


// =============================================================

// 
// 

```



### C# Learning Curve

---

- Given C# Code - What is the equivalent MSIL Code Generated
- Object Oriented Programming using C# Constructs

### C# Program Structure

---



```c#
// Test.cs
namespace <NameSapceName>{
    //User Defined DataTypes
    class <ClassName>{
        //Members
    }
    struct <StructName>{
        //members
    }
    interface <InterfaceName>{
        //members
    }
    enum <EnumName>{
        //members
    }
}
```

#### Object Oriented Paradigm

----

> Paradigm ? - Its a **Style** or **way** of programming.
>
> *A paradigm is a way of* **doing** **something (like programming), not a concrete thing (like a language).**
>
> A given Language can support multiple paradigms
>
> What about C# ?
>
> - Object Oriented
> - Event-Based / driven
> - AOP 

#### Object Oriented Paradigm

---

Programming by defining objects that send messages to each other. Objects have their own internal (encapsulated) state and public interfaces.





## Object

- SPACE

  - How much Space? 

- Analogy 

  - House  - Objects (Object - Space)
    - Window  - (ventilation)
      - Height , Width , Thickness , Color , Partitions
      - Open , Close ,Slide
  - Program  - Objects

- Object -> "Certain Role"

  - "Responsibilities"
    - "State" and "Behavior"

  

  

  

  

  