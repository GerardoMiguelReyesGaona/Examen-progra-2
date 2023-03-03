using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coca : MonoBehaviour
{
    public float radius;
    
    public bool hitCheck1;
    public bool hitCheck2;

    public LayerMask whatIsPlayer;

    RaycastHit hit;

    private void OnMouseOver()
    {
        hitCheck1 = true;
    }

    private void OnMouseExit()
    {
        hitCheck1 = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hitCheck1 && hitCheck2)
        {
            
            Destroy(this.gameObject);
        }


        //Physics.SphereCast(transform.position, radio, Vector3.right,out hit);
        hitCheck2 = Physics.CheckSphere(transform.position, radius, whatIsPlayer);


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
