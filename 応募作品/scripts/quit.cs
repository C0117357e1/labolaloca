using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            doquit();
        }
    }
    // Start is called before the first frame update
    public void doquit()
    {
        Application.Quit();
    }
}
