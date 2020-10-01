- t
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
    - "State/DataMember/Properties" and "Behavior/methods"

  

  > Current Software Project - Management  - List out Objects - Roles and Responsibilities
>
  > 1. Developer - Coding , Review , Document , Requirement Analysis,Unit Testing , Bug Fixing
> 2. Product Owner :- Requirement Engineering ,
  > 3. Devops Engineer : 



### Object Oriented Design

----

1. Identify Valid Objects - "Define Role and Assign Responsibilities" - "**Encapsulation**"  - "Classification/Description of Object state and Behavior"

   > How to define/express encapsulation  in Programming Language : "User Defined Data Types"
   >
   > What is DataType ?
   >
   > Define "Domain Of Value"  : "State and Behavior"
   >
   > S/w Program = Algorithm + Data , Data Represents Value 
   >
   > DataType Classification  : 
   >
   > - Built-in/Primitive/Basic DataTypes (Domain of Value  is Predefined by Language Author or Domain of Value well understood by Compiler ) . Borrowed from Mathematics (number,char ,alphanumeric, whole number, real number)
   >
   >   - Ex:- 
   >
   >     ```c#
   >     int x; // x resresents value from Number , Size and Range , convert,parse
   >     char c; // c represents value from Charcters 
   >     student std;//Domain Unkonwn
   >     ```
   >
   >     
   >
   > - User Defined Datatype :  Programmer Defined Datatype 
   >
   >   - ex:- Add 10 and 20 
   >   - Add Customer
   >     - Banking Domain
   >     - Retail Domain
   >   - ex: Add new student to C# Training course
   >     - data : student  {id,name,photo,}
   >     - Describe Domain Of Student based on Philips Learning and Development Team inputs 
   >
   > - Encapsulating Object  using C# Constructs
   >
   >   - User Defined Datatype
   >     - "**Class**"
   >     - "**Struct**"



### Object and Memory

---

- Object State occupy memory
- Data Structures
  - Stack 
    - short lived  (Method Execution)
    - Auto Clean up
    - Thread Safe
  - Heap 
    - Lifetime Dynamic (program Algorithm)
    - Explicit Memory Management
    - Not Thread safe 
      - explicit Thread Synchronization Mechanism
  - Static area
    - Application Lifetime

#### Class v/s Struct



| Class                 | struct                                                       |
| --------------------- | ------------------------------------------------------------ |
| Object -> Heap        | Object -> stack,heap,static                                  |
| MSIL -> ReferenceType | MSIL - > Value Type                                          |
|                       | C# Built-in Types are struct  (int,float,char, double....) <br /> int x; //   Int x=new Int(); |



### Class -  user defined type

----

> "class" C# keywod generates "ReferenceType" in MSIL

```C#
//Encapsulation 
<AccessModifier> class <RoleName>{

    //Responsibilities
    /*
    Fields
    Properties
    Initializers
    Indexers
    events
    Nested Types
    */

}

Ex:-
    //RoleName :- Noun
class Student{
    
    
}    
    
```



### Assignment

| Object              | Role                     | Responsibilities                                         | State(Data Members)                                  | Behavior(Operations) | Events |
| ------------------- | ------------------------ | -------------------------------------------------------- | ---------------------------------------------------- | -------------------- | ------ |
| TDSDataModel        | Information Holder       | Classify/Describe TDS Data                               | Trade ID, Date, Current trade value, Counterparty ID | Nill                 |        |
| RDSDataModel        | Information holder       | Classify/Describe RDS Daat                               | CounterPartyId,<br />Name                            | Nill                 |        |
| RiskCalculator      | Business Logic Processor | Calculate Risk                                           |                                                      | Calculate()          |        |
| RiskInputDataMerger | Data Mapper              | Combine RDS and TDS Data and Generates RiskInpuDataModel |                                                      | Merge()              |        |
| RiskInputDataModel  | Information Holder       | Classify/Descibe Risk Calculator input Data              |                                                      |                      |        |

Model Design Decisions Using Modeling Language - UML (class Diagram , Object Diagram ,Sequence Diagram,Relationships (Inheritance,Association, Aggregation , Composition))

### Development 

____

- IDE :- Integrated Development Environment

  - Visual Studio

- Framework

  

| IDE Version | Framework Support |
| ----------- | ----------------- |
| 2003        | 1.1               |
| 2005        | 2.0               |
| 2008        | 3.0               |
| 2010        | 3.0/3.5           |
| 2013        | 4.0               |
| 2015        | 4.5               |
| 2017        | 4.6               |
| 2019        |                   |

