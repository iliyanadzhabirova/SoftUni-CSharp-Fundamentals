namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char firstChar=char.Parse(Console.ReadLine());
           char secondChar = char.Parse(Console.ReadLine());
            if ( firstChar > secondChar )
            {
                CharactersRange(secondChar, firstChar);
            }
           CharactersRange(firstChar,secondChar);
           

        }
        static void CharactersRange(char firstChar, char secondChar)
        {
           
            for (int i = firstChar+1; i < secondChar; i++)
            {
                Console.Write((char)i+" ");
            }
           
        }
    }
}