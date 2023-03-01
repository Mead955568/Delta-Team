using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffAfterTime : MonoBehaviour
{
    public float timeToTurnOff = 5.0f; // Set this to the amount of time you want the object to stay on before turning off

    void Start()
    {
        Invoke("TurnOff", timeToTurnOff);
    }

    void TurnOff()
    {
        gameObject.SetActive(false);
    }
}
