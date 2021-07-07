using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinforce = 45f;
    private bool isSpinning = false;
    private bool ishover = false;

    // Update is called once per frame
    void Update()
    {
       if (isSpinning && ishover)
        {
            transform.Rotate(0, spinforce * Time.deltaTime, 0);
        }
       else if(!isSpinning && !ishover)
        {
            transform.Rotate(0, 0, 0);
        }
    }
    public void hover()
    {
        ishover = !ishover;
    }
    public void ChangeSpin()
    {
        isSpinning = !isSpinning;
    }

}
