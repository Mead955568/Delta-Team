using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Phone : MonoBehaviour
{
    
bool sick = false;

public Drink mug;

public GameObject child;
public GameObject health;
public GameObject phone;

    public float timeToTurnOff = 5.0f;
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
            Invoke("TurnOff", timeToTurnOff);

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
    void TurnOff()
    {
        SceneManager.LoadScene("Clinic2_The Reckoning");
    }
}