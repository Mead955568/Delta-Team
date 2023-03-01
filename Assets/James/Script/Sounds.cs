using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource coffeemaker;

    public bool coffee = false;
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
            Debug.Log("Coffee mug");

            coffeemaker.Play();

            coffee = true;
        }
    }
}
