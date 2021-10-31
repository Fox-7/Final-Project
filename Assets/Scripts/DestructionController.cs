using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionController : MonoBehaviour
{
  
    public AudioSource destroySound;

    void OnTriggerEnter(Collider other)
    {
        destroySound.Play();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
