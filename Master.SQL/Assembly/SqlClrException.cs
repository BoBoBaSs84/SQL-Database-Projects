using System;

/// <summary>
/// This is the custom sql server clr exception.
/// </summary>
internal sealed class SqlClrException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SqlClrException"/> class.
	/// </summary>
	/// <param name="message">The exception message.</param>
	public SqlClrException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="SqlClrException"/> class.
	/// </summary>
	/// <param name="message">The exception message.</param>
	/// <param name="innerException">The inner exception.</param>
	public SqlClrException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
