using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFruit : MonoBehaviour

{
    public float rotationSpeed = 100f;

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        CollectibleController.theScore += 1;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //distance to rotate on each frame
        float angle = rotationSpeed * Time.deltaTime;

        //rotate on Y
        transform.Rotate(Vector3.up * angle, Space.World);

    }

}


