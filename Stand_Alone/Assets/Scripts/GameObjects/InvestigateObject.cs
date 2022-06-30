using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigateObject : MonoBehaviour
{
    public PlayerView PlayerViewScript;
    public string clickedObject;

    public float objectPositionZ;

    // Start is called before the first frame update
    void Start()
    {
        PlayerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();
        objectPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
