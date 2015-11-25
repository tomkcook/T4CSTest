using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;

namespace T4CSTest
{
	public class Utilities
	{
		public string GetFirstNamespace(string code)
		{
			var tree = CSharpSyntaxTree.ParseText (code);
			var root = tree.GetRoot ();
			var @using = root.DescendantNodes ().OfType<UsingDirectiveSyntax> ();
			var @types = root.DescendantNodes ().OfType<TypeDeclarationSyntax> ();
			var @enums = root.DescendantNodes ().OfType<EnumDeclarationSyntax> ();
			var @namespaces = root.DescendantNodes ().OfType<NamespaceDeclarationSyntax> ();
			return @namespaces.First ().GetText ().ToString();
		}
	}
}
