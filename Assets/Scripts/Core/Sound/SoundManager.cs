using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public enum SoundState
    {
        Off,
        On
    }

    private const string VIBRATE = "Vibrate";
    private const string SOUND = "Sound";

    [SerializeField] private Button vibrateSetting;
    [SerializeField] private Button soundSetting;

    private SoundState vibrateState;
    private SoundState soundState;

    private void Start()
    {
        vibrateState = (SoundState)PlayerPrefs.GetInt(VIBRATE, 1);
        soundState = (SoundState)PlayerPrefs.GetInt(SOUND, 1);

        SetButtonColor(vibrateSetting, vibrateState);
        SetButtonColor(soundSetting, soundState);
    }

    public void VibrateSetting()
    {
        vibrateState = (SoundState)(((int)vibrateState + 1) % 2);
        PlayerPrefs.SetInt(VIBRATE, (int)vibrateState);
        SetButtonColor(vibrateSetting, vibrateState);
    }

    public void SoundSetting()
    {
        soundState = (SoundState)(((int)soundState + 1) % 2);
        PlayerPrefs.SetInt(SOUND, (int)soundState);
        SetButtonColor(soundSetting, soundState);
    }

    private void SetButtonColor(Button button, SoundState state)
    {
        Color32 color = state == SoundState.On ? Color.white : Color.gray;
        button.image.color = color;
    }
}
