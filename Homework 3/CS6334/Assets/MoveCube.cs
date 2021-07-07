using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public float thrust = 0.05f;
    private bool isclicked = false;
    private bool hover = false;
    public GameObject _Object;
    private int i;
    // Update is called once per frame

    void Update()
    {
        Move();
    }
    public void ishover()
    {
        hover = !hover;
    }

    public void ChangeForce()
    {
        isclicked = !isclicked;
    }

    public void checkCube(int j )
    {
        i = j;
    }
    public void Move()
    {

        if (i == 0) { _Object = GameObject.Find("empty"); }
        if (i == 1) { _Object = GameObject.Find("Cube1"); }
        if (i == 2) { _Object = GameObject.Find("Cube2"); }
        if (i == 3) { _Object = GameObject.Find("Cube3"); }

        if(Input.GetButtonDown("Submit") && hover)
        { isclicked = true; }
        if(Input.GetButtonUp("Submit") )
        { isclicked = false; }

        if ( hover && isclicked)
        {
            _Object.transform.Translate(0, 0, thrust);
        }
        else if (!hover && !isclicked)
        {
            _Object.transform.Translate(0, 0, 0);
        }
    }
}
