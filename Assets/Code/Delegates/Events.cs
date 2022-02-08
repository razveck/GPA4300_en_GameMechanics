using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {

	class UI {
		public UI() {
			//subscribe to the event
			Events.myEvent += Foo;

		}
		private void Foo() { }
	}

	class Events {

		List<Action> myCustomEvent = new();

		public static event Action myEvent;

		public Events() {
			myCustomEvent.Add(PrintName);
			myCustomEvent.Add(PrintDate);
			myCustomEvent.Add(PrintLocation);

			Invoke();

			myEvent += PrintName;
			myEvent += PrintDate;
			myEvent += PrintLocation;

			myEvent();

			myCustomEvent.Remove(PrintName);

			myEvent -= PrintName;
		}

		public void Invoke() {
			for(int i = 0; i < myCustomEvent.Count; i++) {
				myCustomEvent[i]();
			}
		}


		private void PrintName() {
			Debug.Log("Joao");
		}

		private void PrintDate() {
			Debug.Log(DateTime.Now.Date);
		}

		private void PrintLocation() {
			Debug.Log("Berlin");
		}
	}
}
