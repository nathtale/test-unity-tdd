using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCalculator
{

    public int CalculatePoints(int killedEnemies, int killedVillagers, int mulitplicator)
    {
        return killedEnemies * 100 * mulitplicator;
    }
}
