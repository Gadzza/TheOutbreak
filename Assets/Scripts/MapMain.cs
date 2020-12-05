using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MapMain : MonoBehaviour
{


    public TextMeshProUGUI TextTitlu;
    public GameObject Panel;

    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Start is called before the first frame update
    public void DeschideMeniu()
    {
        int sansa = Random.Range(0, 100);
        if (sansa<50)
        {
            TextTitlu.text = "Thermometer";
        }else
        {
            TextTitlu.text = "Thermometer";
        }

        Panel.SetActive(true);
    }

    public void Travel()
    {
        SceneManager.LoadScene(TextTitlu.text);
    }

    public void Back()
    {
        Panel.SetActive(false);
    }
}
