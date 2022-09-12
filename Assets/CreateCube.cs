using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    private int cubeSize = 3;
    public GameObject cubePrefab;

    public List<GameObject> cubePieces = new List<GameObject>();
    public hideChildren hide;
    private void Awake()
    {
        Create3x3();
        //Create1x1();
    }

    public void Create1x1()
    {
        Instantiate(cubePrefab);
    }
    public void Create3x3()
    {
        cubeSize -= 1;

        for (int i = -1; i < cubeSize; i++)
        {
            for(int j = -1; j < cubeSize; j++)
            {
                for( int k = -1; k < cubeSize; k++)
                {
                    if (i == 0 && j == 0 && k == 0) continue;
                    
                    
                    var newCube = Instantiate(cubePrefab, new Vector3(i, j, k), Quaternion.identity);
                    //add all cube items to a list
                    cubePieces.Add (newCube);
                    hide = newCube.gameObject.GetComponentInChildren<hideChildren>();
                    // show only faces on the outside
                    if (i == -1) hide.facesToShow.Add("Blue");
                    if (i == 1) hide.facesToShow.Add("Green");
                    if (j == -1) hide.facesToShow.Add("Yellow");
                    if (j == 1)hide.facesToShow.Add("White");
                    if (k == -1)hide.facesToShow.Add("Orange");
                    if (k == 1)hide.facesToShow.Add("Red");
                    //set parent of cube to cubespawner
                    newCube.transform.parent = gameObject.transform;
                }
            }
        }
    }

}
