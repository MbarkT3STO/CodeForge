using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForge.Contracts;
using CodeForge.Enums;

namespace CodeForge.Implementation;

/// <summary>
/// Represents a default code generator engine.
/// </summary>
public class BaseCodeGeneratorEngine: ICodeGeneratorEngine
{
	private readonly Random _random       = new();
	private readonly string _lowerLetters = "abcdefghijklmnopqrstuvwxyz";
	private readonly string _upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private readonly string _numbers      = "0123456789";
	private readonly string _symbols      = "!@#$%^&*()_+-=[]{};':,./<>?";

	public virtual string GenerateNumbersAndLettersAndSymbols(ICodeGenerationOptions options)
	{
		var characters = _numbers + _symbols;

		if (options.LetterCase == LetterCase.Upper)
			characters += _upperLetters;
		else if (options.LetterCase == LetterCase.Lower)
			characters += _lowerLetters;
		else if (options.LetterCase == LetterCase.Mixed)
			characters += _upperLetters + _lowerLetters;

		var result = new string(Enumerable.Repeat(characters, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		return result;
	}
	
	public virtual string GenerateLettersAndSymbols(ICodeGenerationOptions options)
	{
		var characters = _symbols;

		if (options.LetterCase == LetterCase.Upper)
			characters += _upperLetters;
		else if (options.LetterCase == LetterCase.Lower)
			characters += _lowerLetters;
		else if (options.LetterCase == LetterCase.Mixed)
			characters += _upperLetters + _lowerLetters;

		var result = new string(Enumerable.Repeat(characters, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		return result;
	}
	
	public virtual string GenerateFromCustomCharacters(ICodeGenerationOptions options)
	{
		var result = new string(Enumerable.Repeat(options.CustomCharacters, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		if (options.LetterCase == LetterCase.Upper)
			result = result.ToUpper();
		else if (options.LetterCase == LetterCase.Lower)
			result = result.ToLower();

		return result;
	}

	public virtual string GenerateNumbersAndLetters(ICodeGenerationOptions options)
	{
		var characters = _numbers;

		if (options.LetterCase == LetterCase.Upper)
			characters += _upperLetters;
		else if (options.LetterCase == LetterCase.Lower)
			characters += _lowerLetters;
		else if (options.LetterCase == LetterCase.Mixed)
			characters += _upperLetters + _lowerLetters;

		var result = new string(Enumerable.Repeat(characters, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		return result;
	}

	public virtual string GenerateOnlyLetters(ICodeGenerationOptions options)
	{
		var result = new string(Enumerable.Repeat(_lowerLetters, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		if (options.LetterCase == LetterCase.Upper)
			result = result.ToUpper();
		else if (options.LetterCase == LetterCase.Mixed)
			result = new string(result.Select(c => _random.Next(2) == 1 ? char.ToUpper(c) : c).ToArray());

		return result;
	}

	public virtual string GenerateOnlyNumbers(ICodeGenerationOptions options)
	{
		var result = new string(Enumerable.Repeat(_numbers, options.Length).Select(s => s[_random.Next(s.Length)]).ToArray());

		return result;
	}
}
