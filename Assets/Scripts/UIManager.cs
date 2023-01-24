using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public NumberOfPlants NbrOfPlants;
    public WaterAmount WtrAmount;
    public Score score;
    [SerializeField] TMP_Text waterLevelText; 
    [SerializeField] TMP_Text plantRemainingText; 
    [SerializeField] TMP_Text SpeedText; 
    [SerializeField] TMP_Text ScoreText; 
    [SerializeField] TMP_Text EndScoreText; 
    [SerializeField] Slider waterLevelSlide;
    [SerializeField] NavMeshAgent garderner;
    [SerializeField] Canvas normalUI;
    [SerializeField] Canvas endUI;
    // Start is called before the first frame update
    void Awake()
    {
        score.score =0;
    }

    // Update is called once per frame
    void Update()
    {
        waterLevelText.text = WtrAmount.WaterLevel.ToString();
        plantRemainingText.text = NbrOfPlants.value.ToString();
        SpeedText.text = garderner.speed.ToString();
        ScoreText.text = score.score.ToString();
        EndScoreText.text = score.score.ToString();
        waterLevelSlide.value = WtrAmount.WaterLevel;
        if(NbrOfPlants.value == 0)
        {
            normalUI.gameObject.SetActive(false);
            endUI.gameObject.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
