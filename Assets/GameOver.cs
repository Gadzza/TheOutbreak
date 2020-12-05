using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public void GoToMap()
    {
        SceneManager.LoadScene("Map");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
