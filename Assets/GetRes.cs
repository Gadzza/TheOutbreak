using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 meow = GetMainGameViewSize();
        Debug.Log(meow);
    }

    public static Vector2 GetMainGameViewSize()
    {
        System.Type T = System.Type.GetType("UnityEditor.GameView,UnityEditor");
        System.Reflection.MethodInfo GetSizeOfMainGameView = T.GetMethod("GetSizeOfMainGameView", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        System.Object Res = GetSizeOfMainGameView.Invoke(null, null);
        return (Vector2)Res;
    }
}
