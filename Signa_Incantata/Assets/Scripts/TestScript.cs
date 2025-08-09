using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Signa Incantata - Entorno configurado correctamente!");
    }
    
    void Update()
    {
        // Test básico - presionar espacio para mensaje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Sistema de input funcionando - Issue #2 completado");
        }
    }
}