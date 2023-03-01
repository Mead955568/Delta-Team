using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Button StartButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadStart);
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("House");
    }
}