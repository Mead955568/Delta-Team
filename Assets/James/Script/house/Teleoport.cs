using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Windows.WebCam.VideoCapture;

public class Teleoport : MonoBehaviour
{
    public GameObject phonePanel;
    public Phone phone;
    public AudioSource clicking;

    public bool clinic = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (clinic && !clicking.isPlaying)
        {
            SceneManager.LoadScene("Clinic2_The Reckoning");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (phone.sick == true)
        {
            phonePanel.SetActive(true);
            
            if (!clinic)
            {
                clicking.Play();
                clinic = true;
            }
        }

    }
}