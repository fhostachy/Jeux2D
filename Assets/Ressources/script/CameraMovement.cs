using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Sert uniquement pour le déplacement de la caméra sur le personnage 
        transform.position = new Vector3(character.transform.position.x, 0, -10);
    }
}
