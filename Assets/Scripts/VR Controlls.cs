using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRControlls : MonoBehaviour
{
    public GameManager GM;
    bool fire = false;
    void Update()
    {
        if(fire == true)
        {
            GM.LaunchFreePlayCannonBall();
        }
    }
}
