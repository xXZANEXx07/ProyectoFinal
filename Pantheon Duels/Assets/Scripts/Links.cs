using UnityEngine;

public class Links : MonoBehaviour
{
    public string[] url; // Aquí debes poner el enlace que deseas abrir
    public void AbrirEnlaceURL()
    {
        Application.OpenURL(url[0]);
    }
    public void AbrirEnlaceURL2()
    {
        Application.OpenURL(url[1]);
    }
    public void AbrirEnlaceURL3()
    {
        Application.OpenURL(url[2]);
    }
}
