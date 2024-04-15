using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public TMP_Text coinText;
    private int coinCount = 0; // Cantidad actual de monedas

    public void IncreaseCoinsPromotion1()
    {
        coinCount += 1000; // Aumenta la cantidad de monedas según la promoción 1
        UpdateCoinText();
    }

    public void IncreaseCoinsPromotion2()
    {
        coinCount += 2500; // Aumenta la cantidad de monedas según la promoción 2
        UpdateCoinText();
    }

    public void IncreaseCoinsPromotion3()
    {
        coinCount += 5000; // Aumenta la cantidad de monedas según la promoción 3
        UpdateCoinText();
    }

    public void IncreaseCoinsPromotion4()
    {
        coinCount += 10000; // Aumenta la cantidad de monedas según la promoción 4
        UpdateCoinText();
    }

    public void IncreaseCoinsPromotion5()
    {
        coinCount += 20000; // Aumenta la cantidad de monedas según la promoción 5
        UpdateCoinText();
    }
    // Define funciones similares para las otras promociones (Promotion3, Promotion4, Promotion5)

    private void UpdateCoinText()
    {
        coinText.text = coinCount.ToString(); // Actualiza el texto de las monedas
    }
}
