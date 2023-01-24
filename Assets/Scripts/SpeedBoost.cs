using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<GardenerManager>().SpeedBoost();
            Destroy(gameObject);
        }
    }
}
