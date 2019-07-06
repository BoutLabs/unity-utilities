using UnityEngine;
using UnityEngine.Events;

namespace BoutLabs
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to respond to.")]
        public GameEvent Event;

        [Tooltip("Response to invoke when the Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}
