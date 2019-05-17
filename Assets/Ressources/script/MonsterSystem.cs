using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSystem : MonoBehaviour
{

    // Initialisation de tout les object pour l'animation, le canvas GameOver 
    public GameObject player;
    public Animator animator;
    public GameObject canvas;
    public bool isKilling = false;
    private int state = 0;

    void Start()
    {

    }

    // Update is called once per frame
    //Déclare la mort du joueur
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x - 4.5f, -2.6f, -1);
        if (isKilling)
        {
            KillPlayer();
        }
    }
    //animation monstre
    public void GoFurther()
    {
        state--;
        animator.SetInteger("State", state);
    }
    // animation monstre
    public void GoCloser()
    {
        state++;
        animator.SetInteger("State", state);
    }
    //Affichage gameover
    void KillPlayer()
    {
        canvas.GetComponent<CanvasManager>().GameOver();
    }
}
