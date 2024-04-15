using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionUsuarios : MonoBehaviour
{
    [Header("Campos Registro")]
    public TMP_InputField[] camposRegistro;

    [Header("Campos Inicio")]
    public TMP_InputField[] camposInicio;

    [Header("Alertas")]
    public string[] textoAlertas;
    public GameObject PanelAlerta;
    public TMP_Text AlertaActual;

    [Header("Pantalla de Carga")]
    public GameObject PanelCargando;

    public float retrasoAntesCambio = 3.0f; 

    public void RegistrarUsuario()
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
            PanelAlerta.SetActive(true);
            AlertaActual.text = textoAlertas[0];
        }
        else
        {
            string nombreUsuario = camposRegistro[0].text;
            if (UsuarioManager.instance.usuarios.Contains(nombreUsuario))
            {
                PanelAlerta.SetActive(true);
                AlertaActual.text = textoAlertas[1];
            }
            else
            {
                UsuarioManager.instance.usuarios.Add(nombreUsuario);
                UsuarioManager.instance.nombreUsuarioActual = nombreUsuario;
                UsuarioManager.instance.CorreoUsuarioActual = camposRegistro[1].text;
                UsuarioManager.instance.ContraseñaUsuarioActual = camposRegistro[2].text;
                PanelAlerta.SetActive(true);
                AlertaActual.text = textoAlertas[3];
            }
        }
    }

    public void IniciarSesion()
    {
        bool camposValidos = true;

        foreach (TMP_InputField campo in camposInicio)
        {
            if (string.IsNullOrEmpty(campo.text))
            {
                camposValidos = false;
                break;
            }
        }

        if (!camposValidos)
        {
            PanelAlerta.SetActive(true);
            AlertaActual.text = textoAlertas[0];
        }
        else
        {
            string nombreUsuario = camposInicio[0].text;
            if (UsuarioManager.instance.usuarios.Contains(nombreUsuario))
            {
                UsuarioManager.instance.nombreUsuarioActual = nombreUsuario;
                UsuarioManager.instance.CorreoUsuarioActual = camposInicio[1].text;
                UsuarioManager.instance.ContraseñaUsuarioActual = camposInicio[2].text;
                PanelCargando.SetActive(true);
                StartCoroutine(EsperarYCambiarEscena());
            }
            else
            {
                PanelAlerta.SetActive(true);
                AlertaActual.text = textoAlertas[2];
            }
        }
    }

    IEnumerator EsperarYCambiarEscena()
    {
        yield return new WaitForSeconds(retrasoAntesCambio);
        CambioEscena cambio = FindObjectOfType<CambioEscena>();
        cambio.CambiarEscena("Juego");
    }
}
