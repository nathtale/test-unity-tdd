using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PointCalculatorTests
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(3, 0, 1, 300)]
    [TestCase(5, 0, 1, 500)]
    [TestCase(5, 0, 2, 1000)]
    public void CalculatePoints_Test(int killedEnemies, int killedVillagers, int multiplicator, int expectedPoints)
    {
        var pointCalculator = new PointCalculator();

        var points = pointCalculator.CalculatePoints(killedEnemies, killedVillagers, multiplicator);

        Assert.That(points, Is.EqualTo(expectedPoints));
    }

 
}
