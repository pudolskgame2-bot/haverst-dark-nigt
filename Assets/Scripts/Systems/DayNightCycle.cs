using ColheitaDaNoite.Core;
using UnityEngine;

namespace ColheitaDaNoite.Systems
{
    public class DayNightCycle : MonoBehaviour
    {
        [SerializeField] private GameState gameState;
        [SerializeField] private Light directionalLight;
        [SerializeField] private float dayDurationInMinutes = 12f;

        private void Update()
        {
            if (gameState == null || directionalLight == null || dayDurationInMinutes <= 0f) return;

            float hoursPerSecond = 24f / (dayDurationInMinutes * 60f);
            gameState.AdvanceTime(Time.deltaTime * hoursPerSecond);

            float sunAngle = (gameState.timeOfDay / 24f) * 360f - 90f;
            directionalLight.transform.rotation = Quaternion.Euler(sunAngle, 170f, 0f);
            directionalLight.intensity = gameState.IsNight ? 0.15f : 1f;
        }
    }
}
