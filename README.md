# PuppyMilkWrapper

## What is?

### This project
PuppyMilkWrapper is an unoffical C# wrapper for [Puppy Milk Injector](https://v3rmillion.net/showthread.php?tid=1078773) 

### Puppy Milk Injector
[Puppy Milk Injector](https://v3rmillion.net/showthread.php?tid=1078773)  made by CompiledCode, Inspect & XGladius is an Injector that bypasses [DLL Analysis Check](https://v3rmillion.net/showthread.php?tid=1078539&highlight=DAC) for [Block Game]. You can download it at [here](https://cdn.discordapp.com/attachments/784597168887300106/785011977973268510/PuppyMilkV3.exe)
## Getting Started

### Installation
1. Download the DLL in releases
2. Add it to your project as reference

## Usage

### Basic Usage
1. Add `using PuppyMilkWrapper;` to your code
2. Set the Puppy Milk Injector path using `PuppyInjector.PuppyMilkPath = "[path here];"`
3. Use `PuppyInjector.Inject(<string> dllPath);` to Inject.

### Example code
```c#
using System;
using PuppyMilkWrapper;
namespace PuppyExample {
	internal static class Program {
		private static void Main()
		{
			Console.WriteLine("Setting Puppy Milk Path...");
			PuppyInjector.PuppyMilkPath = "C:\Users\TreTrauIT\Downloads\PuppyMilkV3.exe";
			Console.WriteLine("Injecting DLL...");
			PuppyInjector.Inject("krnl.dll"); // Krnl gang
			Console.WriteLine("Done!");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
```

## FAQ

### 1. Why you need to specify Puppy Milk path?
+ Because legal reasons I can't intergate Puppy Milk into the wrapper, I might do that in the future.

### 2. Who is the best waifu?
+ Hmm, this is hard for me but let's celebrate Megumin's birthday a few days ago :V
