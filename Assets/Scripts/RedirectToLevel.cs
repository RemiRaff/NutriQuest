using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int i_sceneNumber = 1;

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(i_sceneNumber);
    }
}
