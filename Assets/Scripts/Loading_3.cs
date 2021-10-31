using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading_3 : MonoBehaviour
{
    float delay = 3;

    void Update()
    {

        delay -= Time.deltaTime;
        if (delay <= 0)

            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage 3");

    }
}