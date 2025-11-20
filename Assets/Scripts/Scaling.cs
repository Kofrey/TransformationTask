using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed = 0.1f;
    [SerializeField] private float _scaleX = 1.0f;
    [SerializeField] private float _scaleY = 1.0f;
    [SerializeField] private float _scaleZ = 1.0f;

    private void FixedUpdate()
    {
        transform.localScale += new Vector3(_scaleX, _scaleY, _scaleZ) * (_scalingSpeed * Time.fixedDeltaTime); 
    }
}
