using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsuarioManager : MonoBehaviour
{
    public static UsuarioManager instance;

    public string nombreUsuarioActual;
    public string CorreoUsuarioActual;
    public string ContraseñaUsuarioActual;
    public float Volumen = 0.5f;

    public Sprite perfilSprite; // Almacena el sprite del perfil

    public AudioSource Musica;

    public List<string> usuarios = new List<string>();

    // Propiedad para acceder al Sprite del perfil
    public Sprite PerfilSprite
    {
        get { return perfilSprite; }
        set { perfilSprite = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Musica.volume = Volumen;
    }
}