using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Houd een positie bij om naar toe te bewegen
public class Waypoint : MonoBehaviour
{
    public Vector3 GetPosition()
    {
        return transform.position;
    }    
}
