using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeForge.Contracts;

/// <summary>
/// Represents a code generator engine.
/// </summary>
public interface ICodeGeneratorEngine
{
	/// <summary>
	/// Generates a code containing only numbers.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateOnlyNumbers(ICodeGenerationOptions options);
	
	/// <summary>
	/// Generates a code containing only letters.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateOnlyLetters(ICodeGenerationOptions options);
	
	/// <summary>
	/// Generates a code containing numbers and letters.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateNumbersAndLetters(ICodeGenerationOptions options);
	
	/// <summary>
	/// Generates a code containing letters and symbols.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateLettersAndSymbols(ICodeGenerationOptions options);

	/// <summary>
	/// Generates a code containing numbers, letters and symbols.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateNumbersAndLettersAndSymbols(ICodeGenerationOptions options);

	/// <summary>
	/// Generates a code from custom characters.
	/// </summary>
	/// <param name="options">The options to use when generating the code.</param>
	/// <returns>A string containing the generated code.</returns>
	string GenerateFromCustomCharacters(ICodeGenerationOptions options);

}
