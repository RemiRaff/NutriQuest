using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalTimer : MonoBehaviour
{
    [SerializeField]
    TMP_Text tmpt_timer;

    [SerializeField] int i_secondDecount = 150;
    private bool b_isTakingTime = false;

    // Update is called once per frame
    void Update()
    {
        if (b_isTakingTime == false)
        {
            StartCoroutine( DecountSeconds() );
            b_isTakingTime = true;
        }
    }

    // decount seconds
    IEnumerator DecountSeconds()
    {
        b_isTakingTime = true;
        i_secondDecount--;
        tmpt_timer.SetText(i_secondDecount.ToString());
        yield return new WaitForSeconds(1);
        b_isTakingTime = false;
    }
}
