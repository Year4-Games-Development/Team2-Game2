using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class obst : MonoBehaviour
{
   
    public CarController CarController;

     void OnTriggerEnter(Collider other)
     {
         CarController.m_Topspeed = 30;

          }

    private void OnTriggerExit(Collider other)
    {
        CarController.m_Topspeed = 200;
        CarController.CapSpeed(1f);
    }
}

    