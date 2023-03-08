# Iron-Software-CSharp-Coding-Challenge

This program is designed to convert a sequence of numbers into a string of letters using a mapping provided in a dictionary. It also supports special characters such as * for delete, # for end of input, and for a space.

**Usage**
The checkSequence function takes a string of numbers as input and returns the corresponding string of letters. The Main function contains several test cases demonstrating how to use the checkSequence function.

**Dictionary Mapping**
The NumberToLetterMap dictionary contains a mapping of numbers to letters based on the T9 predictive text input method. For example, the number "2" maps to the letters "A", "B", and "C". The mapping is as follows:

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

**Special Characters**
The checkSequence function also supports the following special characters:

*: Deletes the last character from the output string.
#: Ends the input sequence and returns the final output string.
: Adds a space to the output string.

**License**
This program is licensed under the MIT License. See the LICENSE file for details.
