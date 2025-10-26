using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minute = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        float milliseconds = elapsedTime % 1 * 1000;
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}",minute, seconds, milliseconds);
    }
}
