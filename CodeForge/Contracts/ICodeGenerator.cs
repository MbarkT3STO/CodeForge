using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForge.Enums;

namespace CodeForge.Contracts;

/// <summary>
/// Represents a code generator.
/// </summary>
public interface ICodeGenerator
{
	/// <summary>
	/// Generates a code based on the specified options.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateCode(ICodeGenerationOptions options);
	
	
	/// <summary>
	/// Generates a code based on the specified options.
	/// </summary>
	/// <param name="length">The length of the code to generate.</param>
	/// <param name="codeType">The type of code to generate.</param>
	/// <param name="letterCase">The letter case to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateCode(int length, CodeType codeType, LetterCase letterCase);
	
	
	/// <summary>
	/// Generates a code based on the specified options.
	/// </summary>
	/// <param name="length">The length of the code to generate.</param>
	/// <param name="letterCase">The letter case to use when generating the code.</param>
	/// <param name="customCharacters">The custom characters to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateCode(int length, LetterCase letterCase, string customCharacters);
}
