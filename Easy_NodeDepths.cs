using System;

public class Program {
	public static int NodeDepths(BinaryTree root, int currentDepth = 0) {
		var result = currentDepth;
		if (root.left != null) result += NodeDepths(root.left, currentDepth + 1);
		if (root.right != null) result += NodeDepths(root.right, currentDepth + 1);
		return result;
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
}

// using System;

// public class Program {
// 	public static int NodeDepths(BinaryTree root, int currentDepth = 0) {
// 		if (root.left != null && root.right != null) 
// 		{
// 			return currentDepth + NodeDepths(root.right, currentDepth + 1) + NodeDepths(root.left, currentDepth + 1);
// 		}
// 		else if (root.left != null) 
// 		{
// 			return currentDepth + NodeDepths(root.left, currentDepth + 1);
// 		}
// 		else if (root.right != null) 
// 		{
// 			return currentDepth + NodeDepths(root.right, currentDepth + 1);
// 		}
// 		return currentDepth;
// 	}

// 	public class BinaryTree {
// 		public int value;
// 		public BinaryTree left;
// 		public BinaryTree right;

// 		public BinaryTree(int value) {
// 			this.value = value;
// 			left = null;
// 			right = null;
// 		}
// 	}
// }

// https://www.algoexpert.io/questions/Node%20Depths
