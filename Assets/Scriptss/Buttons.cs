using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
  
    
    public void GirisEkranButton()
    {
        SceneManager.LoadScene(0); 
    }
    public void garaj()
    {
        SceneManager.LoadScene(1);
    }

    public void cikis()
    {
        Application.Quit();
    }

    public void bitis()
    {
         SceneManager.LoadScene(8);
    }
    //Sari araba icin leveller


    public void  level1Sari()
    {
        SceneManager.LoadScene(2);
    }
     public void  level2Sari()
    {
        SceneManager.LoadScene(5);
    }

    

    //Kirmizi araba icin leveller

    public void  level1Kirimizi()
    {
        SceneManager.LoadScene(3);
    }
     public void  level2Kirimizi()
    {
        SceneManager.LoadScene(6);
    }

    //Mavi araba icin leveller

    public void  level1Mavi()
    {
        SceneManager.LoadScene(4);
    }
    public void  level2Mavi()
    {
        SceneManager.LoadScene(7);

    }



}
