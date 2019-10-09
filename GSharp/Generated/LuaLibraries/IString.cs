//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSharp.Generated.LuaLibraries {
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System;
    
    
    /// <summary>
    /// 
    /// <list type='bullet'>
    /// <listheader><description>The string ''type'' is a sequence of characters.The string ''library'' is a standard Lua library which provides functions for the manipulation of strings. In Garry's Mod there are several extra useful functions added to this library.Every string.</description></listheader>
    /// <item><description> function that has a string as first argument is also available as a method for the string type. That means that with string.Right("somestring", 4) for example you can also call ("somestring"):Right(4) which will do the same thing.</description></item>
    /// </list>
    /// 
    /// This category lists functions available in the string ''library''.
    /// </summary>
    public interface IString {
        
        /// <summary>
        /// Returns the given string's characters in their numeric ASCII representation.
        /// </summary>
        /// <returns>Type: System.Object - Numerical bytes</returns>
        /// <param name='string'>The string to get the chars from.</param>
        /// <param name='startPos'>The first character of the string to get the byte of.</param>
        /// <param name='endPos'>The last character of the string to get the byte of.</param>
        object @byte(string @string, [OptionalAttribute()] double startPos, [OptionalAttribute()] double endPos);
        
        /// <summary>
        /// Takes the given numerical bytes and converts them to a string.
        /// </summary>
        /// <returns>Type: System.String - String built from given bytes</returns>
        /// <param name='bytes'>The bytes to create the string from.</param>
        string @char(object bytes);
        
        /// <summary>
        /// Inserts commas for every third digit.
        /// </summary>
        /// <returns>Type: System.String -  Prettystring</returns>
        /// <param name='InputNumber'>The input number to commafy</param>
        string Comma(double InputNumber);
        
        /// <summary>
        /// Returns whether or not the second passed string matches the end of the first.
        /// </summary>
        /// <returns>Type: System.Boolean - ''true'' if the first string ends with the second, or the second is empty, otherwise ''false''.</returns>
        /// <param name='str'>The string whose end is to be checked.</param>
        /// <param name='end'>The string to be matched with the end of the first.</param>
        bool EndsWith(string str, string end);
        
        /// <summary>
        /// Splits a string up wherever it finds the given separator.This is the reverse of LibraryFunctionstringImplode.
        /// </summary>
        /// <returns>Type: System.Object[] - Exploded string as a numerical sequential table.</returns>
        /// <param name='separator'>The string will be separated wherever this sequence is found.</param>
        /// <param name='str'>The string to split up.</param>
        /// <param name='use_patterns'>Set this to true if your separator is a [[Patterns|pattern]].</param>
        object[] Explode(string separator, string str, bool use_patterns);
        
        /// <summary>
        /// Attempts to find the specified substring in a string, uses [[Patterns]] by default.
        /// </summary>
        /// <param name='haystack'>The string to search in.</param>
        /// <param name='needle'>The string to find, can contain patterns if enabled.</param>
        /// <param name='startPos'>The position to start the search from, can be negative start position will be relative to the end position.</param>
        /// <param name='noPatterns'>Disable patterns.</param>
        void find(string haystack, string needle, [OptionalAttribute()] double startPos, [OptionalAttribute()] bool noPatterns);
        
        /// <summary>
        /// Returns the time as a formatted string or as a table if no format is given.
        /// </summary>
        /// <returns>Type: System.String - Returns the time as a formatted string only if a format was specified.Returns a table only if no format was specified. The table will contain these fields:<br/>FuncArgnumbermsmilliseconds<br/>FuncArgnumbersseconds<br/>FuncArgnumbermminutes<br/>FuncArgnumberhhours<br/><br/></returns>
        /// <param name='float'>The time in seconds to format.</param>
        /// <param name='format'>An optional formatting to use. If no format it specified, a table will be returned instead.</param>
        string FormattedTime(double @float, [OptionalAttribute()] string format);
        
        /// <summary>
        /// Formats the specified values into the string given.
        /// </summary>
        /// <returns>Type: System.String - The formatted string</returns>
        /// <param name='format'>The string to be formatted.<br>Follows this format: http://www.cplusplus.com/reference/cstdio/printf/</param>
        /// <param name='formatParameters'>Values to be formatted into the string.</param>
        string format(string format, object formatParameters);
        
        /// <summary>
        /// Creates a string from a Color variable.
        /// </summary>
        /// <returns>Type: System.String - Output</returns>
        /// <param name='color'>The color to put in the string.</param>
        string FromColor(object[] color);
        
        /// <summary>
        /// DeprecatedUse either string.sub(str, index, index) or str[index]. Returns char value from the specified index in the supplied string.
        /// </summary>
        /// <returns>Type: System.String -  str</returns>
        /// <param name='str'>The string that you will be searching with the supplied index.</param>
        /// <param name='index'>The index's value of the string to be returned.</param>
        string GetChar(string str, double index);
        
        /// <summary>
        /// Returns extension of the file.
        /// </summary>
        /// <returns>Type: System.String -  fileExtension</returns>
        /// <param name='file'>String eg. file-path to get the file extensions from.</param>
        string GetExtensionFromFilename(string file);
        
        /// <summary>
        /// Returns file name and extension.
        /// </summary>
        /// <returns>Type: System.String - The file name</returns>
        /// <param name='pathString'>The string eg. file-path to get the file-name from.</param>
        string GetFileFromFilename(string pathString);
        
        /// <summary>
        /// Returns the path only from a file's path.
        /// </summary>
        /// <returns>Type: System.String - Path</returns>
        /// <param name='Inputstring'>String to get path from.</param>
        string GetPathFromFilename(string Inputstring);
        
        /// <summary>
        /// Using [[Patterns]], returns an iterator which will return either one value if no capture groups are defined, or any capture group matches.
        /// </summary>
        /// <returns>Type: System.Object - The iterator function that can be used in a for-in loop</returns>
        /// <param name='data'>The string to search in</param>
        /// <param name='pattern'>The pattern to search for</param>
        object gmatch(string data, string pattern);
        
        /// <summary>
        /// This functions main purpose is to replace certain character sequences in a string using [[Patterns]].
        /// </summary>
        /// <param name='string'>String which should be modified.</param>
        /// <param name='pattern'>The pattern that defines what should be matched and eventually be replaced.</param>
        /// <param name='replacement'>In case of a string the matches sequence will be replaced with it.In case of a table, the matched sequence will be used as key and the table will tested for the key, if a value exists it will be used as replacement.In case of a function all matches will be passed as parameters to the function, the return value(s) of the function will then be used as replacement.</param>
        /// <param name='maxReplaces'>Maximum number of replacements to be made.</param>
        void gsub(string @string, string pattern, string replacement, [OptionalAttribute()] double maxReplaces);
        
        /// <summary>
        /// Joins the values of a table together to form a string.This is the reverse of LibraryFunctionstringExplode and is functionally identical to LibraryFunctiontableconcat, but with less features.
        /// </summary>
        /// <returns>Type: System.String - Imploded pieces</returns>
        /// <param name='separator'>The separator to insert between each piece.</param>
        /// <param name='pieces'>The table of pieces to concatenate. The keys for these must be numeric and sequential.</param>
        string Implode([OptionalAttribute()] string separator, object[] pieces);
        
        /// <summary>
        /// Escapes special characters for JavaScript in a string, making the string safe for inclusion in to JavaScript strings.
        /// </summary>
        /// <returns>Type: System.String - The escaped string.</returns>
        /// <param name='str'>The string that should be escaped.</param>
        string JavascriptSafe(string str);
        
        /// <summary>
        /// Returns everything left of supplied place of that string.
        /// </summary>
        /// <returns>Type: System.String - Returns a string containing a specified number of characters from the left side of a string.</returns>
        /// <param name='str'>The string to extract from.</param>
        /// <param name='num'>Amount of chars relative to the beginning (starting from 1).</param>
        string Left(string str, double num);
        
        /// <summary>
        /// Counts the number of characters in the string (length). This is equivalent to using the length operator (#).
        /// </summary>
        /// <returns>Type: System.Double - Length of the string</returns>
        /// <param name='str'>The string to find the length of.</param>
        double len(string str);
        
        /// <summary>
        /// Changes any upper-case letters in a string to lower-case letters.
        /// </summary>
        /// <returns>Type: System.String - The original string, with all uppercase letters replaced with their lowercase variants.</returns>
        /// <param name='str'>The string to convert.</param>
        string lower(string str);
        
        /// <summary>
        /// Finds a [[Patterns|Pattern]] in a string.
        /// </summary>
        /// <returns>Type: System.Object - Matched text(s)</returns>
        /// <param name='string'>String which should be searched in for matches.</param>
        /// <param name='pattern'>The pattern that defines what should be matched.</param>
        /// <param name='startPosition'>The start index to start the matching from, can be negative to start the match from a position relative to the end.</param>
        object match(string @string, string pattern, [OptionalAttribute()] double startPosition);
        
        /// <summary>
        /// Converts a digital filesize to human-readable text.
        /// </summary>
        /// <returns>Type: System.String - The human-readable filesize, in Bytes/KB/MB/GB (whichever is appropriate).</returns>
        /// <param name='bytes'>The filesize in bytes.</param>
        string NiceSize(double bytes);
        
        /// <summary>
        /// Formats the supplied number (in seconds) to the highest possible time unit.
        /// </summary>
        /// <returns>Type: System.String - A nicely formatted time string.</returns>
        /// <param name='num'>The number to format, in seconds.</param>
        string NiceTime(double num);
        
        /// <summary>
        /// Replaces all occurrences of the supplied second string.
        /// </summary>
        /// <returns>Type: System.String - string</returns>
        /// <param name='str'>The string we are seeking to replace an occurrence(s).</param>
        /// <param name='find'>What we are seeking to replace.</param>
        /// <param name='replace'>What to replace find with.</param>
        string Replace(string str, string find, string replace);
        
        /// <summary>
        /// Repeats a string by the provided number, with an optional separator.
        /// </summary>
        /// <returns>Type: System.String - Repeated string.</returns>
        /// <param name='str'>The string to convert.</param>
        /// <param name='repetitions'>Timer to repeat, this values gets rounded internally.</param>
        /// <param name='separator'>String that will separate the repeated piece. Notice that it doesn't add this string to the start or the end of the result, only between the repeated parts.</param>
        string rep(string str, double repetitions, [OptionalAttribute()] string separator);
        
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <returns>Type: System.String - reversed string</returns>
        /// <param name='str'>The string to be reversed.</param>
        string reverse(string str);
        
        /// <summary>
        /// Returns the last n-th characters of the string.
        /// </summary>
        /// <returns>Type: System.String - Returns a string containing a specified number of characters from the right side of a string.</returns>
        /// <param name='str'>The string to extract from.</param>
        /// <param name='num'>Amount of chars relative to the end (starting from 1).</param>
        string Right(string str, double num);
        
        /// <summary>
        /// Sets the character at the specific index of the string.
        /// </summary>
        /// <returns>Type: System.String -  ModifiedString</returns>
        /// <param name='InputString'>The input string</param>
        /// <param name='Index'>The character index, 1 is the first from left.</param>
        /// <param name='ReplacementChar'>String to replace with.</param>
        string SetChar(string InputString, double Index, string ReplacementChar);
        
        /// <summary>
        /// Splits the string into a table of strings, separated by the second argument.
        /// </summary>
        /// <returns>Type: System.Object[] - Split table</returns>
        /// <param name='Inputstring'>String to split</param>
        /// <param name='Separator'>Character(s) to split with.</param>
        object[] Split(string Inputstring, string Separator);
        
        /// <summary>
        /// Returns whether or not the first string starts with the second.
        /// </summary>
        /// <returns>Type: System.Boolean - Whether the first string starts with the second.</returns>
        /// <param name='inputStr'>String to check.</param>
        /// <param name='start'>String to check with.</param>
        bool StartWith(string inputStr, string start);
        
        /// <summary>
        /// Removes the extension of a path.
        /// </summary>
        /// <returns>Type: System.String - Modifiedstring</returns>
        /// <param name='Inputstring'>The path to change.</param>
        string StripExtension(string Inputstring);
        
        /// <summary>
        /// Returns a sub-string, starting from the character at position ''StartPos'' of the string (inclusive), and optionally ending at the character at position ''EndPos'' of the string (also inclusive). If EndPos is not given, the rest of the string is returned.
        /// </summary>
        /// <returns>Type: System.String - The substring.</returns>
        /// <param name='string'>The string you'll take a sub-string out of.</param>
        /// <param name='StartPos'>The position of the first character that will be included in the sub-string.</param>
        /// <param name='EndPos'>The position of the last character to be included in the sub-string. It can be negative to count from the end.</param>
        string sub(string @string, double StartPos, [OptionalAttribute()] double EndPos);
        
        /// <summary>
        /// Fetches a Color type from a string.
        /// </summary>
        /// <returns>Type: System.Object[] - The output StructColor</returns>
        /// <param name='Inputstring'>The string to convert from.</param>
        object[] ToColor(string Inputstring);
        
        /// <summary>
        /// Returns given time in "MM:SS:MS" format.
        /// </summary>
        /// <returns>Type: System.String - Formatted time</returns>
        /// <param name='time'>Time in seconds</param>
        string ToMinutesSecondsMilliseconds(double time);
        
        /// <summary>
        /// Returns given time in "MM:SS" format.
        /// </summary>
        /// <returns>Type: System.String - Formatted time</returns>
        /// <param name='time'>Time in seconds</param>
        string ToMinutesSeconds(double time);
        
        /// <summary>
        /// Splits the string into characters and creates a sequential table.
        /// </summary>
        /// <param name='string'>The string you'll turn into a table.</param>
        void ToTable(string @string);
        
        /// <summary>
        /// Removes leading spaces/characters from a string.
        /// </summary>
        /// <returns>Type: System.String - Trimmed string</returns>
        /// <param name='str'>String to trim</param>
        /// <param name='char'>Custom character to remove</param>
        string TrimLeft(string str, [OptionalAttribute()] string @char);
        
        /// <summary>
        /// Removes trailing spaces/passed character from a string.
        /// </summary>
        /// <returns>Type: System.String - Trimmed string</returns>
        /// <param name='str'>String to remove from</param>
        /// <param name='char'>Custom character to remove, default is a space</param>
        string TrimRight(string str, [OptionalAttribute()] string @char);
        
        /// <summary>
        /// Removes leading and trailing matches of a string.
        /// </summary>
        /// <returns>Type: System.String - Modified string</returns>
        /// <param name='Inputstring'>The string to trim.</param>
        /// <param name='Char'>String to match.</param>
        string Trim(string Inputstring, [OptionalAttribute()] string Char);
        
        /// <summary>
        /// Changes any lower-case letters in a string to upper-case letters.
        /// </summary>
        /// <returns>Type: System.String - A string representing the value of a string converted to upper-case.</returns>
        /// <param name='str'>The string to convert.</param>
        string upper(string str);
        
        /// <summary>
        /// DeprecatedThis function is removed in Lua versions later than what GMod is currently using. Use LibraryFunctionstringgmatch instead.Returns an iterator function that is called for every complete match of the pattern, all sub matches will be passed as to the loop.
        /// </summary>
        /// <returns>Type: System.Object - The iterator function that can be used in a for-in loop</returns>
        /// <param name='data'>The string to search in</param>
        /// <param name='pattern'>The pattern to search for</param>
        object gfind(string data, string pattern);
        
        /// <summary>
        /// Returns the binary bytecode of the given function.NoteThis does not work with functions created in C/C++. An error will be thrown if it is
        /// </summary>
        /// <returns>Type: System.String - Bytecode</returns>
        /// <param name='func'>The function to get the bytecode of</param>
        /// <param name='stripDebugInfo'>True to strip the debug data, false to keep it</param>
        string dump(object func, [OptionalAttribute()] bool stripDebugInfo);
        
        /// <summary>
        /// Escapes all special characters within a string, making the string safe for inclusion in a Lua pattern.
        /// </summary>
        /// <returns>Type: System.String - The string that has been sanitized for inclusion in Lua patterns</returns>
        /// <param name='str'>The string to be sanitized</param>
        string PatternSafe(string str);
    }
}