### Framework Installation Location

> C:\Windows\Microsoft.NET\Framework(64)

### Dotnet Application BuildingBlocks

---

- Components -> Assemblies (executable/Library Image)
  - .exe
  - .dll 
- Solution
  - Project...1
    - Build Output
      - Component/Assembly (.exe/.dll)
  - Project...2
    - Build Outpue
      - Component/Assembly (.exe/dll)
  - Project...3
    - Component/Assembly (.exe/dll)
  - Project....n
    - Component/Assembly (.exe/dll)
- exe vs dll
  - Components - Windows Operating System
  - exe -> outprocess Components
  - dll -> InProcess Components
- .exe - ConsoleApplication template
- .dll - ClassLibrary template



### Assembly

---

- Basic unit of  execution - CLR(Virtual Machine)

- Assembly Contains Module

- Module Contains MSIL, Metadata , Manifest

- Assembly - Identity

  - "String" -   "NameOfTheAssembly,Version=Major.Minor.Build.Revision,PublicKey=Null /160 Bytes,Culture=language-region (Netural - default from OS )"

  - Metadata or Manifest holds - Assembly Identity

    

```
//From Metadata - FinancialRiskCalculatorApp.exe
Assembly
-------------------------------------------------------
	Token: 0x20000001
	Name : FinancialRiskCalculatorApp
	Public Key    :
	Hash Algorithm : 0x00008004
	Version: 1.0.0.0
	Major Version: 0x00000001
	Minor Version: 0x00000000
	Build Number: 0x00000000
	Revision Number: 0x00000000
	Locale: <null> //Culture - OS Culture

```

> By Default Assembly Identity token -  Public key value is null
>
> "Digital Signed Assembly will have public key"
>
> "Strong Name" :- Assembly Identity -with pubic key value
>
> "Digital Signed Assembly will have strong name identity"



#### .Net Application Deployment

----

- Target Machine -  .Net fx must be installed

- Dependency Location

- | Strong Name based Dependency                                 | Dependency Without Strong Name                               |
  | ------------------------------------------------------------ | ------------------------------------------------------------ |
  | Location - GAC (Global Assembly Cache) / Application Folder  | Location - Application Folder                                |
  | Public Assembly Deployment                                   | Private Assembly Deployment                                  |
  | Assembly visibility -> System                                | Assemblies Visibility restricted to folder                   |
  | GAC Location : "C:\Windows\Microsoft.NET\assembly"<br />gacutil.exe | Ex:- RisckCalculator.dll is now known as private assembly  of - FinancilaRiskCalculator.exe |
  | One Instance of Deployment ,Side By Side Installation Support,Strict Version Check, Single point/location upgradation(easy redirection from one version to another) | Private Assembly Advantages : Simple Deployment , Each Application Will have its own copy dependency. |
  | Deployment Challenge : GAC expects strong name based assembly, Requires admin rights. | Deployment Challenges : No Strict Version Checking (No Backward compatibility). No Side By Side Installation Support by Default (Private probing Path), Upgradation Issues ex:- if multiple apps using same library and deployed using different folder structure , then each app will have its own private copy of lib. if Existing apps like to redirect from old version of lib to new version of Lib ...? cost of upgradation |

  

#### why GAC need StrongName?

----

GAC Folder Structure

- ```
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>gacutil -i RiskCalculatorLib.dll
  Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
  Copyright (c) Microsoft Corporation.  All rights reserved.
  
  Failure adding assembly to the cache: Attempt to install an assembly without a strong name
  ```

- After Signing

- ```
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>gacutil -i RiskCalculatorLib.dll
  Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
  Copyright (c) Microsoft Corporation.  All rights reserved.
  
  
  Assembly successfully added to the cache
  
  GAC Folder
  	Folder < using Assembly Name From The Strong Name>
  	   Folder <using Version and Hash(Public Key)= PublicKeyToken (8 Bytes)>
  	      DLL File
  	      
  "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\RiskCalculatorLib\v4.0_1.0.0.0__43ba8707d0c5610b\RiskCalculatorLib.dll"
  
  eX: GAC_MSIL
  		RiskCalculatorLib
  		   1.0.0.0_43ba8707d0c5610b
  		       RiskCalculatorLib.dll
  		       
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\2.0.0.0>gacutil -i RiskCalculatorLib.dll
  
  "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\RiskCalculatorLib\v4.0_2.0.0.0__43ba8707d0c5610b\RiskCalculatorLib.dll"
  GAC_MSIL
  		RiskCalculatorLib
  		   1.0.0.0_43ba8707d0c5610b
  		       RiskCalculatorLib.dll
  		   2.0.0.0_43ba8707d0c5610b
  		   	   RiskCalculatorLib.dll
  		      
  ```

  

