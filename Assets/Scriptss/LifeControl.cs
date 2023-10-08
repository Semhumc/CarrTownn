using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
   public int can = 3;
    public Text canText; 
    public GameObject losePanel;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            can--;
            
            if (can <= 0)
            {
                can = 0;
                losePanel.SetActive(true); 
                
            }
        }
        UpdateCanUI();
    }

    void UpdateCanUI()
    {
        canText.text = "Can: " + can.ToString();
    }
}
