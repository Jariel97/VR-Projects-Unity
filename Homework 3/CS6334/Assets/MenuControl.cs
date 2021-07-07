using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{

    private int i;
    private GameObject _Object;
    public void checkButton(int j)
    {
        i = j;
       
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _Object = GameObject.Find("Canvas");

        if (i == 0) { _Object = GameObject.Find("Canvas"); }
        if (i == 1 && Input.GetButtonDown("Submit"))
        {
            MoveMode();
            _Object.SetActive(false);
        }
        if (i == 2 && Input.GetButtonDown("Submit")) { RotateMode(); _Object.SetActive(false); }
        if (i == 3 && Input.GetButtonDown("Submit")) { ColorMode(); _Object.SetActive(false); }
        if (i == 4 && Input.GetButtonDown("Submit")) { clearAll(); _Object.SetActive(false); }
        if (i == 5 && Input.GetButtonDown("Submit")) {  _Object.SetActive(false); }

    }
    public void clearAll()
    {
        MonoBehaviour[] scriptComponents = GameObject.Find("Cube1").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents)
        {

            if (string.Compare(script.ToString(), "Cube1 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;

            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents2 = GameObject.Find("Cube2").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents2)
        {

            if (string.Compare(script.ToString(), "Cube2 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;

            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents3 = GameObject.Find("Cube3").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents3)
        {

            if (string.Compare(script.ToString(), "Cube3 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;

            else
                script.enabled = false;


        }


    }

    public void MoveMode()
    {
        MonoBehaviour[] scriptComponents = GameObject.Find("Cube1").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents)
        {

            if (string.Compare(script.ToString(), "Cube1 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube1 (MoveCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents2 = GameObject.Find("Cube2").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents2)
        {

            if (string.Compare(script.ToString(), "Cube2 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube2 (MoveCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents3 = GameObject.Find("Cube3").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents3)
        {

            if (string.Compare(script.ToString(), "Cube3 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube3 (MoveCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
    }

    public void ColorMode()
    {
        MonoBehaviour[] scriptComponents = GameObject.Find("Cube1").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents)
        {

            if (string.Compare(script.ToString(), "Cube1 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube1 (ColorCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents2 = GameObject.Find("Cube2").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents2)
        {

            if (string.Compare(script.ToString(), "Cube2 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube2 (ColorCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents3 = GameObject.Find("Cube3").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents3)
        {

            if (string.Compare(script.ToString(), "Cube3 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube3 (ColorCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }


    }

    public void RotateMode()
    {
        MonoBehaviour[] scriptComponents = GameObject.Find("Cube1").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents)
        {

            if (string.Compare(script.ToString(), "Cube1 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube1 (RotateCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents2 = GameObject.Find("Cube2").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents2)
        {

            if (string.Compare(script.ToString(), "Cube2 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube2 (RotateCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }
        MonoBehaviour[] scriptComponents3 = GameObject.Find("Cube3").GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents3)
        {

            if (string.Compare(script.ToString(), "Cube3 (UnityEngine.EventSystems.EventTrigger)") == 0)
                script.enabled = true;
            else if (string.Compare(script.ToString(), "Cube3 (RotateCube)") == 0)
                script.enabled = true;
            else
                script.enabled = false;


        }


    }
}



















