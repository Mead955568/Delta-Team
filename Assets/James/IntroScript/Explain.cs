using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Explain : MonoBehaviour
{
    public Button explainButton;
    public GameObject mainPanel;
    public GameObject creditPanel;
    public GameObject explainPanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = explainButton.GetComponent<Button>();
        btn.onClick.AddListener(Panelcredit);
    }

    public void Panelcredit()
    {
        mainPanel.SetActive(false);
        explainPanel.SetActive(true);
        creditPanel.SetActive(false);
    }
}
