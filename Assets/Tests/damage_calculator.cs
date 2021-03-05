using NUnit.Framework;

public class damage_calculator
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(10, 0.5f, 5)]
    [TestCase(10, 0.8f, 2)]
    public void sets_damage_to_half_with_50_percent_mitigation(int amount, float mitigationPercent, int expectedResult)
    {
        // ACT
        int finalDamage = DamageCalculator.CalculateDamage(amount, mitigationPercent);

        // ASERT
        Assert.AreEqual(expectedResult, finalDamage);
    }

}
