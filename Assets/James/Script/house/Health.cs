using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    bool medic = false;

    public GameObject girlEnd;
    public GameObject girl;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (medic == true)
        {
            girl.SetActive(false); //changes the canvas text
            next.SetActive(true);

            girlEnd.SetActive(false); //switchs off the collider

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Walk in Sick");

            medic = true;
        }
    }
}
