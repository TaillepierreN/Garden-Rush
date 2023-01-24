using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBehavior : MonoBehaviour
{
    [SerializeField]float _deathTimer;
    float _timeRemainingToDie = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timeRemainingToDie += Time.deltaTime;
        if(_timeRemainingToDie>=_deathTimer)
        {
            Destroy(gameObject);
        }
        Debug.Log(_timeRemainingToDie);
    }
    private void OnCollisionEnter(Collision other)
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y * 2, gameObject.transform.localScale.z);
            _timeRemainingToDie =0;
        }

    }
}
