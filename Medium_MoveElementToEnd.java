import java.util.*;
import static java.util.stream.Collectors.toList;

class Program {
  public static List<Integer> moveElementToEnd(List<Integer> array, int toMove) {
		List<Integer> filteredArray =  array
			                             .stream()
                                   .filter(t -> t != toMove)
                                   .collect(toList());
		int count = array.size() - filteredArray.size();
		for (int i = 0; i < count; i++) {
			filteredArray.add(toMove);
		}
		return filteredArray;
  }
}

// https://www.algoexpert.io/questions/Move%20Element%20To%20End
