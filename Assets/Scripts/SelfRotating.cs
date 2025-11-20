using UnityEngine;

public class SelfRotating : MonoBehaviour
{
    [SerializeField] private float _rotateY = 1;
   
    private void FixedUpdate()
    {        
        Quaternion rotationY = Quaternion.AngleAxis(_rotateY, Vector3.up); 
        transform.rotation *= rotationY;
    }
}
