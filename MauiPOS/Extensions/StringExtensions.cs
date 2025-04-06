namespace MauiPOS.Extensions; // Adjust namespace to match your project

public static class StringExtensions
{
    public static string FirstCharToUpper(this string input) =>
        string.IsNullOrEmpty(input) ? input : char.ToUpper(input[0]) + input.Substring(1);
}