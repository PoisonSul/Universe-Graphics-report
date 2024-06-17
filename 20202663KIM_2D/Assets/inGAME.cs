using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class inGAME : MonoBehaviour
{
    [SerializeField] Button leave;
    void Start()
    {
        leave.onClick.AddListener(()=>{           

            SceneManager.LoadScene("Title");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
