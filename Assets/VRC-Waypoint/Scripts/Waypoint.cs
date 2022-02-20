using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

namespace VRC_Waypoint.Scripts
{
    /// <summary>
    /// Waypoint the player can visit.
    /// Each waypoint can have a name, a sprite, or both. 
    ///
    /// Players unlock a waypoint by standing on top of it. A collider with 'is trigger' is required.
    ///
    /// The waypoint manager needs to be in the scene.
    /// It takes the data from each waypoint to automatically create a list of waypoints.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class Waypoint : UdonSharpBehaviour
    {
        #region InspectorVariables
        [Header("Info")] 
        [SerializeField] [Tooltip("Name of the waypoint as it will be displayed to the player.")]
        private string title;
        [SerializeField] [Tooltip("If checked, the title will be hidden unlock the waypoint has been unlocked.")]
        private string titleIsSecret;
        [SerializeField] [Tooltip("Screenshot or image to represent the waypoint.")]
        private Sprite sprite;
        [SerializeField] [Tooltip("If checked, the sprite will be hidden unlock the waypoint has been unlocked.")]
        private string spriteIsSecret;

        [Header("References")]
        [SerializeField] [Tooltip("Animator will receive 'IsUnlocked' and 'IsPlayerHere' bool parameters.")]
        private Animator animator;
        #endregion

        private void OnTriggerEnter(Collider other)
        {
        }
    }
}
