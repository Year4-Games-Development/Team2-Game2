
using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
     
        if (!other.CompareTag("Hcar01"))
            return; 


        if (transform == Laps.checkpoint1[Laps.currentCheckpoint].transform)
        {
            //Check so we dont exceed our checkpoint quantity
            if (Laps.currentCheckpoint + 1 < Laps.checkpoint1.Length)
            {
                //Add to currentLap if currentCheckpoint is 0
                if (Laps.currentCheckpoint == 0)
                    Laps.currentLap++;
                Laps.currentCheckpoint++;
            }
            else
            {
                //If we dont have any Checkpoints left, go back to 0
                Laps.currentCheckpoint = 0;
            }
        }


    }

}