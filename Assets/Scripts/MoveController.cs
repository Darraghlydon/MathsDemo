using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveController : MonoBehaviour
{

    Transform objectTransform;

    public Transform targetTransform;
    public bool normaliseFlag;
    // Angular speed in radians per sec.
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        objectTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Determine which direction to rotate towards
        Vector3 targetDirection = targetTransform.position - objectTransform.position;
        if(targetDirection.sqrMagnitude <0.001f)
        {
            return;
        }
        if(normaliseFlag)
        {
            targetDirection = targetDirection.normalized;
        }
       

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;
        
        objectTransform.Translate(targetDirection * singleStep);

        // objectTransform.Translate(Vector2.up);
    }
}
