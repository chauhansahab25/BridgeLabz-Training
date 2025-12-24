using System;

public class VolOfEarth{
public static void Main(String[] args){
   
        double pi = Math.PI;
		double RadiusinKm = 6378;


     
        double volumeinKm = (4.0 / 3.0) * pi * Math.Pow(RadiusinKm, 3);

       
        double RadiusinMiles = RadiusinKm * 0.621371;

   
        double volumeinMiles = (4.0 / 3.0) * pi * Math.Pow(RadiusinMiles, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is  "+  volumeinKm +"in Miles  " + volumeinMiles);
    }
}