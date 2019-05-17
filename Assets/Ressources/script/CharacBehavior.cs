using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacBehavior : MonoBehaviour
{

    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    public float VulnerabilityTime;
    private bool isGrounded = false;

    // Use this for initialization
    // Sert à crée de la vitesse au personnage afin qu'il avance
    void Start()
    {
        SetVelocity(vitesse, 0);
    }

    // Update is called once per frame
    // Création du moyen de sauter assignation d'une touche espace dans ce cas
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
    }
    // Sert a savoir a quelle hauteur saute le personnage
    void Jump()
    {
        rb.velocity += new Vector2(0, maxJump);
    }
    // Sert à définir le sol en tant que true ou false pour savoir s'il tombe dans un troue
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Sert à définir le sol en tant que true ou false pour savoir s'il tombe dans un troue
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // Gère l'axe x,y pour que le joueur ne vols pas.
    void SetVelocity(float xVelocity, float yVelocity)
    {
        rb.velocity = new Vector2(0, 0);
        rb.velocity += new Vector2(xVelocity, yVelocity);
    }

    //Création et mise en place de des obstacle
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(ObstacleFind());
        }
    }

    // Gestion du monstre si le joueur touche un obstacle
    IEnumerator ObstacleFind()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoCloser();
        SetVelocity(vitesse / 2, 0);
        yield return new WaitForSeconds(0.5f);
        SetVelocity(vitesse, 0);
        yield return new WaitForSeconds(VulnerabilityTime);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoFurther();
    }
}
