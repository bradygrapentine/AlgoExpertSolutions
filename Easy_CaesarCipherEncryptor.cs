using System;
using System.Linq;
using System.Text;

public class Program {
	public static string CaesarCypherEncryptor(string str, int key) {
		return  Encoding.ASCII.GetString(Encoding.ASCII
						 .GetBytes(str)
						 .Select(asciiByte => 
							 (Convert.ToInt32(asciiByte) + (key % 26)) > 122 ? 
							 (byte)(((Convert.ToInt32(asciiByte) + (key % 26)) - 122) + 96 ) : 
							 (byte)(Convert.ToInt32(asciiByte) + (key % 26)))
						 .ToArray());
	}
}


// using System;
// using System.Linq;
// using System.Text;

// public class Program {
// 	public static string CaesarCypherEncryptor(string str, int key) {
// 		byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
// 		var asciiBytesShifted = asciiBytes
// 			.Select(asciiByte => {
// 				var shiftedCode = Convert.ToInt32(asciiByte) + key % 26;
// 				if (shiftedCode > 122) {
// 					shiftedCode = (shiftedCode - 122) + 96;
// 				}
// 				return (byte)(shiftedCode);
// 			})
// 			.ToArray();
// 		return Encoding.ASCII.GetString(asciiBytesShifted);
// 	}
// }


// https://www.algoexpert.io/questions/Caesar%20Cipher%20Encryptor
