using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CornerCalculator {
	
	public class CornerCalculator {

		public static void Main() {
		  
		Console.WriteLine("Insert X Coordinate");
		float centerX = float.Parse(Console.ReadLine());
		Console.WriteLine("Insert Z Coordinate");
		float centerZ = float.Parse(Console.ReadLine());

		Console.WriteLine("Insert Radius");
		float radius = float.Parse(Console.ReadLine());

		float centerEdgeA = centerX + radius;
		float centerEdgeB = centerZ + radius;
		float centerEdgeC = centerX - radius;
		float centerEdgeD = centerZ - radius;
			
		float cornerA1 = centerX + radius;
		float cornerA2 = centerZ + radius;
		string cornerA = cornerA1+","+cornerA2;
			
		float cornerB1 = centerX - radius;
		float cornerB2 = centerZ - radius;
		string cornerB = cornerB1+","+cornerB2;
			
		float cornerC1 = centerX + radius;
		float cornerC2 = centerZ - radius;
		string cornerC = cornerC1+","+cornerC2;
			
		float cornerD1 = centerX - radius;
		float cornerD2 = centerZ + radius;
		string cornerD = cornerD1+","+cornerD2;
			
		Console.WriteLine("CORNER: "+cornerA);
		Console.WriteLine("CORNER: "+cornerB);
		Console.WriteLine("CORNER: "+cornerC);
		Console.WriteLine("CORNER: "+cornerD);
			
		// Console.WriteLine(centerEdgeA+","+centerZ);
		// Console.WriteLine(centerX+","+centerEdgeB);
		// Console.WriteLine(centerEdgeC+","+centerZ);
		// Console.WriteLine(centerX+","+centerEdgeD);

        Console.WriteLine("Press 'Enter' To Close");
        Console.ReadLine();

		}
	}
}