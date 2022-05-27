using Xunit;

namespace Words.Tests;

public class WordHelperTests
{
    [Theory]
    [InlineData("a")]
    [InlineData("aa")]
    [InlineData("aba")]
    [InlineData("abba")]
    public void IsPalindrome_ShouldReturnTrue_WithPalindrome(string word)
    {
        var result = WordHelpers.IsPalindrome(word);
        Assert.True(result);
    }

    [Theory]
    [InlineData("ab")]
    [InlineData("asdasd")]
    [InlineData("ssaas")]
    [InlineData("qqaaxxxda")]
    public void IsPalindrome_ShouldReturnFalse_WithNotAPalindrome(string word)
    {
        var result = WordHelpers.IsPalindrome(word);
        Assert.False(result);
    }

    [Theory]
    [InlineData("aba", "baa")]
    [InlineData("bar", "bra")]
    public void IsAnagram_ShouldReturnTrue_WithAnagram(string word, string word1)
    {
        var result = WordHelpers.IsAnagram(word, word1);
        Assert.True(result);
    }

    [Theory]
    [InlineData("ab", "aa")]
    [InlineData("avc", "qwe")]
    [InlineData("aa", "aaa")]
    public void IsAnagram_ShouldReturnFalse_WithNotAnagram(string word, string word1)
    {
        var result = WordHelpers.IsAnagram(word, word1);
        Assert.False(result);
    }
}