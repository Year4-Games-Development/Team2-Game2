using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTracker : MonoBehaviour
{
    public GameObject[] CheckPoints;

    public Text CheckpointText;
    public Text lapText;

    private int CheckpointIndex = 0;
    private int laps = 0;

    private void Start()
    {
        UpdateCheckpointText();
        transform.position = CheckPoints[CheckpointIndex].transform.position;
    }


    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider collider)
    {
        //FIXME
        /*if (!collider.gameObject.CompareTag("Player"))
        {
            Debug.Log(collider.gameObject.tag);
            yield break;
        }*/

        CheckpointIndex++;

        if (CheckpointIndex >= CheckPoints.Length)
        {
            laps++;
            lapText.text = "Laps : " + laps.ToString();
            CheckpointIndex = 0;
        }

        transform.position = CheckPoints[CheckpointIndex].transform.position;

        UpdateCheckpointText();

        yield return new WaitForSeconds(1);
    }

    private void UpdateCheckpointText()
    {
        CheckpointText.text = "Checkpoints : " + CheckpointIndex + "/" + CheckPoints.Length;
    }
}