#### Assembly Signing

---

1. Key Pair (public key (Big Prime Number- 160 Bytes of Data) and Private Key)

   1. use test key pair .....generated from sn.exe
   2. generated key pair can be stored in - .snk files

2. Hash (Assembly Contents) -> Message Digest

3. Encrypt (Message Digest) using Private Key => Signature

4. Save Signature + Public Key in  Assembly [ Public Key Used to verify Signature and part of assembly identity]

   > Go to project Properties -> enable signing option > choose key pair file- > Rebuild

```
//Use SN.exe tool to verify Assembly Strong Name
D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>sn -v RiskCalculatorLib.dll

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

RiskCalculatorLib.dll does not represent a strongly named assembly
```

> ```
> //Use Dumpbin.exe tool to dup CLRHEADER
> 
> D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>dumpbin /CLRHEADER RiskCalculatorLib.dll
> Microsoft (R) COFF/PE Dumper Version 14.27.29111.0
> Copyright (C) Microsoft Corporation.  All rights reserved.
> 
> 
> Dump of file RiskCalculatorLib.dll
> 
> File Type: DLL
> 
>   clr Header:
> 
>               48 cb
>             2.05 runtime version
>             206C [     600] RVA [size] of MetaData Directory
>                1 flags
>                    IL Only
>                0 entry point token
>                0 [       0] RVA [size] of Resources Directory
>                0 [       0] RVA [size] of StrongNameSignature Directory
>                0 [       0] RVA [size] of CodeManagerTable Directory
>                0 [       0] RVA [size] of VTableFixups Directory
>                0 [       0] RVA [size] of ExportAddressTableJumps Directory
>                0 [       0] RVA [size] of ManagedNativeHeader Directory
> ```



#### Post Signing

---



```
D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>ildasm RiskCalculatorLib.dll

Assembly
-------------------------------------------------------
	Token: 0x20000001
	Name : RiskCalculatorLib
	Public Key    : 00 24 00 00 04 80 00 00  94 00 00 00 06 02 00 00  00 24 00 00 52 53 41 31 
                      : 00 04 00 00 01 00 01 00  b5 5e 2f 0d 2c 8a 06 2d  86 11 6c 9e ca a5 0a c4 
                      : 69 17 3c 7d 3e 5a a1 fe  01 f6 58 db b5 51 b5 82  dd 2b 2c b2 ac 6b 09 12 
                      : f8 b8 31 59 f8 92 c3 5d  63 a5 ff 57 51 e8 a6 05  01 3b 03 82 13 02 c9 9e 
                      : 85 12 7c 09 64 8d 6c b8  4d 6e 53 6b 71 cf 67 f8  2d e9 55 cf 2d 06 f8 b3 
                      : 65 ec 30 cb 3d 9b 00 23  88 43 cb 30 f6 b8 b7 72  23 52 56 70 1d bf d8 02 
                      : 73 eb a0 1a c8 4c eb 23  0a 99 ca 86 96 11 0a bb 
	Hash Algorithm : 0x00008004
	Version: 1.0.0.0
	Major Version: 0x00000001
	Minor Version: 0x00000000
	Build Number: 0x00000000
	Revision Number: 0x00000000
	Locale: <null>

```

### Object Oriented Programming Using  C#

----

### Access Modifiers / Visibility Setters

- private - (local to type (class,struct))
- protected - (type and family)
- internal - (local to assembly )
- protected internal (protected or internal)
- public (Unrestricted)

### Keywords

----

> class , struct , interface , enum, static , cost , readonly , ref , out , params , is , as , delegate , event , var , private, public , internal, protected , public , virtual, abstract , override , sealed 



##### static

-----

- data Member
- functions 

