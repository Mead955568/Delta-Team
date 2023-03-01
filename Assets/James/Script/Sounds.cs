using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public bool mug = false;

    public AudioSource coffeenoise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mug"))
        {
            Debug.Log("coffee noise");
            coffeenoise.Play();
            mug = true;
        }
    }
}
