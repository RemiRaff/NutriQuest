using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectMe : MonoBehaviour
{
    [SerializeField]
    GlobalScore gs_score;
    [SerializeField]
    AudioSource as_collectSound;

    // Doit être sur le même object que le collider
    void OnTriggerEnter()
    {
        as_collectSound.Play();
        Destroy(gameObject);
        gs_score.AddPoints(100);
    }
}
