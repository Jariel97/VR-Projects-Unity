using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour
{

    public Color startColor;
    public Color clickColor;
    private bool clicked = false;
    // Start is called before the first frame update
    public GameObject _Object;
    private int i;
    // Update is called once per frame
    public void checkCube(int j)
    {
        i = j;
    }
    void Update()
    {

        if (i == 0) { _Object = GameObject.Find("empty"); }
        if (i == 1) { _Object = GameObject.Find("Cube1"); }
        if (i == 2) { _Object = GameObject.Find("Cube2"); }
        if (i == 3) { _Object = GameObject.Find("Cube3"); }

        if (Input.GetButtonDown("Submit") && i==1)
        { ChangeColor(); _Object.GetComponent<Renderer>().material.SetColor("_Color", clickColor);
        }
        if (Input.GetButtonDown("Submit") && i == 2)
        {
            ChangeColor(); _Object.GetComponent<Renderer>().material.SetColor("_Color", clickColor);
        }

        if (Input.GetButtonDown("Submit") && i == 3)
        {
            ChangeColor(); _Object.GetComponent<Renderer>().material.SetColor("_Color", clickColor);
        }

        
        else if (!clicked)
        {
            _Object.GetComponent<Renderer>().material.SetColor("_Color", startColor);
        }
    }

    public void ChangeColor()
    {
        clicked = !clicked;
    }

}
