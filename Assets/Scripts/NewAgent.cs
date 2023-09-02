using UnityEngine;

public class NewAgent : MonoBehaviour
{
    public GameObject prefabAgent;
    public Transform spawnPosition;

    void Start()
    {
        // Verificamos si se asign� el prefab y la posici�n de aparici�n
        if (prefabAgent != null && spawnPosition != null)
        {
            // Creamos una instancia del prefab en la posici�n deseada
            GameObject newPrefabInstance = Instantiate(prefabAgent, spawnPosition.position, spawnPosition.rotation);

            // Opcionalmente, puedes realizar acciones adicionales en la nueva instancia
            // Por ejemplo, modificar propiedades o agregar componentes
        }
        else
        {
            Debug.LogWarning("Prefab o posici�n de aparici�n no asignados en el script.");
        }
    }
}