using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.StackQueue;

public static class ValidParentheses
{
    public static bool Execute(string input) 
    {
        if (input is null)
            return false;

        var stack = new Stack<char>();

        foreach (var character in input)
        {
            if(character is '(' or '[' or '{')
            {
                stack.Push(character);
                continue;
            }

            if(character is ')' or ']' or '}') 
            {
                if(stack.Count == 0)
                    return false;

                var open = stack.Pop();

                if(!IsMatching(open, character))
                    return false;
            }
            else
            {
                // Se você quiser ser mais rígido, pode retornar false aqui.
                // Em entrevistas, eu costumo IGNORAR caracteres não relacionados.
                continue;
            }
        }
        return stack.Count == 0;
    }

    private static bool IsMatching(char open, char close) =>
        (open == '(' && close == ')') ||
        (open == '[' && close == ']') ||
        (open == '{' && close == '}');
}
