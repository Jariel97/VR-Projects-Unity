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



    // Update is called once per frame
    void Update()
    {
        if (isclicked && hover)
        {
            transform.Translate(0, 0, thrust);
        }
        else if (!isclicked && !hover)
        {
            transform.Translate(0, 0, 0);
        }
    }
    public void ishover()
    {
        hover = !hover;
    }

    public void ChangeForce()
    {
        isclicked = !isclicked;
    }
}
