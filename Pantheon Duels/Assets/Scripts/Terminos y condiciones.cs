using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Terminosycondiciones : MonoBehaviour
{
    [Header("Campos Registro")]
    public TMP_InputField[] camposRegistro;
    public GameObject Terminos;
    public GameObject PanelAlerta2;

    public void Condiciones()
    {
        bool camposValidos = true;
        foreach (TMP_InputField campo in camposRegistro)
        {
            if (string.IsNullOrEmpty(campo.text))
            {
                camposValidos = false;
                break;
            }
        }

        if (!camposValidos)
        {
            PanelAlerta2.SetActive(true);
        }
        else
        {
            Terminos.SetActive(true);
        }
    }
}
