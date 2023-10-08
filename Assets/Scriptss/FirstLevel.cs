using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstLevel : MonoBehaviour
{
    public GameObject kazandinPaneli;
    private bool playerInsideArea = false;
    private float timer = 0f;
    public float winningTime = 5f; // Kazanma süresi (5 saniye olarak varsayılan)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideArea = true;
        }
    }

    

    void Update()
    {
        if (playerInsideArea)
        {
            timer += Time.deltaTime;

            if (timer >= winningTime)
            {
                kazandinPaneli.SetActive(true);
                
            }
        }
    }
}




     

    

