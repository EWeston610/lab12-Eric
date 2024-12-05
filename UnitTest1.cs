//Eric Weston and Garin Humpherys
//Lab 1 8/29/24

using System.Data;

System.Console.WriteLine("automated testing ...");
System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
System.Diagnostics.Debug.Assert(ShiftedCharacter('z') == 'a');
System.Diagnostics.Debug.Assert(LetterPosition('a') == 0);
System.Diagnostics.Debug.Assert(LetterPosition('b') == 1);
System.Diagnostics.Debug.Assert(LetterPosition('z') == 25);
System.Diagnostics.Debug.Assert(WrapLetterPosition(0) == 0);
System.Diagnostics.Debug.Assert(WrapLetterPosition(3) == 3);
System.Diagnostics.Debug.Assert(WrapLetterPosition(26) == 0);
System.Diagnostics.Debug.Assert(WrapLetterPosition(29) == 3);
System.Console.WriteLine("tests passed.");

char ShiftedCharacter(char originalCharacter) {
    return CharacterFromAscii(WrapLetterPosition (LetterPosition(originalCharacter) + 1) + 'a');
}

char CharacterFromAscii(int asciiValue) {
    return (char) asciiValue;
}

int LetterPosition(char originalCharacter) {
    return (originalCharacter - 'a');

}

int WrapLetterPosition(int Position) {
    return (Position % 26);
}

Console.Write("Please Enter a character (I will display the shifted character): ");
Console.WriteLine(ShiftedCharacter(Console.ReadKey(true).KeyChar));