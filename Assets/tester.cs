using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tester : MonoBehaviour
{
    public CreateCube cube;
    GameObject blueCenter; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            foreach(var cubepiece in cube.cubePieces)
            {
                blueCenter = GameObject.Find("Center Blue");
                SideRotation side = cubepiece.GetComponent<SideRotation>();
                side.SelectOuterSide(blueCenter);
            }
            
        }
        if (Input.GetMouseButton(1))
        {
            foreach (var cubepiece in cube.cubePieces)
            {
                SideRotation side = cubepiece.GetComponent<SideRotation>();
                side.SelectOuterSide(GameObject.Find("Center Red"));
                
            }
        }
    }
}
