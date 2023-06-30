using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForge.Enums;

namespace CodeForge.Contracts;

/// <summary>
/// Represents the options to use when generating a code.
/// </summary>
public interface ICodeGenerationOptions
{
	int Length { get; }
	CodeType CodeType { get; }
	LetterCase LetterCase { get; }
	string? CustomCharacters { get; }
}
