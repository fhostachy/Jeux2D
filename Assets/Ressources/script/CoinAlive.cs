using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAlive : MonoBehaviour
{
    //Sert a déclarer que la pièce de monnaie est en vie donc non ramassé
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Sert a détruire la pièce si le joueur passe dessus 
    void Update()
    {
        if (!isAlive)
        {
            Destroy(gameObject);
        }
    }
}
