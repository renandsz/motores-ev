using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    public bool noChao;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        TryGetComponent(out rb);
    }
    private void OnTriggerEnter(Collider other){
        
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // -1 esquerda, 0 nada, 1 direita
        float v = Input.GetAxis("Vertical"); // -1 pra tras, 0 nada, 1 pra frente

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade); //movimentação

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }

        if(transform.position.y <= -10){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reset
        }
    }
}
