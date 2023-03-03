using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI contadorCocas;

   

    public int cocas=5;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        contadorCocas.text = "Cocas faltantes:  " + cocas;
        if(cocas==0)
        {
            SceneManager.LoadScene(2);
        }    
     
    }
}
