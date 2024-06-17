using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
     [SerializeField] Button GameStart;
    void Start()
    {
        GameStart.onClick.AddListener(()=>{           

            SceneManager.LoadScene("inGAME");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
