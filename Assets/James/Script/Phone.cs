using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    
bool sick = false;

public Drink mug;

public GameObject child;
public GameObject health;
public GameObject phone;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    if (sick == true)
    {
        health.SetActive(false); //changes the canvas text
        phone.SetActive(true);


    }
}
public void OnTriggerEnter(Collider other)
{
        if (mug.mug == true)
            {


            if (other.CompareTag("Player"))
            {
                Debug.Log("Walk in phone");

                sick = true;
            }
        }
}
}