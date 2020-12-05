using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class shop : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
        Panel.SetActive(false);
    }

    public void OpenShop()
    {
        Panel.SetActive(true);
    }
}
