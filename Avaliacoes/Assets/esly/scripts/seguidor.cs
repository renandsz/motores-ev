using UnityEngine;

namespace esly.scripts
{
    public class seguidor : MonoBehaviour
    {
        public Transform alvo;
        public Vector3 offset;
        // Start is called before the first frame update
        void Start()
        {
            offset = alvo.position - transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = alvo.position - offset;
        }
    }
}
