import java.util.*;

class Program {
  public int[] arrayOfProducts(int[] array) {
		int[] result = new int[array.length];
		for (int i = 0; i < array.length; i++) {
			int newValue = 1;
			for (int j = 0; j < array.length; j++) {
			  if (i != j) {
					newValue *= array[j];
				}
			}
			result[i] = newValue;
		}  
    return result;
  }
}

// import java.util.*;

// class Program {
//   public int[] arrayOfProducts(int[] array) {
// 		int[] result = new int[array.length];
		
// 		int rightRunningProduct = 1;
// 		for (int i = array.length-1; i > -1; i--) {
// 			result[i] = rightRunningProduct; 
// 			rightRunningProduct *= array[i];
// 		}
		
// 		int leftRunningProduct = 1;
// 		for (int j = 0; j < array.length; j++) {
// 			result[j] *= leftRunningProduct; 
// 			leftRunningProduct *= array[j];
// 		}

//     return result;
//   }
// }
