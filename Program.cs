using System;
using Sharprompt.Validations;

namespace sharprompt_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Sharprompt.Prompt.Input<string>("Please enter a name", "default", new[] { FakeValidator() });
            Console.WriteLine($"Entered {userName}");
        }

        internal static Func<object, ValidationResult> FakeValidator() => (obj) => {
            return string.IsNullOrWhiteSpace(obj.ToString()) ? new ValidationResult("Received empty string") : null;
        };
    }
}
