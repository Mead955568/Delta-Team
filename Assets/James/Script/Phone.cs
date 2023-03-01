using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{

    public Drink script;

    bool medic = false;

    public GameObject healthEnd;
    public GameObject health;
    public GameObject phone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (medic == true)
        {
            health.SetActive(false); //changes the canvas text
            phone.SetActive(true);

            healthEnd.SetActive(false); //switchs off the collider

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (script.coffee == true)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Walk in medic");

                medic = true;
            }
        }
    }
}
