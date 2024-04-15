using UnityEngine;
using UnityEngine.UI;

public class CambiarImagenConSprite : MonoBehaviour
{
    public Image imagen;

    private void Start()
    {
        // Asignar la imagen inicial (puede ser cualquier imagen por defecto)
        // Aquí asumimos que tienes una imagen predeterminada en la carpeta "Sprites" llamada "defaultSprite"
        // Puedes cambiar esto según tus necesidades
        imagen.sprite = Resources.Load<Sprite>("Sprites/defaultSprite");
    }

    private void Update()
    {
        // Obtener el sprite del UsuarioManager
        Sprite spriteUsuario = UsuarioManager.instance.PerfilSprite;

        // Actualizar la imagen con el sprite del UsuarioManager
        imagen.sprite = spriteUsuario;
    }
}
