using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cucacounter : MonoBehaviour
{
    int valor = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.cocas -= valor;
            Destroy(this.gameObject);
        }
    }

}
