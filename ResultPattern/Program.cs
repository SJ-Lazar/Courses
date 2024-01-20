using System;
using CSharpFunctionalExtensions;

static void Main(string[] args)
{
    var result = DoWork("Hello");
    string? message = result.IsSuccess ? $"Success: {result.Value}" : $"Failed: {result.Error}";
    Console.WriteLine(message);

    result = DoWork(null);
    message = result.IsSuccess ? $"Success: {result.Value}" : $"Failed: {result.Error}";
    Console.WriteLine(message);
}

static Result<string> DoWork(string input)
{
    if (string.IsNullOrEmpty(input))
        return Result.Failure<string>("Input cannot be null or empty");

    string output = input + " World";

    return Result.Success(output);
}






