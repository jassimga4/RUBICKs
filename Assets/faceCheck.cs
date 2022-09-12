using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCheck : MonoBehaviour
{
    float m_MaxDistance;
    bool m_HitDetect;
    [SerializeField] private string face;

    Collider m_Collider;
    RaycastHit[] m_Hit;

    void Start()
    {
        m_MaxDistance = 5.0f;
        m_Collider = GetComponent<Collider>();
        
    }

    private void FixedUpdate()
    {
        m_Hit = Physics.BoxCastAll(m_Collider.bounds.center, transform.localScale, transform.forward, transform.rotation, m_MaxDistance);

        foreach (var hit in m_Hit)
        {
            
            
            
        }
    }
    //Draw the BoxCast as a gizmo to show where it currently is testing. Click the Gizmos button to see this
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Check if there has been a hit yet
        if (m_HitDetect)
        {
            //Draw a Ray forward from GameObject toward the hit
            Gizmos.DrawRay(transform.position, transform.forward * 4f);
            //Draw a cube that extends to where the hit exists
            Gizmos.DrawWireCube(transform.position + transform.forward * 4f, transform.localScale);
        }
        //If there hasn't been a hit yet, draw the ray at the maximum distance
        else
        {
            //Draw a Ray forward from GameObject toward the maximum distance
            Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);
            //Draw a cube at the maximum distance
            Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
        }
    }
}
