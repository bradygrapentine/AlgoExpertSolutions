using System.Collections.Generic;
using System.Linq;
using System;


public class Program {
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
		var currentNode = linkedList;
		if (linkedList.next == null) {
			return linkedList;
		}
		var nextNode = linkedList.next;
		while (nextNode.next != null) {
			if (currentNode.value == nextNode.value) {
				currentNode.next = null;
			}
			else {
				currentNode.next = nextNode;
				currentNode = nextNode;
			}
			nextNode = nextNode.next;
		}
		if (currentNode.value == nextNode.value) {
			currentNode.next = null;
		}
		return linkedList;
	}
}

// https://www.algoexpert.io/questions/Remove%20Duplicates%20From%20Linked%20List
