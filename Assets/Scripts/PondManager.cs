using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondManager : MonoBehaviour
{
    public WaterAmount waterAmount;
private void OnTriggerEnter(Collider other) {
    waterAmount.WaterLevel =50;
}
}
