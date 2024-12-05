System.Console.WriteLine("automated testing ...");
System.Diagnostics.Debug.Assert(Library.ShiftedCharacter('a', 1) == 'b');
System.Diagnostics.Debug.Assert(Library.ShiftedCharacter('z', 1) == 'a');
System.Diagnostics.Debug.Assert(Library.LetterPosition('a') == 0);
System.Diagnostics.Debug.Assert(Library.LetterPosition('b') == 1);
System.Diagnostics.Debug.Assert(Library.LetterPosition('z') == 25);
System.Diagnostics.Debug.Assert(Library.WrapLetterPosition(0) == 0);
System.Diagnostics.Debug.Assert(Library.WrapLetterPosition(3) == 3);
System.Diagnostics.Debug.Assert(Library.WrapLetterPosition(26) == 0);
System.Diagnostics.Debug.Assert(Library.WrapLetterPosition(29) == 3);
System.Console.WriteLine("tests passed.");

Console.Write("Please Enter a character (I will display the shifted character): ");
int shiftNum = 1;
while(true){
    ConsoleKey keyRead = Console.ReadKey(true).Key;
    switch (keyRead){
        case ConsoleKey.UpArrow:
            shiftNum++;
            break;
        case ConsoleKey.DownArrow: 
            shiftNum--;
            break;
        default:
            keyRead.ToString();
            Console.Write(Library.ShiftedCharacter((char)keyRead, shiftNum));
            break;
    }
}
public class Library
{
    public static char ShiftedCharacter(char originalCharacter, int numToShiftBy)
    {
        
        return CharacterFromAscii(Library.WrapLetterPosition(LetterPosition(originalCharacter) + numToShiftBy) + 'a');
    }

    public static char CharacterFromAscii(int asciiValue)
    {
        return (char)asciiValue;
    }

    public static int LetterPosition(char originalCharacter)
    {
        return (originalCharacter - 'a');

    }

    public static int WrapLetterPosition(int Position)
    {
        return (Position % 26);
    }
}
public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}