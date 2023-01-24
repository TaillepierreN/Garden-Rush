using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Plant;
    [SerializeField] int numberOfPlant;
        public NumberOfPlants NumberOfPlants;
    Vector3 randCoord;

    // Start is called before the first frame update
    private void Awake() {
        NumberOfPlants.value = 0;
    }
    void Start()
    {

        for (int i = 0; i < numberOfPlant; i++)
        {
            RandomSpawnCoordinates();
            var plant = Instantiate(Plant, randCoord, Quaternion.identity);
            NumberOfPlants.value +=1;

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
        randCoord = new Vector3(randX, 0.5f, randZ);
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randCoord, out hit, 4f, 1 <<NavMesh.GetAreaFromName("Walkable")))
        {
            randCoord = hit.position;
        }
        return randCoord;
    }

}
