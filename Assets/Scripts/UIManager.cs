using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public NumberOfPlants NbrOfPlants;
    public WaterAmount WtrAmount;
    [SerializeField] TMP_Text waterLevelText; 
    [SerializeField] TMP_Text plantRemainingText; 
    [SerializeField] Slider waterLevelSlide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waterLevelText.text = WtrAmount.WaterLevel.ToString();
        plantRemainingText.text = NbrOfPlants.value.ToString();
        waterLevelSlide.value = WtrAmount.WaterLevel;
    }
}
