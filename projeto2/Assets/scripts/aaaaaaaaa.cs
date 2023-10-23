using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aaaaaaaaa : MonoBehaviour
{
    public bool noChao;
    public int velocidade = 100;
    public int ForcaPulo = 7;
    private Rigidbody rb;
    private AudioSource source;
    public AudioClip clipPulo;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }

    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "chão"){
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        rb.AddForce(new Vector3(inputHorizontal, 0, inputVertical) * velocidade);

        if (Input.GetKeyDown(KeyCode.Space) && noChao){
            source.PlayOneShot(clipPulo);
            rb.AddForce(Vector3.up * ForcaPulo, ForceMode.Impulse);
            noChao = false;
        }
        
        if (transform.position.y <= -30){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}