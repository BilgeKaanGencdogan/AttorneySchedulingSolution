﻿using Core.Results.Bases;

namespace Core.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false, "")
        {
        }
    }
}