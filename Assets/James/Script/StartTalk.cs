using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTalk : MonoBehaviour
{
    public bool talk = false;
    public AudioSource person;

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
        if (other.CompareTag("Player"))
        {
            Debug.Log("Start Talk");

            person.Play();

            talk = true;
        }
    }
}
