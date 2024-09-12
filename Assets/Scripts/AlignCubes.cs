using UnityEngine;

public class AlignCubes : MonoBehaviour
{
    private Collider _myCollider;
    // Start is called before the first frame update
    void Start()
    {
        AlignCube();
        
    }

    private void AlignCube()
    {
        _myCollider = GetComponent<Collider>();
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out var hit, 10))
        {
            var myTransform = transform;
            //I put this in as it was sitting a little off the top of the surface, feel free to adjust it as you like
            var offset = 0.75f;
            myTransform.position = hit.point + new Vector3(0, _myCollider.bounds.extents.y*offset, 0);
            myTransform.up = hit.normal;
        }
    }
    
}
