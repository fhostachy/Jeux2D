using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsBahavior : MonoBehaviour
{
    //Créationde la pièce ça valeur 1  sont UI pour ensuite permetre une animation 
    public int value = 1;
    private GameObject UI;
    public Animator animator;
    // Use this for initialization

    // Rechereche du tag CoinAmount pour le stocker
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("CoinAmount");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Sert pour la Collision entre le joueur et la pièce
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            int coinUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = coinUI + "";
            animator.SetBool("IsCollect", true);
        }
    }
}
