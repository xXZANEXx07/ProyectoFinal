using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider nivelVolumen;
    void Start()
    {
        nivelVolumen.value = UsuarioManager.instance.Volumen;
    }

    // Update is called once per frame
    public void CambioVolumen()
    {
        UsuarioManager.instance.Volumen = nivelVolumen.value;
    }
}
