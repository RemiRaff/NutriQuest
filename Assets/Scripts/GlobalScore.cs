using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalScore : MonoBehaviour
{
    [SerializeField]
    TMP_Text tmpt_scoreDisplayed;

    private int i_currentScore;

    void Start()
    {
        i_currentScore = 0;
        tmpt_scoreDisplayed.SetText(i_currentScore.ToString());
    }

    public void AddPoints(int i_pts)
    {
        i_currentScore += i_pts;
        tmpt_scoreDisplayed.SetText(i_currentScore.ToString());
    }
}
