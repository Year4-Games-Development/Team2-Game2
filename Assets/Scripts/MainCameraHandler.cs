using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCameraHandler : MonoBehaviour {

    public GameObject[] CamWayPoints;
    public GameObject[] cars;
    private int idx;
    public Text text;

    // Use this for initialization
    void Start () {
        idx = 0;
        GoToNextPoint();
	}

    private void GoToNextPoint()
    {
        if (idx >= CamWayPoints.Length)
        {
            idx = 0; // Wrap around
        }
        transform.position = CamWayPoints[idx].transform.position;
        transform.rotation = CamWayPoints[idx].transform.rotation;
        idx++;
    }
	
	// Update is called once per frame
	void Update () {
        float dist = float.PositiveInfinity;
        Vector2 curLoc = new Vector2(transform.position.x, transform.position.z);
        foreach (var car in cars)
        {
            //Renderer r = car.GetComponent<Renderer>();
            Vector3 vpLoc = Camera.main.WorldToViewportPoint(car.transform.position);
            if (!(vpLoc.z > 0 && vpLoc.x >= 0 && vpLoc.x <= 1 && vpLoc.y >= 0 && vpLoc.y <= 1))
            {
                //Debug.Log("car is out of bounds!");
                text.text = "You lose!!!";
                Time.timeScale = 0;
            }
            Vector2 carLoc = new Vector2(car.transform.position.x, car.transform.position.z);
            float tmpDist = Vector2.Distance(curLoc, carLoc);
            if  (tmpDist < dist)
            {
                dist = tmpDist;
            }
        }
        if (dist < 20)
        {
            GoToNextPoint();
        }
            
	}
}
