using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForge.Contracts;
using CodeForge.Enums;

namespace CodeForge.Implementation;

/// <summary>
/// Represents the options to use when generating a code.
/// </summary>
public sealed class CodeGenerationOptions: ICodeGenerationOptions
{
	public int Length { get; private set; }
	public CodeType CodeType { get; private set; }	
	public LetterCase LetterCase { get; private set; }
	public string? CustomCharacters { get; private set; }
	
	
	/// <summary>
	/// Use this constructor when you want to generate a code from numbers only Or letters only Or numbers and letters.
	public CodeGenerationOptions( int length, CodeType codeType, LetterCase letterCase)
	{
		Length     = length;
		CodeType   = codeType;
		LetterCase = letterCase;
	}
	
	/// <summary>
	/// Use this constructor when you want to generate a code from a custom set of characters.
	/// </summary>
	/// <param name="length">The length of the code to generate.</param>
	/// <param name="letterCase">The letter case to use when generating the code.</param>
	/// <returns>A new instance of <see cref="CodeGenerationOptions"/>.</returns>
	public CodeGenerationOptions( int length, LetterCase letterCase, string customCharacters)
	{
		Length           = length;
		LetterCase       = letterCase;
		CustomCharacters = customCharacters;
		CodeType         = CodeType.Custom;
	}
}
