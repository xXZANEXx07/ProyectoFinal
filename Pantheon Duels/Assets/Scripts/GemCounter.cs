using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GemCounter : MonoBehaviour
{
    public TMP_Text gemText;
    private int gemCount = 0; // Cantidad actual de gemas

    public void IncreaseGemsPromotion1()
    {
        gemCount += 100; // Aumenta la cantidad de gemas según la promoción 1
        UpdateGemText();
    }

    public void IncreaseGemsPromotion2()
    {
        gemCount += 250; // Aumenta la cantidad de gemas según la promoción 2
        UpdateGemText();
    }

    public void IncreaseGemsPromotion3()
    {
        gemCount += 500; // Aumenta la cantidad de gemas según la promoción 3
        UpdateGemText();
    }

    public void IncreaseGemsPromotion4()
    {
        gemCount += 1000; // Aumenta la cantidad de gemas según la promoción 4
        UpdateGemText();
    }

    public void IncreaseGemsPromotion5()
    {
        gemCount += 2000; // Aumenta la cantidad de gemas según la promoción 5
        UpdateGemText();
    }

    private void UpdateGemText()
    {
        gemText.text = gemCount.ToString(); // Actualiza el texto de las gemas
    }
}
