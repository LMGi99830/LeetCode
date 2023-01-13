

public class Solution {
    public int RomanToInt ( string s )
    {
        char [ ] array = s.ToArray();
        int sum = 0;

        for ( int i = 0; i < array.Length - 1; i++ )
        {
            int value = returnNumber(array [ i ]);
            int nextValue = returnNumber(array [ i + 1 ]);

            if ( value < nextValue )
            {
                sum -= value;
            }
            else
            {
                sum += value;
            }
        }
        return sum + returnNumber(array [ array.Length - 1 ]);
    }

    public int returnNumber(char str)
    {
        switch ( str )
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            default:
                return 1000;
        }
    }
}