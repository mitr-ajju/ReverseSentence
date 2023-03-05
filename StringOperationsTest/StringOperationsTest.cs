using StringOperations;

namespace StringOperationsTest;

public class StringOperationsTest
{
    private readonly StringManipulations _stringManipulations;

    public StringOperationsTest()
    {
        _stringManipulations = new StringManipulations();
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void SimpleReverseWhenInputIsReversed()
    {
        string input = "this is a computer";
        string output = "computer a is this";

        string reverseWord = _stringManipulations.SimpleReverseSentence(input);
        Assert.Equal(output, reverseWord);
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void SimpleReverseWhenInputIsNull()
    {
        string input = string.Empty;

        string reverseWord = _stringManipulations.SimpleReverseSentence(input);
        Assert.Empty(reverseWord);
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void SimpleReverseWhenInputHasCapitalLetters()
    {
        string input = "Hello world";
        string output = "world Hello";

        string reverseWord = _stringManipulations.SimpleReverseSentence(input);
        Assert.Equal(output, reverseWord);
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void ReverseSentenceWithSpecialCharacters()
    {
        string input = "Where are you? I am here.";
        string output = ".Here am I ?You are where";

        string reverseWord = _stringManipulations.ReverseSentenceWithSpecialCharacters(input);
        Assert.Equal(output, reverseWord);
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void ReverseSentenceWithSpecialCharactersEmpty()
    {
        string input = "";

        string reverseWord = _stringManipulations.ReverseSentenceWithSpecialCharacters(input);
        Assert.Empty(reverseWord);
    }

    [Fact]
    // This test to validate if input reverses the sentence!
    public void ReverseSentenceWithOtherSpecialCharacters()
    {
        string input = "What is your email id? It's a@b.com.";
        string output = ".A@b.com it's ?Id email your is what";

        string reverseWord = _stringManipulations.ReverseSentenceWithSpecialCharacters(input);
        Assert.Equal(output, reverseWord);
    }
}
