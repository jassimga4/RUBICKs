using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hideChildren : MonoBehaviour
{
    List<Transform> children = new List<Transform>();
    public List<string> facesToShow = new List<string>();


    //FBUDLR = Green,Blue,White,Yellow,Orange,Red = 012345
    private void Start()
    {

        foreach (Transform child in transform)
        {
            children.Add(child);
        }
        
    }

    private void Update()
    {
        foreach (Transform child in children)
        {
            if (!child.gameObject.activeSelf) break;//if face disabled just skip
            
            if (facesToShow.Contains(child.name)) continue; // if face can be shown then continue
            child.gameObject.SetActive(false);
        }
    }






}
