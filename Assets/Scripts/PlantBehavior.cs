using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBehavior : MonoBehaviour
{
    [SerializeField]float _deathTimer;
    [SerializeField]float _plantMaxHeight =20f;
    public WaterAmount WaterAmount;
    public NumberOfPlants NumberOfPlant;

    float _timeRemainingToDie = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {
        _timeRemainingToDie += Time.deltaTime;
        if(_timeRemainingToDie>=_deathTimer)
        {
            NumberOfPlant.value -=1;
            Destroy(gameObject);
        }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && WaterAmount.WaterLevel >0)
        {
            if(gameObject.transform.localScale.y < _plantMaxHeight)
            {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y * 2, gameObject.transform.localScale.z);
            }
            WaterAmount.WaterLevel -=10;
            _timeRemainingToDie =0;
        }

    }
}
