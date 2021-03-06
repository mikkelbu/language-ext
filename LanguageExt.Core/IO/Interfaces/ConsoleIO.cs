using System;
using LanguageExt.Attributes;

namespace LanguageExt.Interfaces
{
    public interface ConsoleIO
    {
        ConsoleKeyInfo ReadKey();
        Unit Clear();
        int Read();
        string ReadLine();
        Unit WriteLine();
        Unit WriteLine(string value);
        Unit Write(string value);
        Unit SetBgColor(ConsoleColor color);
        Unit SetColor(ConsoleColor color);
        ConsoleColor BgColor { get; }
        ConsoleColor Color { get; }
    }

    /// <summary>
    /// Type-class giving a struct the trait of supporting Console IO
    /// </summary>
    /// <typeparam name="RT">Runtime</typeparam>
    [Typeclass("*")]
    public interface HasConsole<RT> : HasCancel<RT>
        where RT : struct, HasCancel<RT>
    {
        /// <summary>
        /// Access the console asynchronous effect environment
        /// </summary>
        /// <returns>Console asynchronous effect environment</returns>
        Aff<RT, ConsoleIO> ConsoleAff { get; }

        /// <summary>
        /// Access the console synchronous effect environment
        /// </summary>
        /// <returns>Console synchronous effect environment</returns>
        Eff<RT, ConsoleIO> ConsoleEff { get; }
    }
}
