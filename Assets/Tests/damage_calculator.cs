using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class damage_calculator
{

    [Test]
    public void sets_damage_to_half_with_50_percent_mitigation()
    {
        //Act
        int finalDamage = DamageCalculator.CalculateDamage(10,0.5f);

        //Assert
        Assert.AreEqual(5,finalDamage);
    }

    [Test]
    public void calculates_2_damage_to_from_10_with_80_percent_mitigation()
    {
        //Act
        int finalDamage = DamageCalculator.CalculateDamage(10,0.8f);

        //Assert
        Assert.AreEqual(2,finalDamage);
    }

}
