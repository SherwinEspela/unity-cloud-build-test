using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class ScorerTests
{
    [Test]
    public void ComputeBasicScoreSuccess_Test()
    {
        // 1. ARRANGE
        var scorer = new Scorer();
        int normalScore = 100;
        int bonusScore = 200;
        int expectedScore = normalScore + bonusScore;

        // 2. ACT
        int score = scorer.ComputeBasicScore(normalScore, bonusScore);

        // 3. ASSERT
        Assert.That(score, Is.EqualTo(expectedScore));
    }

    [Test]
    public void ComputeBasicScoreFail_Test()
    {
        // 1. ARRANGE
        var scorer = new Scorer();
        int normalScore = 100;
        int bonusScore = 200;
        int expectedScore = 80 + 90;

        // 2. ACT
        int score = scorer.ComputeBasicScore(normalScore, bonusScore);

        // 3. ASSERT
        Assert.That(score, Is.EqualTo(expectedScore));
    }
}
