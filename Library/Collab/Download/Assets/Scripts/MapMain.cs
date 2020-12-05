using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMain : MonoBehaviour
{

    float scale = 0.01f;

    public GameObject Harta;
    public GameObject buton1;
    public GameObject buton2;
    public GameObject buton3;
    public GameObject buton4;
    public GameObject buton5;
    public GameObject buton6;
    public GameObject buton7;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Zoom()
    {
        scale += 10f;
        Harta.transform.localScale = new Vector2(scale, scale);
        GameObject other = GameObject.FindWithTag("X");
        other.gameObject.SetActive(false);
    }

    public void ButonActiv1()
    {
        buton1.SetActive(true);
        buton1.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton1.transform.position.x, buton1.transform.position.y);
    }
    public void ButonActiv2()
    {
        buton2.SetActive(true);
        buton2.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton2.transform.position.x, buton2.transform.position.y);
    }
    public void ButonActiv3()
    {
        buton3.SetActive(true);
        buton3.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton3.transform.position.x, buton3.transform.position.y);
    }
    public void ButonActiv4()
    {
        buton4.SetActive(true);
        buton4.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton4.transform.position.x, buton4.transform.position.y);
    }
    public void ButonActiv5()
    {
        buton5.SetActive(true);
        buton5.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton5.transform.position.x, buton5.transform.position.y);
    }
    public void ButonActiv6()
    {
        buton6.SetActive(true);
        buton6.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton6.transform.position.x, buton6.transform.position.y);
    }
    public void ButonActiv7()
    {
        buton7.SetActive(true);
        buton7.transform.position = new Vector2(-185, 0);
        transform.position = new Vector2(buton7.transform.position.x, buton7.transform.position.y);
    }

    void ZoomButon1()
    {
        
    }
    void ZoomButon2()
    {

    }
    void ZoomButon3()
    {

    }
    void ZoomButon4()
    {

    }
    void ZoomButon5()
    {

    }
    void ZoomButon6()
    {

    }
    void ZoomButon7()
    {

    }
}
