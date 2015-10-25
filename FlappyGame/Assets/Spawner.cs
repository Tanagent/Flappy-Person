using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float repeatRate = 3f;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("CreateObstacle", 1f, repeatRate);
	}
	
    void CreateObstacle()
    {
        Instantiate(obstacle);
    }

	// Update is called once per frame
	void Update ()
    {
	    
	}


}
