﻿namespace Hjx
{
	public class Result<T> : Result
	{
		public Result() : base()
		{
		}
		public T Data { get; set; }
	}
}
