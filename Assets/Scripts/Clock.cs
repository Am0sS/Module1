using UnityEngine;
using System;

public class Clock : MonoBehaviour {

	[SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    [SerializeField] public float hoursToDegrees, secondsToDegrees, minutesToDegrees; // -30, -6, -6 default

void Update () {
    TimeSpan time = DateTime.Now.TimeOfDay;
    hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
	minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
	secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
}

}
 