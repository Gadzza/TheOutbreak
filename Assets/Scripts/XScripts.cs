using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XScripts : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SeteazaTransformDef()
    {
        transform.position = new Vector2(x,y);
    }
}
