using System.Collections.Generic;
using System.Collections;
using System;

public class Program {
	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
		
		Dictionary<string, int> wins = new Dictionary<string, int>();
		int topScore = 0;
		string winner = "";

		for (int i = 0; i < results.Count; i++) {
			string home = competitions[i][0];
			string away = competitions[i][1];
			if (results[i] == 1 && !(wins.ContainsKey(home))) 
			{
				wins[home] = 1;
				if (wins[home] > topScore)
			  {
				  topScore = wins[home];
				  winner = home;
			  }
			}
			else if (results[i] == 0 && !(wins.ContainsKey(away)))
			{
				wins[away] = 1;
				if (wins[away] > topScore) 
				{
					topScore = wins[away];
				  winner = away;
			  }
			}
			else if (results[i] == 1 && (wins.ContainsKey(home))) 
			{
				wins[home] += 1;
				if (wins[home] > topScore)
			  {
					topScore = wins[home];
				  winner = home;
			  }
			}
			else if (results[i] == 0 && (wins.ContainsKey(away)))
			{
				wins[away] += 1;
				if (wins[away] > topScore) 
				{
					topScore = wins[away];
				  winner = away;
			  }
			}
		}
		return winner;
	}
}

// using System.Collections.Generic;
// using System.Collections;
// using System;

// public class Program {

// 	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
// 		Dictionary<string, int> scores = new Dictionary<string, int>();
// 		for (var i = 0; i < results.Count; i++) {
// 			if (results[i] == 1 && !(scores.ContainsKey(competitions[i][0]))) 
// 			{
// 				scores[competitions[i][0]] = 1;
// 			}
// 			else if (results[i] == 0 && !(scores.ContainsKey(competitions[i][1])))
// 			{
// 				scores[competitions[i][1]] = 1;
// 			}
// 			else if (results[i] == 1 && (scores.ContainsKey(competitions[i][0]))) 
// 			{
// 				scores[competitions[i][0]] += 1;
// 			}
// 			else if (results[i] == 0 && (scores.ContainsKey(competitions[i][1])))
// 			{
// 				scores[competitions[i][1]] += 1;
// 			}
// 		}
// 		var topScore = 0;
// 		var winner = "";
// 		foreach(var item in scores)
// 		{
// 			if (item.Value > topScore) 
// 			{
// 				topScore = item.Value;
// 				winner = item.Key;
// 			}
// 		}
// 		return winner;
// 	}
// }
