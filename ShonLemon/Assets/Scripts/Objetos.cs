using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    public TextMeshProUGUI Instrucciones;
    public TextMeshProUGUI ObjetosText;
    public int Objeto = 0;

   
    public void SetObjetosText()
    {
        ObjetosText.text = Objeto.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Objetos"))
        {
            other.gameObject.SetActive(false);
            Objeto++; 
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
