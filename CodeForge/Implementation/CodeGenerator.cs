using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForge.Contracts;
using CodeForge.Enums;
using CodeForge.Exceptions;

namespace CodeForge.Implementation;

/// <summary>
/// Represents a code generator.
/// </summary>
public class CodeGenerator: ICodeGenerator
{
	private readonly ICodeGeneratorEngine _engine;
	
	
	public CodeGenerator()
	{
		_engine = new BaseCodeGeneratorEngine();
	}

	public CodeGenerator(ICodeGeneratorEngine engine)
	{
		_engine = engine;
	}


	public virtual string GenerateCode(ICodeGenerationOptions options)
	{
		switch (options.CodeType)
		{
			case CodeType.OnlyNumbers:
				return _engine.GenerateOnlyNumbers(options);
				
			case CodeType.OnlyLetters:
				return _engine.GenerateOnlyLetters(options);
				
			case CodeType.NumbersAndLetters:
				return _engine.GenerateNumbersAndLetters(options);
				
			case CodeType.LettersAndSymbols:
				return _engine.GenerateLettersAndSymbols(options);
				
			case CodeType.NumbersAndLettersAndSymbols:
				return _engine.GenerateNumbersAndLettersAndSymbols(options);
				
			case CodeType.Custom :
				if (!string.IsNullOrEmpty(options.CustomCharacters))
					return _engine.GenerateFromCustomCharacters(options);
				else
					throw new InvalidCodeGenerationOptionsException("Custom characters cannot be null or empty when using Custom code type.");
				
			default:
				throw new InvalidCodeGenerationOptionsException("Invalid Code Generator Options");
		}
	}

	/// <summary>
	/// Asynchronously, <inheritdoc cref="GenerateCode(ICodeGenerationOptions)"/>
	/// </summary>
	/// <inheritdoc cref="GenerateCode(ICodeGenerationOptions)"/>
	public virtual async Task<string> GenerateCodeAsync(ICodeGenerationOptions options)
	{
		switch (options.CodeType)
		{
			case CodeType.OnlyNumbers:
				return await Task.Run(() => _engine.GenerateOnlyNumbers(options));
				
			case CodeType.OnlyLetters:
				return await Task.Run(() => _engine.GenerateOnlyLetters(options));
				
			case CodeType.NumbersAndLetters:
				return await Task.Run(() => _engine.GenerateNumbersAndLetters(options));
				
			case CodeType.Custom :
				if (!string.IsNullOrEmpty(options.CustomCharacters))
					return await Task.Run(() => _engine.GenerateFromCustomCharacters(options));
				else
					throw new InvalidCodeGenerationOptionsException("Custom characters cannot be null or empty when using Custom code type.");
				
			default:
				throw new InvalidCodeGenerationOptionsException("Invalid Code Generator Options");
		}
	}


	public virtual string GenerateCode(int length, CodeType codeType, LetterCase letterCase)
	{
		var options = new CodeGenerationOptions(length, codeType, letterCase);

		return GenerateCode(options);
	}
	
	/// <summary>
	/// Asynchronously, <inheritdoc cref="GenerateCode(int, CodeType, LetterCase)"/>
	/// </summary>
	/// <inheritdoc cref="GenerateCode(int, CodeType, LetterCase)"/>
	public virtual async Task<string> GenerateCodeAsync(int length, CodeType codeType, LetterCase letterCase)
	{
		var options = new CodeGenerationOptions(length, codeType, letterCase);
		
		return await GenerateCodeAsync(options);
	}


	public virtual string GenerateCode(int length, LetterCase letterCase, string customCharacters)
	{
		var options = new CodeGenerationOptions(length, letterCase, customCharacters);
		
		return GenerateCode(options);
	}
	
	/// <summary>
	/// Asynchronously, <inheritdoc cref="GenerateCode(int, LetterCase, string)"/>
	/// </summary>
	public virtual Task<string> GenerateCodeAsync(int length, LetterCase letterCase, string customCharacters)
	{
		var options = new CodeGenerationOptions(length, letterCase, customCharacters);

		return GenerateCodeAsync(options);
	}
}
