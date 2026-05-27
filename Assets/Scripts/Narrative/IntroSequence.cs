using ColheitaDaNoite.Core;
using UnityEngine;

namespace ColheitaDaNoite.Narrative
{
    public class IntroSequence : MonoBehaviour
    {
        [SerializeField] private GameState gameState;
        [SerializeField] private string protagonistaNome = "Protagonista";

        private bool triggered;

        private void Start()
        {
            Debug.Log($"{protagonistaNome} chegou ao Vale de Brumafunda e herdou a fazenda.");
        }

        private void Update()
        {
            if (gameState == null || triggered) return;

            if (gameState.IsNight)
            {
                triggered = true;
                Debug.Log("Primeira noite: a terra pulsa e sons da mina ecoam sob a plantação.");
            }
        }
    }
}
