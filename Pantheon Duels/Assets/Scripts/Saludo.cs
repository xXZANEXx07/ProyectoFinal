using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Saludo : MonoBehaviour
{
    public TMP_Text saludo;
    public TMP_Text Nombre;
    public TMP_Text usuario;
    public TMP_Text correo;
    public TMP_Text Nombre2;
    public Image[] FotosPerfil;

    private void Start()
    {
        saludo.text = "Bienvenido " + UsuarioManager.instance.nombreUsuarioActual;
        Nombre.text = UsuarioManager.instance.nombreUsuarioActual;
        usuario.text = UsuarioManager.instance.nombreUsuarioActual;
        Nombre2.text = UsuarioManager.instance.nombreUsuarioActual;
        correo.text = UsuarioManager.instance.CorreoUsuarioActual;

        // Obtener el Sprite del perfil del UsuarioManager
        Sprite perfilSprite = UsuarioManager.instance.PerfilSprite;

        // Asignar el Sprite del perfil a todas las imágenes en el array FotosPerfil
        foreach (Image imagenPerfil in FotosPerfil)
        {
            imagenPerfil.sprite = perfilSprite;
        }
    }
}