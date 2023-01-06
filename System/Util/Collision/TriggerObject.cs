using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaoNubeLib.System {

    public abstract class TriggerObject : MonoBehaviour {

        protected virtual void OnTriggerEnterEvent(Collider collider) {
        }

        protected virtual void OnTriggerStayEvent(Collider collider) {
        }

        protected virtual void OnTriggerEnterAndStayEvent(Collider collider) {
        }

        protected virtual void OnTriggerExitEvent(Collider collider) {
        }

        private void OnTriggerEnter(Collider collider) {
            OnTriggerEnterEvent(collider);
            OnTriggerEnterAndStayEvent(collider);
        }

        private void OnTriggerStay(Collider collider) {
            OnTriggerStayEvent(collider);
            OnTriggerEnterAndStayEvent(collider);
        }

        private void OnTriggerExit(Collider collider) {
            OnTriggerExitEvent(collider);
        }

    }

}