using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public NumberOfPlants NbrOfPlants;
    public WaterAmount WtrAmount;
    [SerializeField] TMP_Text waterLevelText; 
    [SerializeField] TMP_Text plantRemainingText; 
    [SerializeField] TMP_Text SpeedText; 
    [SerializeField] Slider waterLevelSlide;
    [SerializeField] NavMeshAgent garderner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waterLevelText.text = WtrAmount.WaterLevel.ToString();
        plantRemainingText.text = NbrOfPlants.value.ToString();
        SpeedText.text = garderner.speed.ToString();
        waterLevelSlide.value = WtrAmount.WaterLevel;
    }
}
