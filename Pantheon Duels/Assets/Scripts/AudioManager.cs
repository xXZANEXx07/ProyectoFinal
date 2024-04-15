using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource para reproducir el sonido
    public Button[] botones; // Array de botones

    private void Start()
    {
        // Asignar el mismo m�todo para cada bot�n en el array
        foreach (Button boton in botones)
        {
            boton.onClick.AddListener(ReproducirSonido);
        }
    }

    // M�todo para reproducir el sonido
    private void ReproducirSonido()
    {
        // Reproducir el sonido utilizando el AudioSource
        audioSource.Play();
    }
}
