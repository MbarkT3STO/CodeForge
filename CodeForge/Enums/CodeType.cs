namespace CodeForge.Enums;

/// <summary>
/// Represents the type of code to generate.
/// </summary>
public enum CodeType
{
	   /// <summary>
	   /// Indicates that the generated code should only contain numbers.
	   /// </summary>
	   OnlyNumbers,
	   
	   /// <summary>
	   /// Indicates that the generated code should only contain letters.
	   /// </summary>
	   OnlyLetters,
	   
	   /// <summary>
	   /// Indicates that the generated code should contain numbers and letters.
	   /// </summary>
	   NumbersAndLetters,
	   
	   /// <summary>
	   /// Indicates that the generated code should contain letters and symbols.
	   /// </summary>
	   LettersAndSymbols,
	   
	   /// <summary>
	   /// Indicates that the generated code should contain numbers, letters, and symbols.
	   /// </summary>
	   NumbersAndLettersAndSymbols,
	   
	   /// <summary>
	   /// Indicates that the generated code should contain custom characters.
	   /// </summary>
	   Custom
}
