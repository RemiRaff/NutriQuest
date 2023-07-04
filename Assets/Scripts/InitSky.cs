using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSky : MonoBehaviour
{
    [SerializeField]
    Material m_skybox;

    void Start()
    {
        RenderSettings.skybox = m_skybox;
    }
}
