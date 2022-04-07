using NUnit.Framework;

namespace QuantumGoFish;

public class InitialStateTests
{
    private QGoFish quantumGoFish = null!;
    [SetUp]
    public void SetUp()
    {
        quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
    }
    [Test]
    public void Has_current_player()
    {
        Assert.That(quantumGoFish.CurrentPlayer, Is.EqualTo("Bob"));
    }
    [Test]
    public void Has_no_known_suits()
    {
        CollectionAssert.AreEquivalent(quantumGoFish.Suits, new string[] {});
    }
    [Test]
    public void Has_players()
    {
        CollectionAssert.AreEquivalent(quantumGoFish.Players, new[] {"Bob", "Alice", "Mike"});
    }
}
public class FirstQuestionTests
{
    private QGoFish quantumGoFish = null!;
    [SetUp]
    public void SetUp()
    {
        quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
        quantumGoFish.DoYouHave("Alice", "Banana");
    }
    [Test]
    public void Sets_a_known_suit_for_the_asker()
    {
        CollectionAssert.AreEquivalent(quantumGoFish.Suits, new[] {"Bananas"});
    }
    [Test]
    public void Sets_an_askee_card()
    {
        CollectionAssert.AreEquivalent(new[] {"Banana", "???", "???", "???"}, quantumGoFish.CardsFor("Bob"));
    }
}
public class NextPlayerTests
{
    [Test]
    public void First_player()
    {
        var quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
        Assert.That(quantumGoFish.CurrentPlayer, Is.EqualTo("Bob"));
    }
    [Test]
    public void First_player_again()
    {
        var quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
        quantumGoFish.DoYouHave("Mike", "Rock");
        quantumGoFish.DoYouHave("Mike", "Leaf");
        quantumGoFish.DoYouHave("Bob", "Apple");
        Assert.That(quantumGoFish.CurrentPlayer, Is.EqualTo("Bob"));
    }
    [Test]
    public void Second_player()
    {
        var quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
        quantumGoFish.DoYouHave("Mike", "Rock");
        Assert.That(quantumGoFish.CurrentPlayer, Is.EqualTo("Alice"));
    }
    [Test]
    public void Third_player()
    {
        var quantumGoFish = new QGoFish("Bob", "Alice", "Mike");
        quantumGoFish.DoYouHave("Mike", "Rock");
        quantumGoFish.DoYouHave("Mike", "Leaf");
        Assert.That(quantumGoFish.CurrentPlayer, Is.EqualTo("Mike"));
    }
}
