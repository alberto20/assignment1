using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{ 

    public GameObject basePlatform;
    public GameObject obstacle;
    public GameObject obstacle2;
    public GameObject gold;
    public GameObject RightHolePlatform;
    public GameObject LeftHolePlatform;
    public GameObject MiddleHolePlatform;
    Vector3 currentPosition = Vector3.zero;
    public float distanceToInstantiate = 100;
    public int numrand = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(basePlatform, currentPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        numrand = Random.Range(0, 25);
        if (Vector3.Distance(Camera.main.transform.position, currentPosition) < distanceToInstantiate)
        {
            if(numrand <12)
            {
                Instantiate(basePlatform, currentPosition, transform.rotation);

                gold.transform.position = new Vector3(Random.Range(-1, 2), 1, Random.Range(-20, 20));
                Instantiate(gold, currentPosition + gold.transform.position, transform.rotation);

            }

            else if (numrand >= 12 && numrand <18)
            {
                Instantiate(MiddleHolePlatform, currentPosition, transform.rotation);

            }
            else if (numrand >= 18 && numrand < 22)
            {
                Instantiate(LeftHolePlatform, currentPosition, transform.rotation);
                obstacle.transform.position = new Vector3(Random.Range(-1, 2), 1, Random.Range(-20, 20));
                Instantiate(obstacle, currentPosition + obstacle.transform.position, transform.rotation);

            }
            else if (numrand >= 22 && numrand < 25)
            {
                Instantiate(RightHolePlatform, currentPosition, transform.rotation);

                obstacle2.transform.position = new Vector3(Random.Range(-1, 2), 1, Random.Range(-20, 20));
                Instantiate(obstacle2, currentPosition + obstacle2.transform.position, transform.rotation);
            }

            currentPosition += new Vector3(0, 0, 10f);

        }

    }
}
