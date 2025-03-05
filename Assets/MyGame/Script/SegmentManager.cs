using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentManager : MonoBehaviour
{

    private float currentRotationY = 180f;  
    private float targetRotationY = 0f;     
    public float rotationSpeed = 50f;      
    private bool isRotating = false;       

    void Start()
    {
        GameObject display = GameObject.FindWithTag("segment");
        display.transform.rotation = Quaternion.Euler(0f, currentRotationY, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isRotating)
        {
            isRotating = true;
        }
        if (isRotating)
        {
            GameObject display = GameObject.FindWithTag("segment");

            display.transform.rotation = Quaternion.RotateTowards(
                display.transform.rotation,
                Quaternion.Euler(0f, targetRotationY, 0f),
                rotationSpeed * Time.deltaTime
            );

            if (Mathf.Approximately(display.transform.rotation.eulerAngles.y, targetRotationY))
            {
                isRotating = false;
            }
        }

        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            GameObject target = GameObject.FindWithTag("linksO"); 
            GameObject target1 = GameObject.FindWithTag("mitte");
            GameObject target2 = GameObject.FindWithTag("unten");
            GameObject target3 = GameObject.FindWithTag("oben");
            GameObject target4 = GameObject.FindWithTag("linksU");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target1.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target2.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target3.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target4.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha3)
            || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5) || Input.GetKeyUp(KeyCode.Alpha6)
            || Input.GetKeyUp(KeyCode.Alpha7) || Input.GetKeyUp(KeyCode.Alpha8) || Input.GetKeyUp(KeyCode.Alpha9)
            || Input.GetKeyUp(KeyCode.Alpha0)) 
        {
            ResetSegmentRotation("linksO", 0f, 0f, 0f);
            ResetSegmentRotation("mitte", 90f, 0f, 0f);
            ResetSegmentRotation("unten", 90f, 0f, 0f); 
            ResetSegmentRotation("oben", 90f, 0f, 0f); 
            ResetSegmentRotation("linksU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsU", 0f,0f, 0f);
            ResetSegmentRotation("rechtsO", 0f, 0f, 0f);

        }

        if (Input.GetKey(KeyCode.Alpha2)) 
        {
            GameObject target = GameObject.FindWithTag("linksO"); 
            GameObject target2 = GameObject.FindWithTag("rechtsU");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }


        if (Input.GetKey(KeyCode.Alpha3)) 
        {
            GameObject target = GameObject.FindWithTag("linksO"); 
            GameObject target2 = GameObject.FindWithTag("linksU");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha4)) 
        {
            GameObject target = GameObject.FindWithTag("linksU");
            GameObject target2 = GameObject.FindWithTag("unten");
            GameObject target3 = GameObject.FindWithTag("oben");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target3.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            GameObject target = GameObject.FindWithTag("linksU"); 
            GameObject target2 = GameObject.FindWithTag("rechtsO");


            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha6)) 
        {
            GameObject target = GameObject.FindWithTag("rechtsO");
            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);

        }

        if (Input.GetKey(KeyCode.Alpha7)) 
        {
            GameObject target = GameObject.FindWithTag("linksU");
            GameObject target1 = GameObject.FindWithTag("linksO");
            GameObject target2 = GameObject.FindWithTag("unten");
            GameObject target3 = GameObject.FindWithTag("mitte");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target1.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target3.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
        }

        if (Input.GetKey(KeyCode.Alpha8)) 
        {
            ResetSegmentRotation("linksO", 0f, 0f, 0f);
            ResetSegmentRotation("mitte", 90f, 0f, 0f); 
            ResetSegmentRotation("unten", 90f, 0f, 0f);
            ResetSegmentRotation("oben", 90f, 0f, 0f);
            ResetSegmentRotation("linksU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsO", 0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha9)) 
        {
            GameObject target = GameObject.FindWithTag("linksU");
            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha0)) 
        {
            GameObject target = GameObject.FindWithTag("mitte");
            target.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
        }

        void ResetSegmentRotation(string tag, float x, float y, float z)
        {
            GameObject target = GameObject.FindWithTag(tag);
            if (target != null)
            {
                target.transform.rotation = Quaternion.Euler(x, y, z); 
            }
        }
    }
}