using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FaceSelector : MonoBehaviour
{
    //fbudlr
    public CreateCube cube;

    

    public Dictionary<string, GameObject> faces = new Dictionary<string, GameObject>();
    private Gamepad controller = null;
    private Transform cubeSpawner;

    void Start()
    {
        StartCoroutine(GetCubeOrientation());
        this.controller = DS4.getController();
        cubeSpawner = this.transform;
    }

    


    private void Update()
    {

        if (controller == null)
        {
            try
            {
                controller = DS4.getController();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            // Press circle button to reset rotation
            if (controller.buttonEast.isPressed)
            {
                cubeSpawner.rotation = Quaternion.Euler(0,-90,0);
            }
            cubeSpawner.rotation *= DS4.getRotation(4000 * Time.deltaTime);
        }



    }
    void SelectFace(string face)
    {
        foreach (var cubepiece in cube.cubePieces)
        {
            SideRotation side = cubepiece.GetComponent<SideRotation>();
            side.SelectOuterSide(faces[face]);
        }
    }
    

    IEnumerator GetCubeOrientation()
    {
        yield return new WaitForSeconds(0.1f);
        faces.Add("F", GameObject.Find("Center Green"));
        faces.Add("B", GameObject.Find("Center Blue"));
        faces.Add("U", GameObject.Find("Center White"));
        faces.Add("D", GameObject.Find("Center Yellow"));
        faces.Add("L", GameObject.Find("Center Orange"));
        faces.Add("R", GameObject.Find("Center Red"));
        Debug.Log("Cube Ready");
    }

    public void OnUi()
    {
        SelectFace("U");
        faces["U"].GetComponent<SideRotation>().Rotate90(false);
    }
    public void OnU()
    {
        SelectFace("U");
        faces["U"].GetComponent<SideRotation>().Rotate90(true);
    }

    public void OnD()
    {
        SelectFace("D");
        faces["D"].GetComponent<SideRotation>().Rotate90(true);
    }
    public void OnDi()
    {
        SelectFace("D");
        faces["D"].GetComponent<SideRotation>().Rotate90(false);
    }
    public void OnL()
    {
        SelectFace("L");
        faces["L"].GetComponent<SideRotation>().Rotate90(true);
    }

    public void OnLi()
    {
        SelectFace("L");
        faces["L"].GetComponent<SideRotation>().Rotate90(false);
    }
    public void OnR()
    {
        SelectFace("R");
        faces["R"].GetComponent<SideRotation>().Rotate90(true);
    }

    public void OnRi()
    {
        SelectFace("R");
        faces["R"].GetComponent<SideRotation>().Rotate90(false);
    }

    public void OnF()
    {
        SelectFace("F");
        faces["F"].GetComponent<SideRotation>().Rotate90(true);
    }

    public void OnFi()
    {
        SelectFace("F");
        faces["F"].GetComponent<SideRotation>().Rotate90(false);
    }

}
