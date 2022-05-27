namespace Words;

public static class WordHelpers
{
    public static bool IsAnagram(string word, string word1)
    {
        if (word.Length != word1.Length) return false;

        var dictionary = new Dictionary<char, int>();

        foreach (var t in word)
            if (dictionary.ContainsKey(t)) dictionary[t] += 1;
            else dictionary.Add(t, 1);

        foreach (var t in word1)
            if (dictionary.ContainsKey(t))
                dictionary[t] -= 1;

        foreach (var key in dictionary.Keys)
            if (dictionary[key] != 0)
                return false;

        return true;
    }

    public static bool IsPalindrome(string word)
    {
        var leftIndex = 0;
        var rightIndex = word.Length - 1;
        while (leftIndex < rightIndex)
        {
            if (word[rightIndex] != word[leftIndex]) return false;
            leftIndex++;
            rightIndex--;
        }

        return true;
    }
}