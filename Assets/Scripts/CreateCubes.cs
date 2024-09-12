using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubes : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Vector3 newCubePosition = Random.onUnitSphere;
            print(newCubePosition);
            Instantiate(cubePrefab, newCubePosition, Quaternion.FromToRotation(Vector3.up, newCubePosition));
        }
    }
    
    
}
