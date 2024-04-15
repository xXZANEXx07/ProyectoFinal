using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPaneles : MonoBehaviour
{
    [Header("Paneles")]
    [SerializeField]private GameObject[] Paneles;

    public void ActivarPaneles(int panel)
    {
        for(int i=0; i< Paneles.Length; i++)
        {
            if (i == panel)
            {
                Paneles[i].SetActive(true);
            }
            else
            {
                Paneles[i].SetActive(false);
            }
        }
    }
}
