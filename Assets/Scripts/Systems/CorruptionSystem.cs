using ColheitaDaNoite.Core;
using UnityEngine;

namespace ColheitaDaNoite.Systems
{
    public class CorruptionSystem : MonoBehaviour
    {
        [SerializeField] private GameState gameState;
        [SerializeField] private float passiveGrowthPerDay = 0.02f;
        [SerializeField] private float nightBonus = 0.01f;

        private float lastEvaluatedDay;

        private void Start()
        {
            if (gameState != null) lastEvaluatedDay = gameState.day;
        }

        private void Update()
        {
            if (gameState == null) return;

            if (gameState.day > lastEvaluatedDay)
            {
                gameState.corruptionLevel = Mathf.Clamp01(gameState.corruptionLevel + passiveGrowthPerDay);
                lastEvaluatedDay = gameState.day;
            }

            if (gameState.IsNight)
            {
                gameState.corruptionLevel = Mathf.Clamp01(gameState.corruptionLevel + nightBonus * Time.deltaTime / 60f);
            }
        }

        public void Purify(float value)
        {
            gameState.corruptionLevel = Mathf.Clamp01(gameState.corruptionLevel - value);
        }

        public void Embrace(float value)
        {
            gameState.corruptionLevel = Mathf.Clamp01(gameState.corruptionLevel + value);
        }
    }
}
