using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinforce = 45f;
    private bool isSpinning = false;
    private bool ishover = false;
    private int i ;
    public GameObject _Object;
    public void checkCube(int j)
    {
        i = j;
    }
    // Update is called once per frame
    void Update()
    {
        if (i == 0) { _Object = GameObject.Find("empty"); }
        if (i == 1) { _Object = GameObject.Find("Cube1"); }
        if (i == 2) { _Object = GameObject.Find("Cube2"); }
        if (i == 3) { _Object = GameObject.Find("Cube3"); }

        if (Input.GetButtonDown("Submit") && ishover)
        { isSpinning = true; }
        if (Input.GetButtonUp("Submit"))
        { isSpinning = false; }

        if (isSpinning && ishover)
        {
            _Object.transform.Rotate(0, spinforce * Time.deltaTime, 0);
        }
       else if(!isSpinning && !ishover)
        {
            _Object.transform.Rotate(0, 0, 0);
        }

       /* check whether state
       if (state == "")
        {
            Input.GetAxis('')
            //spin
        }
       */// if in state with mouse hover -> trigger spin

    }
    /**public void mouseEnter()
    {
        state = "enter";
    }
    public void mouseExit()
    {
        state = "exit";
    }
    */
    public void hover()
    {
        ishover = !ishover;
    }
    public void ChangeSpin()
    {

      //  Debug.Log("Change spin was triggered");
        isSpinning = !isSpinning;
    }

}
