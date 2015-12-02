To demonstrate the problem:

```
$ git clone https://github.com/tomkcook/T4CSTest
$ cd T4CSTest
$ xbuild T4CSTest/T4CSTest.csproj
$ xbuild Templates/Templates.csproj
$ Templates/bin/Debug/Templates.exe 
namespace Foo { public class Program { public static void Main(string[] args) { Console.WriteLine("Hello, World"); } } }
$ /usr/lib/monodevelop/AddIns/MonoDevelop.TextTemplating/TextTransform.exe -P=Templates/bin/Debug -P=/usr/lib/mono/4.5/Facades Templates/T4Template.tt
Invalid type Microsoft.CodeAnalysis.SyntaxTree for instance field Microsoft.CodeAnalysis.SyntaxNode:_syntaxTree
Processing 'Templates/T4Template.tt' failed.
(0,0): ERROR Error running transform: System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. ---> System.TypeLoadException: Failure has occurred while loading a type.
  at T4CSTest.Utilities.GetFirstNamespace (System.String code) <0x4133c4e0 + 0x0002f> in <filename unknown>:0 
  at Microsoft.VisualStudio.TextTemplating.GeneratedTextTransformation40cd412f.TransformText () <0x4133bfa0 + 0x0009b> in <filename unknown>:0 
  at (wrapper managed-to-native) System.Reflection.MonoMethod:InternalInvoke (System.Reflection.MonoMethod,object,object[],System.Exception&)
  at System.Reflection.MonoMethod.Invoke (System.Object obj, BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) <0x7f0dd35ab780 + 0x000a1> in <filename unknown>:0 
  --- End of inner exception stack trace ---
  at System.Reflection.MonoMethod.Invoke (System.Object obj, BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) <0x7f0dd35ab780 + 0x000ef> in <filename unknown>:0 
  at System.Reflection.MethodBase.Invoke (System.Object obj, System.Object[] parameters) <0x7f0dd33e3cf0 + 0x0002a> in <filename unknown>:0 
  at Mono.TextTemplating.CompiledTemplate.Process () <0x4133b520 + 0x0036f> in <filename unknown>:0 
```
