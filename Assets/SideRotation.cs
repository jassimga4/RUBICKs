using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideRotation : MonoBehaviour
{
    public hideChildren hide;
    public bool isCenter;
    public bool isEdge;
    public bool isCorner;

    public bool centerOrientation;

    public Vector3 Orientation;
    

    void Start()
    {
        switch (hide.facesToShow.Count)
        {
            case 1: 
                isCenter = true; 
                this.name = "Center " + hide.facesToShow[0]; 
                break;
            case 2: 
                isEdge = true;
                this.name = hide.facesToShow[0] + " " + hide.facesToShow[1];
                break;
            case 3: 
                isCorner = true;
                this.name = hide.facesToShow[0] + " " + hide.facesToShow[1] + " " + hide.facesToShow[2];
                break;
            default: break;
        }

    }

    void Update()
    {

    }

    public void SelectOuterSide(GameObject activeCenter)
    {
        if (isEdge)
        {
            float distance = Vector3.Distance(transform.position, activeCenter.transform.position);
            if(distance<=1.1) this.transform.parent = activeCenter.transform;
        }
        if (isCorner)
        {
            float distance = Vector3.Distance(transform.position, activeCenter.transform.position);
            if (distance <= Mathf.Sqrt(2) + 0.1) this.transform.parent = activeCenter.transform;
        }
    }

    public void SelectInnerSide()
    {

    }

    public void DeselectOuterSide()
    {
        //this.transform.parent = 
    }

    public Vector3 GetAxisToRotate()
    {
        if (isCenter)
        {
            Vector3 axis = this.transform.position - this.transform.parent.position;
            Vector3.Normalize(axis);
            return axis;
        }
        return Vector3.zero;
    }
    
    public void Rotate90(bool isClockwise)
    {
        if (isCenter)
        {
            switch (this.name)
            {
                case "Center Green":
                    if (isClockwise) transform.Rotate(90, 0, 0,Space.Self);
                    else transform.Rotate(-90,0,0,Space.Self);
                    break;
                case "Center Blue":
                    if (isClockwise) transform.Rotate(-90, 0, 0, Space.Self);
                    else transform.Rotate(90, 0, 0, Space.Self);
                    break;
                case "Center White":
                    if (isClockwise) transform.Rotate(0, 90, 0, Space.Self);
                    else transform.Rotate(0, -90, 0, Space.Self);
                    break;
                case "Center Yellow":
                    if (isClockwise) transform.Rotate(0, -90, 0, Space.Self);
                    else transform.Rotate(0, 90, 0, Space.Self);
                    break;
                case "Center Orange":
                    if (isClockwise) transform.Rotate(0, 0, 90, Space.Self);
                    else transform.Rotate(0, 0, -90, Space.Self);
                    break;
                case "Center Red":
                    if (isClockwise) transform.Rotate(0, 0, -90, Space.Self);
                    else transform.Rotate(0, 0, 90, Space.Self);
                    break;
            }
        }
    }

}
