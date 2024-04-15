using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class CambiarSpriteDesdeGaleria : MonoBehaviour
{
    // M�todo que se ejecutar� cuando se presione el bot�n para cambiar la imagen
    public void AbrirGaleria()
    {
        // Verificar si la galer�a del dispositivo es soportada
        if (!NativeGallery.IsMediaPickerBusy())
        {
            // Abrir la galer�a para seleccionar una imagen
            NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
            {
                // Verificar si se seleccion� una imagen
                if (path != null)
                {
                    // Cargar la imagen seleccionada como un Sprite y asignarla a UsuarioManager
                    StartCoroutine(LoadSpriteFromPath(path));
                }
            }, "Seleccionar una imagen");

            // Verificar el estado de los permisos
            Debug.Log("Permiso de la galer�a: " + permission);
        }
    }

    // M�todo para cargar una imagen desde una ruta como Sprite y asignarla a UsuarioManager
    private IEnumerator LoadSpriteFromPath(string path)
    {
        // Cargar la imagen desde la ruta
        var www = new WWW("file://" + path);
        yield return www;

        // Crear un Sprite con la textura cargada
        Sprite sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), Vector2.zero);

        // Asignar el Sprite a UsuarioManager
        UsuarioManager.instance.PerfilSprite = sprite;
    }
}