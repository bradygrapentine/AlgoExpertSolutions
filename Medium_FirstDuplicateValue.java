import java.util.*;

class Program {

  public int firstDuplicateValue(int[] array) {
		HashMap<Integer, Boolean> numbers = new HashMap<>();
		for (int i = 0; i < array.length; i++) {
			if (numbers.containsKey(array[i])) {
				return array[i];
			} else {
				numbers.put(array[i], true);
			}
		}
		return -1;
  }
}
