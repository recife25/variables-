//Felipe Ruiz
//variables using interpolation and console.writeline(); 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{

			//declared and initialized a viriable 
			//camelCase for the variable name 
			//explicit typing


			string dogName = "Ralf";
			int dogAge = 10;
			char nickName = 'R';
			bool lovesHiking = true;
			double tennisBalls = 32;
			decimal weight = 70.3m;

			//string interpolation with the $ and {} around variables
			Console.WriteLine($"MY dog's name is {dogName}, He is {dogAge} years old and has {tennisBalls} tennis balls and it is {lovesHiking} that he loves to hike and he is {weight} pounds in weight");



		}
	}
}
