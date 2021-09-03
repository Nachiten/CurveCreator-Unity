using PathCreation;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    private float distanceTravelled;

    private void Update()
    {
        // Aumento la distancia recorrida
        distanceTravelled += speed * Time.deltaTime;

        // Actualizo la posicion al punto correspondiente
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);

        // Actualizo la rotacion a la correspondiente
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
