using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbing : MonoBehaviour
{
    public Transform shootPoint;
    public int range;
    private RaycastHit hit;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, range))
            {
                Debug.Log("Golpeasta a: " + hit.transform.name);
                if (hit.transform.tag == "Coca")
                {

                    Destroy(this.gameObject);
                }

            }

        }

    }
}
