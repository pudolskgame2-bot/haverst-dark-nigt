using UnityEngine;

namespace ColheitaDaNoite.Core
{
    [CreateAssetMenu(fileName = "GameState", menuName = "ColheitaDaNoite/Game State")]
    public class GameState : ScriptableObject
    {
        [Range(0f, 24f)] public float timeOfDay = 8f;
        public int day = 1;
        [Range(0f, 1f)] public float corruptionLevel;

        public bool IsNight => timeOfDay >= 18f || timeOfDay < 6f;

        public void AdvanceTime(float hours)
        {
            timeOfDay += hours;
            while (timeOfDay >= 24f)
            {
                timeOfDay -= 24f;
                day++;
            }
        }
    }
}
