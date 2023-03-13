using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{

    bool sick = false;

    public GameObject introEnd;
    public GameObject intro;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (sick == true)
        {
            intro.SetActive(false); //changes the canvas text
            next.SetActive(true);

            introEnd.SetActive(false); //switchs off the collider

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Walk in Sick");

            sick = true;
        }
    }
}
