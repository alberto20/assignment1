using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtDistance : MonoBehaviour
{
    public float distance = 100;
    public bool playerStepped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Camera.main.transform.position, transform.position) > distance)
        {
            Destroy(gameObject);
        }

    }

    public void SetPlayerStepped(bool step)
    {
        playerStepped = step;
    }
}
