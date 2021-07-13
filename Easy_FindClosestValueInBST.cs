using System;
using System.Collections.Generic;

public class Program {
	public static int FindClosestValueInBst(BST tree, int target) {
		var result = tree.value;
                var queue = new Queue<BST>();
		if (tree != null) 
		{
			queue.Enqueue(tree);
		}
                while (queue.Count > 0) 
		{
			var n = queue.Dequeue();
			if (n != null) 
                        {
				if (Math.Abs(n.value - target) <  Math.Abs(result - target)) 
				{
					result = n.value ;
				}
				queue.Enqueue(n.left);
                                queue.Enqueue(n.right);
			}
		}
		return result;
	}

	
	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}
}

// https://www.algoexpert.io/questions/Find%20Closest%20Value%20In%20BST
