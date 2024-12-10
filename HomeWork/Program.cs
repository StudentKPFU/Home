// 67.Add binary
public string AddBinary(string a, string b)
{
    string sum = string.Empty;
    char tmpSymbol = '0';
    int minLength = Math.Min(a.Length, b.Length);
    for (int i = 0; i < minLength; i++)
    {
        int aIndex = a.Length - i - 1;
        if (a[aIndex] == b[b.Length - i - 1])
        {
            sum = tmpSymbol + sum;
            tmpSymbol = a[aIndex] == '1' ? '1' : '0';
        }
        else if (tmpSymbol == '1')
        {
            sum = '0' + sum;
        }
        else
        {
            sum = '1' + sum;
        }
    }

    if (a.Length != b.Length)
    {
        string biggerNum = a.Length > b.Length ? a : b;
        for (int i = biggerNum.Length - minLength - 1; i > -1; i--)
        {
            if (tmpSymbol == '1')
            {
                if (biggerNum[i] == '1')
                    sum = '0' + sum;
                else
                {
                    sum = biggerNum.Substring(0, i) + '1' + sum;
                    tmpSymbol = biggerNum[i] == '1' ? '1' : '0';
                    break;
                }
            }
            else
            {
                sum = biggerNum.Substring(0, i + 1) + sum;
                break;
            }
        }
    }
    if (tmpSymbol == '1')
        sum = tmpSymbol + sum;

    return sum;
}

//231.Power of two
public bool IsPowerOfTwo(int n) {
        int Power = 0;
        while (n >= Math.Pow(2, Power))
        {
            if (n == Math.Pow(2, Power)) 
            {
                return true;
            }
            Power += 1;
        }
        return false;
    }

//258.Add digits
public int AddDigits(int num) 
    {
        if (num / 10 == 0)
            return num;
        
        while (num > 9)
        {
            var stringNum = num.ToString();
            num = 0;
            for (int i = 0; i < stringNum.Length; i++)
                num += int.Parse(stringNum[i].ToString());
        }

        return num;
    }

//263.Ugly number
public bool IsUgly(int n) 
    {
        if (n <= 0)
            return false;
        
        while (n % 2 == 0)
            n /= 2;
        while (n % 3 == 0)
            n /= 3;
        while (n % 5 == 0)
            n /= 5;
        
        return n == 1 ? true : false;
    }

//13.Roman to integer
public int RomanToInt(string s) {
        int[] znachOfSymbol = [1, 5, 10, 50, 100, 500, 1000];
        char[] symbol = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];
        int summa = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && Array.IndexOf(symbol, s[i]) < Array.IndexOf(symbol, s[i + 1]))
            {
                summa += znachOfSymbol[Array.IndexOf(symbol, s[i + 1])] - znachOfSymbol[Array.IndexOf(symbol, s[i])];
                i++;
            }
            else
            {
                summa += znachOfSymbol[Array.IndexOf(symbol, s[i])];
            }
        }
        return summa;
    }

//48.Rotate image
public void Rotate(int[][] matrix)
{
    int[] nums = new int[matrix.Length * matrix[0].Length];
    int pos = 0;
    for (int x = 0; x < matrix[0].Length; x++)
    {
        for (int y = matrix.Length - 1; y > -1; y--)
        {
            nums[pos] = matrix[y][x];
            pos++;
        }
    }
    pos--;
    for (int y = matrix.Length - 1; y > -1; y--)
    {
        for (int x = matrix[y].Length - 1; x > -1; x--)
        {
            matrix[y][x] = nums[pos];
            pos--;
        }
    }
}

//283.Move zeroes
public void MoveZeroes(int[] nums)
{
    int pos = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[pos] = nums[i];
            pos++;
        }
    }
    for (int i = pos; i < nums.Length; i++) nums[i] = 0;
}