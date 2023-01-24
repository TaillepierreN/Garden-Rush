using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GardenerManager : MonoBehaviour
{
    Camera _cam;
    [SerializeField] NavMeshAgent _gardener;
    public WaterAmount WaterAmount;
    public List<Vector3> targets;


    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        WaterAmount.WaterLevel = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit target;
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out target))
            {
                targets.Add(target.point);

            }
        }
        if (_gardener.remainingDistance <= _gardener.stoppingDistance)
        {
            if (targets.Count > 0)
            {
                _gardener.destination = targets[0];
                targets.RemoveAt(0);
            }
        }

    }

}
