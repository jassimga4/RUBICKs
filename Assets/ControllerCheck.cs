using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControllerCheck : MonoBehaviour
{
    TextMeshProUGUI textfield;

    private void Start()
    {
        textfield = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if(Input.GetJoystickNames() != null)
        {
            Debug.Log(Input.GetJoystickNames());
            textfield.SetText("Press any button on your controller to continue");
        }
        else
        {
            textfield.SetText("Please connect a PS4 Dualshock Controller");
        }
    }

}
