using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{

    public Sounds coffee;

    public bool mug;


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
        if (coffee.coffee == true)
        {
            if (other.CompareTag("Mug"))
            {
                Debug.Log("Mug Bed");

                mug = true;
            }
        }
    }
}
