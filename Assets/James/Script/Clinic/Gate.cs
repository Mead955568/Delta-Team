using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public StartTalk talking;
    public GameObject gate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (talking.talk == true)
        {
            gate.SetActive(false);
        }
    }

}
