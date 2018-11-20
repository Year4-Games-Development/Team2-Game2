using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTracker : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    public GameObject Checkpoint5;
    public GameObject Checkpoint6;
    public int MarkTracker;
    public int checkpointScore;
    public Text checkpointText;
    public Text lapText;
    public int laps = 0;

    private void Start()
    {
        setCheckpointText();
    }


    void Update () {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = Checkpoint1.transform.position;
        }

        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Checkpoint2.transform.position;
        }

        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Checkpoint3.transform.position;
        }

        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Checkpoint4.transform.position;
        }

        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Checkpoint5.transform.position;
        }

        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Checkpoint6.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Checkpoint1.transform.position;
        }


    }//end update 

    private IEnumerator OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Hcar01") {
            this.GetComponent<BoxCollider>().enabled = false;
           
            MarkTracker += 1;
            setCheckpointText();

            if (MarkTracker == 6) {
                laps+=1;
                lapText.text = "Laps : " + laps.ToString();
                MarkTracker = 0;
            }//end if

            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;

        }//end if
        
    }

    void setCheckpointText()
    {
        checkpointText.text = "Checkpoints : " + MarkTracker.ToString();
       
    }
   
}
