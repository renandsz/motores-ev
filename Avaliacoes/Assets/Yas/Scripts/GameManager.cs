using TMPro;
using UnityEngine;

namespace Yas.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI hud, msgParabens;
        public int restantes;

        public AudioClip clipMoeda, clipVitoria;

        private AudioSource source;
        // Start is called before the first frame update
        void Start()
        {
            TryGetComponent(out source);
        
            restantes = FindObjectsOfType<Moeda>().Length;

            hud.text = $"Moedas restantes: {restantes}";
        }

        public void SubtrairMoedas(int valor)
        {
            restantes -= valor;
            hud.text = $"Moedas restantes: {restantes}";
            source.PlayOneShot(clipMoeda);

            if (restantes <= 0)
            {
                //ganhou o jogo
                msgParabens.text = "PARABÉNS!!!";
                source.Stop();
                source.PlayOneShot(clipVitoria);
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}