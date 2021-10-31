using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "warp")
        {
            Application.LoadLevel("Loading_2");
        }

        if (collider.gameObject.tag == "warp2")
        {
            Application.LoadLevel("Loading_3");
        }

    }
}
