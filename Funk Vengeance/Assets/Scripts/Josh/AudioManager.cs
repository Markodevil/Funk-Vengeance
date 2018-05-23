using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AUDIO
{
    public class AudioManager : MonoBehaviour
    {

        // List of Sound Clips
        public static AudioClip CaughtClip, Stab1Clip, Stab2Clip, TargetDownClip, VictoryClip, FailureClip, AlertClip, BackGroundClip;
        // Audio Source
        static AudioSource am;

        // Sound Clips
        // Variables that appear in the Unity Editor, for quick and easy replacement
        [SerializeField]
        [Tooltip("Audio clip for getting caught.")]
        public AudioClip Caught_SFX;
        [SerializeField]
        [Tooltip("Audio clip for stabbing.")]
        public AudioClip Stab1_SFX;
        [SerializeField]
        [Tooltip("Audio clip for stabbing.")]
        public AudioClip Stab2_SFX;
        [SerializeField]
        [Tooltip("Audio clip for the target doing down.")]
        public AudioClip TargetDown_SFX;
        [SerializeField]
        [Tooltip("Audio clip when the victory is achieved.")]
        public AudioClip Victory_SFX;
        [SerializeField]
        [Tooltip("Audio clip when you have failed.")]
        public AudioClip Failure_SFX;
        [SerializeField]
        [Tooltip("Audio clip when you are seen")]
        public AudioClip Alert_SFX;
        [SerializeField]
        [Tooltip("BackGround Music")]
        public AudioClip BackGround_SFX;

        // Initialization
        void Start()
        {
            am = GetComponent<AudioSource>();
            CaughtClip = Caught_SFX;
            Stab1Clip = Stab1_SFX;
            Stab2Clip = Stab2_SFX;
            TargetDownClip = TargetDown_SFX;
            VictoryClip = Victory_SFX;
            FailureClip = Failure_SFX;
            AlertClip = Alert_SFX;
            BackGroundClip = BackGround_SFX;
        }

        // Update
        void Update()
        {

        }

        // Play Sound
        // Switch Statement to play a differing sound for each case
        public static void PlaySound(string clip)
        {
            switch (clip)
            {
                // Caught sound
                case "Caught":
                    am.PlayOneShot(CaughtClip, 1f);
                    break;
                // Stab sound
                case "Stab1":
                    am.PlayOneShot(Stab1Clip, 1f);
                    break;
                // Stab sound
                case "Stab2":
                    am.PlayOneShot(Stab2Clip, 1f);
                    break;
                // Target Down sound
                case "TargetDown":
                    am.PlayOneShot(TargetDownClip, 1f);
                    break;
                // Player Failure sound
                case "Victory":
                    am.PlayOneShot(VictoryClip, 1f);
                    break;
                // Player Victory sound
                case "Failure":
                    am.PlayOneShot(FailureClip, 1f);
                    break;
                // Player Victory sound
                case "Alert":
                    am.PlayOneShot(AlertClip, 1f);
                    break;
                // BackGround Music
                case "BackGround":
                    am.PlayOneShot(BackGroundClip, 1.0f);
                    break;
            }
        }
    }
}
