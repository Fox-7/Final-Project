using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    float delay = 3;
     
    // Load next stage after 3 second delay
    void Update()
    {

        delay -= Time.deltaTime;
        if (delay <= 0)
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage 1");

    }
}