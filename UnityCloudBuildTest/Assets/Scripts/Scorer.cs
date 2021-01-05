using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scorer
{
    public int ComputeBasicScore(int normalScore, int bonusScore)
	{
		int score = normalScore + bonusScore;
		return score;
	}
}
