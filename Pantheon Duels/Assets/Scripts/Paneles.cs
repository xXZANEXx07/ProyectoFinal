using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels; // Array de paneles
    private int currentIndex = 0; // Índice del panel actual

    private void Start()
    {
        // Asegurarse de que solo el primer panel sea visible al inicio
        for (int i = 1; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }

    public void ShowNextPanel()
    {
        if (currentIndex < panels.Length - 1)
        {
            // Desactivar el panel actual
            panels[currentIndex].SetActive(false);

            // Activar el siguiente panel
            currentIndex++;
            panels[currentIndex].SetActive(true);
        }
    }

    public void ShowPreviousPanel()
    {
        if (currentIndex > 0)
        {
            // Desactivar el panel actual
            panels[currentIndex].SetActive(false);

            // Activar el panel anterior
            currentIndex--;
            panels[currentIndex].SetActive(true);
        }
    }
}
