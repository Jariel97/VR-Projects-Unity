using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour
{

    public Color startColor;
    public Color clickColor;
    private bool clicked = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            GetComponent<Renderer>().material.SetColor("_Color", clickColor);
        }
        else if (!clicked)
        {
            GetComponent<Renderer>().material.SetColor("_Color", startColor);
        }
    }

    public void ChangeColor()
    {
        clicked = !clicked;
    }

}
