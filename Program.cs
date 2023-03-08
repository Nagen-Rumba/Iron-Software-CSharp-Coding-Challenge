using System.Runtime.InteropServices;

public class PracticeApps
{
   

    // Define a dictionary to map numbers to letters
    
    private static readonly Dictionary<string, string> NumberToLetterMap = new Dictionary<string, string> {
        {"1", "&"},
        {"11", "'"},
        {"111", "("},
        {"2", "A"},
        {"22", "B"},
        {"222", "C"},
        {"3", "D"},
        {"33", "E"},
        {"333", "F"},
        {"4", "G"},
        {"44", "H"},
        {"444", "I"},
        {"5", "J"},
        {"55", "K"},
        {"555", "L"},
        {"6", "M"},
        {"66", "N"},
        {"666", "O"},
        {"7", "P"},
        {"77", "Q"},
        {"777", "R"},
        {"7777", "S"},
        {"8", "T"},
        {"88", "U"},
        {"888", "V"},
        {"9", "W"},
        {"99", "X"},
        {"999", "Y"},
        {"9999", "Z"},
        {"0", " " },
        {"*", "*" },
        {"#", "" }

    };


    //This function returns the numbers in sequence.
    public static string checkSequence(string input)
    {
        string outputText = "";
        string result = "";
        int i = 0;

        while (input.Count() > 2 && i < input.Count()) {
            for (int j = i; j < input.Count(); j++)
            {
              

                // Check for previous value with current value-------------------
                if (input[i] == input[j])
                {
                    outputText += input[i];
                }
                //Append to result if the characters change and set the loop 
                else
                {
                    result += NumberToLetterMap[outputText];
                    i = j;
                    j--;
                    outputText = "";
                }

                //CHECKS FOR *, " ", # symbols which perform delete, 1 sec wait, send respectively -------------------
                if (input[j] == '*')
                {
                    result = result.Remove(result.Length - 1);
                }
                if (input[j] == ' ')
                {
                    outputText = "";
                    i++;
                }
                if (input[j] == '#')
                {
                    result += NumberToLetterMap[outputText];
                    i = input.Count() + 1;
                    break;
                }
                //End of check -------------------
            }
        }

        
        return result;
    }

    public static void Main(string[] args)
    {
        //Test Cases
        Console.WriteLine(checkSequence("33#")); // E
        Console.WriteLine(checkSequence("227*#")); //B
        Console.WriteLine(checkSequence("4433555 555666#")); //HELLO
        Console.WriteLine(checkSequence("8 88777444666*664#")); // turing
        Console.WriteLine(checkSequence("11 2 1 33* 3* 5#")); // 'a&j
        Console.WriteLine(checkSequence("1102233* 34333#")); //` bdgf
    }
}

