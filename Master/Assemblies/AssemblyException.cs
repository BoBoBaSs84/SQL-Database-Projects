using System;

/// <summary>
/// This is the custom sql server clr assembly exception.
/// </summary>
internal class AssemblyException : Exception
{
	/// <summary>
	/// The standard constructor.
	/// </summary>
	/// <param name="message"></param>
	public AssemblyException(string message) : base(message)
	{
	}

	/// <summary>
	/// The "little bit" more constructor.
	/// </summary>
	/// <param name="message"></param>
	/// <param name="innerException"></param>
	public AssemblyException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
