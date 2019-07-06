using System.Collections;
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

        [Tooltip("Delay before invoking the Event.")]
        public float Delay = 0f;

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
            StartCoroutine(_InvokeResponse());
        }

        private IEnumerator _InvokeResponse()
        {
            yield return new WaitForSeconds(Delay);

            Response.Invoke();
            yield return null;
        } 
    }
}
