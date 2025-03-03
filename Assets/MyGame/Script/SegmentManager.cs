using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SegmentManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksO"); // Suche das GameObject mit dem Tag
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
            ResetSegmentRotation("mitte", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("unten", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("oben", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("linksU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsU", 0f,0f, 0f);
            ResetSegmentRotation("rechtsO", 0f, 0f, 0f);

        }

        if (Input.GetKey(KeyCode.Alpha2)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksO"); // Suche das GameObject mit dem Tag
            GameObject target2 = GameObject.FindWithTag("rechtsU");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }


        if (Input.GetKey(KeyCode.Alpha3)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksO"); // Suche das GameObject mit dem Tag
            GameObject target2 = GameObject.FindWithTag("linksU");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha4)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksU"); // Suche das GameObject mit dem Tag
            GameObject target2 = GameObject.FindWithTag("unten");
            GameObject target3 = GameObject.FindWithTag("oben");

            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
            target3.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
        }

        if (Input.GetKey(KeyCode.Alpha5)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksU"); // Suche das GameObject mit dem Tag
            GameObject target2 = GameObject.FindWithTag("rechtsO");


            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            target2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha6)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("rechtsO");
            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);

        }

        if (Input.GetKey(KeyCode.Alpha7)) // Prüft, ob die "1"-Taste gedrückt wurde
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

        if (Input.GetKey(KeyCode.Alpha8)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            ResetSegmentRotation("linksO", 0f, 0f, 0f);
            ResetSegmentRotation("mitte", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("unten", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("oben", 90f, 0f, 0f); // Ausgangsrotation X = 90
            ResetSegmentRotation("linksU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsU", 0f, 0f, 0f);
            ResetSegmentRotation("rechtsO", 0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha9)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("linksU");
            target.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.Alpha0)) // Prüft, ob die "1"-Taste gedrückt wurde
        {
            GameObject target = GameObject.FindWithTag("mitte");
            target.transform.rotation = Quaternion.Euler(0f, 90f, 90f);
        }

        void ResetSegmentRotation(string tag, float x, float y, float z)
        {
            GameObject target = GameObject.FindWithTag(tag);
            if (target != null)
            {
                target.transform.rotation = Quaternion.Euler(x, y, z); // Setzt auf die richtige Ausgangsrotation zurück
            }
        }
    }


}
