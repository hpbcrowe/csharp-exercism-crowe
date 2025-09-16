using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
         string pattern = @"\p{IsGreekandCoptic}";
        int length = identifier.Length;
        StringBuilder nonLetter = new StringBuilder();
         StringBuilder result = new StringBuilder();
        for(int i = 0; i < length; i++)
        {
            if(Char.IsWhiteSpace(identifier[i]))
            {
                result.Append('_'); 
            }   
           else if(  char.IsControl(identifier[i])  )
            {
            result.Append("CTRL");
            }
            else if (identifier[i] == '-')
            {
                char upper = identifier[i + 1];
                result.Append(Char.ToUpper(upper));
                i++;
            }
 
           
            else if (char.IsNumber(identifier[i]))
            {
                nonLetter.Append(identifier[i]);
            }
			else if (!char.IsLetter(identifier[i]))
			{
				nonLetter.Append(identifier[i]);
			}
            //else if (Regex.IsMatch(identifier[i].ToString(), pattern))
            else if (identifier[i] >= 'α' && identifier[i] <= 'ω')
            {
                nonLetter.Append(identifier[i]);
            }
           else {
        result.Append(identifier[i]);
           }
            
        }
        

        return result.ToString();
    }
}
