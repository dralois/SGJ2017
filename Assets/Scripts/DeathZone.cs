﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Traktor")
        {
            col.gameObject.GetComponent<VehicleScript>().onDeath();
        }
    }
}