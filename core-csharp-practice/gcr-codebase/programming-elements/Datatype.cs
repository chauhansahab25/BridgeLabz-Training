using System;
class Datatype{
	static void Main(String[] args){
	byte c = 22;
	int cu = 3;
	long co = 43;
	short ci = 100;
	float cl = 3.04f;
	double cp = 3.09;
	char cou = 'could';
	bool isPass = true;
    string wool = "sheep";
	int[] numbers = {1,2,3,4};
		public void StartEngine(){
			Console.WriteLine("Engine Started");
		}
	Car myCar = new Car();
	myCar.model = Toyota;
	myCar.year = 2020;
	myCar.startEngine();
	}
	public enum Day{
		Monday, Tuesday, Wednesday, Thursday
	}
	Day today = Day.Monday;
	//Implicit CONVERSION 
	int a = 8;
	double b = a;
	Console.WriteLine(b);
	//Explicit CONVERSION
	float c = 10.4f;
	long b = (long)c;
}