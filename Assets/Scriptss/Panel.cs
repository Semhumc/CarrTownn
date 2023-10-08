using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject panel; // Inspector üzerinden panel nesnesini sürükleyip bırakacağız.

    void Start()
    {
        panel.SetActive(false); // Oyun başladığında paneli kapalı yap
        Invoke("PaneliAcKapat", 1f); // 5 saniye sonra PaneliAcKapat fonksiyonunu çağır
    }

    void PaneliAcKapat()
    {
        panel.SetActive(true); // Paneli aç
        Invoke("Kapat", 5f); // 5 saniye sonra Kapat fonksiyonunu çağır
    }

    void Kapat()
    {
        panel.SetActive(false); // Paneli kapat
    }
}