```c#
//ReferenceType
public class A{
    public static int x; //static data Member
    public int y;//Non static Data Member
    public B obj_b=new B(); // heap allocation
    public static void Fun(){ /* Member Function */
       B newobj_b=new B();//Stack Allocation
        
    }
}
//ValueType - stack
public struct B{
    public static int xx; //static data Member
    public int yy;//Non static Data Member
   public static void Foo(){ /* Member Function */
    
    
}

public class MainClass{
    //Thread - Execution Path , Function Centric
    public static void Main(){
        
        A obj=new A();//TypeLoad
        obj.y=30;
        A obj2=new A();
        obj.y=50;
        A obj3=new A();
        obj.y=100;
        
        A.x=10;
        A.x-20;
        A.x=30;
        
        B bObj=new B();//stack allocation
        bObj.xx=100;

        
    }
}
    /* In the above example obj,obj2,obj3 will be allocated on Heap because "type A is a reference type" . "bObj" will be allocated on current thread stack because "B is a value type"
    
    
    class BankAccount{
    static string IFSCCode 
    string accountNumber;
    string accountType;
    double balance;
    double minBalance;
    
    }
    // N number of BankAccount Objects
    BankAccount instance1=new BankAccount();
        BankAccount instance2=new BankAccount();
            BankAccount instance3=new BankAccount();
                BankAccount instance4=new BankAccount();  
                BankAccount instance5=new BankAccount();
    
  public class A{
  int x=10;
  //compiler - public void Fun(readonly A this){}
  public void Fun(){
  
  //require access -> member x

  
  }
  //public void Foo(int x, string y, readonly A this)
  public void Foo(int x,string y){}
  
  }
  
  public static  void DoWork(){
  
  }
  class B{
  
  static void Main(){
  
  A obj=new A();
  obj.Fun();
  
  }
  
  
```

|                        | Static Data Member             | Non Static Data member                      |
| ---------------------- | ------------------------------ | ------------------------------------------- |
| Life Time              | Process                        | Object Lifetime                             |
| Memory Allocation Time | **Class/Type Load              | Instantiate                                 |
| Allocation frequency   | Once                           | per object                                  |
| Reference              | TypeName.StaticDataMemeberName | objectReference.MemberName                  |
| Memory Location        | Static Area (Pinned table)     | ReferenceType = Heap<br />ValueType = Stack |

> **Class/Type Load  :-  First ever interaction between thread and datatype



##### static functions/behaviors



|                       | Static Function          | Non Static Function                |
| --------------------- | ------------------------ | ---------------------------------- |
| has "this" argument   | N.A                      | yes                                |
| Data Members - Access | Static Data Members Only | Static and Non Static Data members |
| Invocation            | ClassName.MethodName()   | ObjectReference.MethodName()       |
|                       |                          |                                    |



#### Initializers / Constructors

---

- Special function 

  - function name same as class/struct name

  

- Initialize Data members of the class , when the object created and before it is in use 

- Use Constructor to initialize data members of   Immutable Object

- Data Members

  - static data members
    - static initializer / Constructor
  - Non Static Data members 
    - Non Static initializer / Constructor

- Classification Of Initializers

|                     | Static Initializer              | Non Static Initializer |
| ------------------- | ------------------------------- | ---------------------- |
| has "this"          | N.A                             | yes                    |
| Explicit Call       | implicit Call                   | Explicit Call          |
| Execution Time      | Type/Class Load                 | Instantiation          |
| Visibility          | Private (default)               | Set by Programmer      |
| Overloading         | Not Supported ...zero arguments | Overloaded             |
| Member Access       | Static Members                  | Static/Non Static      |
| Execution Frequency | Only Once                       | Per Instantiation      |

```C#
public class Patient{

    string mrn,name,email;
    string contactNumber;
    public static void SayHello(){
        
        System.Console.WriteLine('Hi from Static SayHello');
    }
	//default Constructor , explicit Call 
	private Patient(){
		System.Console.WriteLine("Default Constructor");
        this.mrn=Patient.GetAutoGenreratedMrn();
	} 
    //overload Constructor
    public Patient(string name):this(){
        this.name=name;

    }
    public Patient(string name,string email):this(name){
        this.email=email;
    }
    public Patient(string name,string contactNumber):this(name)
    {
        this.contactNumber=contactNumber;
        
    }
    public Patient(string name,string contactNumber,string email):this(name){
        this.contactNumber=contactNumber;
        this.email=email;
    }
	 // static initializer , implicit Call
	static Patient(){
	System.Console.WriteLine("Static  Constructor");
	}
    static string GetAutoGenreratedMrn(){
        System.Random _random=new System.Random();
       int number= _random.Next();
        string _newMrnValue="MRN"+number;
        return _newMrnValue;
    }
}
public class A
{
	public static void Main()
	{

        Patient.SayHello();
		Patient obj=new Patient("tom");//Overloaded Constructor Call
		Patient newObj=new Patient("hary");//Overloaded Constructor Call
	}
}



```

> Explore Singleton instance pattern

```
public class ICU{

}

 
```

