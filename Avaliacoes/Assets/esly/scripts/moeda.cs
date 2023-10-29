using UnityEngine;

namespace esly.scripts
{
    public class moeda : MonoBehaviour
    {
        public int velocidadeGiro = 100;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        private void OnTriggerEnter(Collider other){
            if (other.tag == "Player"){
                Destroy(gameObject);
            }
        }
    
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.forward, velocidadeGiro * Time.deltaTime);
        }
    }
}
