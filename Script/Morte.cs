using UnityEngine;

public class Morte : MonoBehaviour
{
     public GameObject TELADEMORTE;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigo"))
        {
          TELADEMORTE.SetActive(true);
        
           Destroy(gameObject);

        }


    }


}
