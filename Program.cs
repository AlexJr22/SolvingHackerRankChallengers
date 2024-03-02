using SolveHackerRankChallengers.Challengers;

// this part is used to pass the parameters to the method called
//==============================================================

var scores = new List<int> { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

//==============================================================

// call the method to want execute
List<int> Count = Answers.BreakingRecords(scores);

Console.WriteLine($"{Count[0]} {Count[1]}");