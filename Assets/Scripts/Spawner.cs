using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Plant;
    [SerializeField] GameObject Obstacle;
    [SerializeField] int numberOfPlant;
    Vector3 randCoord;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfPlant; i++)
        {
            RandomSpawnCoordinates();
            var plant = Instantiate(Plant, randCoord, Quaternion.identity);
            NavMeshHit hit;
            if(NavMesh.SamplePosition(plant.transform.position, out hit,1f,NavMesh.AllAreas))
            {
                plant.transform.position = hit.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    Vector3 RandomSpawnCoordinates()
    {
        float randX = Random.Range(-16, 17);
        float randZ = Random.Range(-16, 17);
        return randCoord =new Vector3(randX,0.5f,randZ); 
    }

}
