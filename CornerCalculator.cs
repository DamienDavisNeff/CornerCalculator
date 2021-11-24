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

		  float centerEdgeA;
		  float centerEdgeB;
		  float centerEdgeC;
		  float centerEdgeD;
		  
		  float cornerA1;
		  float cornerA2;
		  string cornerA;
		  float cornerB1;
		  float cornerB2;
		  string cornerB;
		  float cornerC1;
		  float cornerC2;
		  string cornerC;
		  float cornerD1;
		  float cornerD2;
		  string cornerD;

		  float radius = 128;

			centerEdgeA = centerX + radius;
			centerEdgeB = centerZ + radius;
			centerEdgeC = centerX - radius;
			centerEdgeD = centerZ - radius;
			
			cornerA1 = centerX + radius;
			cornerA2 = centerZ + radius;
			cornerA = cornerA1+","+cornerA2;
			
			cornerB1 = centerX - radius;
			cornerB2 = centerZ - radius;
			cornerB = cornerB1+","+cornerB2;
			
			cornerC1 = centerX + radius;
			cornerC2 = centerZ - radius;
			cornerC = cornerC1+","+cornerC2;
			
			cornerD1 = centerX - radius;
			cornerD2 = centerZ + radius;
			cornerD = cornerD1+","+cornerD2;
			
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
