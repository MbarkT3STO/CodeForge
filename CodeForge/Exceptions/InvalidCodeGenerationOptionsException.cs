using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeForge.Exceptions;

public class InvalidCodeGenerationOptionsException : Exception
{
	public InvalidCodeGenerationOptionsException(string message) : base(message)
	{
	}
	
	public InvalidCodeGenerationOptionsException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
