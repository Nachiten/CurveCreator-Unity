using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody thisRigidbody;
    public Transform referencia;
    
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float xForce = Input.GetAxis("Horizontal");
        float zForce = Input.GetAxis("Vertical");

        Vector3 xForceVector = referencia.right * xForce;
        Vector3 zForceVector = referencia.forward * zForce;
        
        thisRigidbody.AddForce(xForceVector + zForceVector);
    }
}
