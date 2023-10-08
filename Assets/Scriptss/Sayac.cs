using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sayac : MonoBehaviour
{
    public Text sayacText;
    public float geriSayimSure = 60f;
    public GameObject losePanel;

    void Update()
    {
        geriSayimSure -= Time.deltaTime;

        if (geriSayimSure > 0)
        {
            sayacText.text = Mathf.Ceil(geriSayimSure).ToString();
        }
        else
        {
            sayacText.text = "0";
            losePanel.SetActive(true);
        }
    }
}
