using UnityEngine;
// ReSharper disable Unity.InefficientPropertyAccess

public class CameraPlayerFollower : MonoBehaviour
{
    public GameObject player;
    public GameObject reference;
    public Vector3 offset;
    
    private const float sensibilidad = 2;
    
    private Vector3 distancia;
    
    void Start()
    {
        //Asignar Distancia
        distancia = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Calcula la distancia del jugador
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * distancia;
        
        Vector3 playerPosition = player.transform.position;
        
        // La camara cambia su posicion respecto a la posicion del jugador
        transform.position = playerPosition + distancia + offset;
        
        // La camara mira hacia el jugador
        transform.LookAt(playerPosition);

        // Referencia para que los controles no cambien
        Vector3 copiarRotacion = new Vector3(0, transform.eulerAngles.y, 0);

        // Rotar la referencia
        reference.transform.eulerAngles = copiarRotacion;
    }
}
