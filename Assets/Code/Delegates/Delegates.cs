using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	//type
	class Delegates {
		//instance
		Delegates variableName;



		//type
		public delegate void PrintFunction();
		//instance
		public PrintFunction func;

		public delegate void PrintString(string name);
		public PrintString stringFunc;

		public delegate int MathFunction(int a, int b);
		public MathFunction mathFunc;

		

		public Delegates() {
			//PrintName();

			//assign value
			variableName = new Delegates();

			//assign value
			func = PrintName;
			func = PrintDate;
			func = PrintLocation;

			func();

			//not allowed, expects a parameter
			//PrintThis();
			//not allowed, func DOESN'T expect a parameter
			//func = PrintThis;

			stringFunc = PrintThis;

			mathFunc = Add;


			Action myAction = PrintName;
			Action<string> myStringAction = PrintThat;

			Func<int, int, int> myIntFunc = Add;

			myAction();
			myStringAction("name");
			myIntFunc(5, 7);
		}

		//returns void
		//no parameters
		private void PrintName(){
			Debug.Log("Joao");
		}

		private void PrintDate(){
			Debug.Log(DateTime.Now.Date);
		}

		private void PrintLocation(){
			Debug.Log("Berlin");
		}

		private void PrintThis(string someText){
			Debug.Log(someText);
		}

		private void PrintThat(string that){
			Debug.Log(that);
		}

		private int Add(int a, int b){
			return a + b;
		}
	}
}
