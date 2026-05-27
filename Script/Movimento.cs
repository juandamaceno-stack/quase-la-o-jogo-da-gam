using UnityEngine;

public class Movimento : MonoBehaviour
{
   private float VelocidadeMaxima;
   private float VelocidadeWS;
   private float VelocidadeAD;

   public float VelocidadeFinal;
   public float TaxaDeAcerelacao=1.0005f;
   public float VelocidadeDeMovimentoArrasto=10f;
   public float VelocidadeDeMovimento=20f;

   private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
    float TaApertandoAOuDOuSetinha = 0f;
    float TaApertandoWOuSOuASetinha = 0f;


       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) TaApertandoWOuSOuASetinha += 1f;
       if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) TaApertandoWOuSOuASetinha -= 1f;
       if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) TaApertandoAOuDOuSetinha += 1f;
       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) TaApertandoAOuDOuSetinha -= 1f;

       if(VelocidadeDeMovimentoArrasto<100)
       {
        VelocidadeDeMovimentoArrasto = VelocidadeDeMovimentoArrasto*TaxaDeAcerelacao;
       } 


        VelocidadeWS = TaApertandoWOuSOuASetinha * VelocidadeDeMovimento;
        VelocidadeAD = TaApertandoAOuDOuSetinha * VelocidadeDeMovimento;
        Vector2 VelocidadeCombinada = new Vector2(VelocidadeAD, VelocidadeWS);
        Vector2 VelocidadeDeArrasto = new Vector2(-VelocidadeDeMovimentoArrasto, 0f);

          Vector2 VelocidadeFinal = VelocidadeCombinada + VelocidadeDeArrasto;
        
            rb.linearVelocity = VelocidadeFinal;

        

    }
}
