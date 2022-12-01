using System;

/// <summary>
/// This is the custom sql server clr assembly exception.
/// </summary>
internal sealed class SqlClrException : Exception
{
	/// <summary>
	/// The standard constructor.
	/// </summary>
	/// <param name="message"></param>
	public SqlClrException(string message) : base(message)
	{
	}

	/// <summary>
	/// The "little bit" more constructor.
	/// </summary>
	/// <param name="message"></param>
	/// <param name="innerException"></param>
	public SqlClrException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
