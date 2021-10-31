using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleController : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore;

    // Update is called once per frame
    void Update()
    {

        scoreText.GetComponent<Text>().text = "" + theScore;
    }

}
