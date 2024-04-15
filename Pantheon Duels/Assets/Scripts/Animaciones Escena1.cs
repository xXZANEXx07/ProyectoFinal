using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesEscena1 : MonoBehaviour
{
    public GameObject Logo;
    public GameObject FondoLogo;
    void Start()
    {
        LeanTween.moveY(Logo.GetComponent<RectTransform>(), 0, 1.5f)
            .setEase(LeanTweenType.easeOutBounce)
            .setDelay(1f);

        LeanTween.alphaCanvas(FondoLogo.GetComponent<CanvasGroup>(), 0, 1f)
            .setDelay(4f);
    }

   
}
