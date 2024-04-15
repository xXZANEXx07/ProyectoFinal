using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimaciónEscena2 : MonoBehaviour
{
    public GameObject PanelBotones;
    public GameObject Flecha;
    public Image Promocion;
    public GameObject Noticias;
    public GameObject Proximamente;
    

    private bool isPanelVisible = false; // Variable para rastrear el estado del panel

    public void AnimaciónBotones()
    {
        if (!isPanelVisible)
        {
            // Mover hacia abajo si el panel no está visible
            LeanTween.moveY(PanelBotones.GetComponent<RectTransform>(), -555, 1.5f)
                .setEase(LeanTweenType.easeOutBounce);

            // Rotar la flecha 180 grados
            LeanTween.rotateZ(Flecha, 0f, 1.5f)
                .setEase(LeanTweenType.easeOutBounce);
        }
        else
        {
            // Volver a la posición original si el panel está visible
            LeanTween.moveY(PanelBotones.GetComponent<RectTransform>(), -390, 1.5f)
                .setEase(LeanTweenType.easeOutBounce);

            // Rotar la flecha a 0 grados
            LeanTween.rotateZ(Flecha, 180f, 1.5f)
                .setEase(LeanTweenType.easeOutBounce);
        }

        // Cambiar el estado del panel
        isPanelVisible = !isPanelVisible;
    }

    public void Siguiente()
    {
        LeanTween.moveX(Promocion.GetComponent<RectTransform>(),0,1.5f)
            .setEase (LeanTweenType.easeOutBounce);
    }
    public void Anterior()
    {
        LeanTween.moveX(Promocion.GetComponent<RectTransform>(), 1025, 1.5f)
            .setEase(LeanTweenType.easeOutBounce);
    }

    public void PrenderPanel()
    {
        if (!Noticias.activeSelf) // Si el panel está apagado
        {
            // Hacer el panel pequeño antes de prenderlo
            LeanTween.scale(Noticias, Vector3.zero, 0.5f)
                .setEase(LeanTweenType.easeOutBounce)
                .setOnComplete(() =>
                {
                    // Luego de hacerlo pequeño, prenderlo
                    Noticias.SetActive(true);
                    // Luego, hacerlo volver a su tamaño original
                    LeanTween.scale(Noticias, Vector3.one, 0.5f)
                        .setEase(LeanTweenType.easeOutBounce);
                });
        }
        else // Si el panel está encendido
        {
            // Hacerlo pequeño antes de apagarlo
            LeanTween.scale(Noticias, Vector3.zero, 0.5f)
                .setEase(LeanTweenType.easeOutBounce)
                .setOnComplete(() =>
                {
                    // Luego de hacerlo pequeño, apagarlo
                    Noticias.SetActive(false);
                });
        }
    }
    public void proximamente()
    {
        if (!Proximamente.activeSelf) // Si el panel está apagado
        {
            // Hacer el panel pequeño antes de prenderlo
            LeanTween.scale(Proximamente, Vector3.zero, 0.5f)
                .setEase(LeanTweenType.easeOutBounce)
                .setOnComplete(() =>
                {
                    // Luego de hacerlo pequeño, prenderlo
                    Proximamente.SetActive(true);
                    // Luego, hacerlo volver a su tamaño original
                    LeanTween.scale(Proximamente, Vector3.one, 0.5f)
                        .setEase(LeanTweenType.easeOutBounce);
                });
        }
        else // Si el panel está encendido
        {
            // Hacerlo pequeño antes de apagarlo
            LeanTween.scale(Proximamente, Vector3.zero, 0.5f)
                .setEase(LeanTweenType.easeOutBounce)
                .setOnComplete(() =>
                {
                    // Luego de hacerlo pequeño, apagarlo
                    Proximamente.SetActive(false);
                });
        }
    }
   
}
