Console.WriteLine("Please enter the point deduction per wrong answer.");
if (!float.TryParse(Console.ReadLine(), out float points_removed_per_incorrect_answer) && !string.IsNullOrEmpty(Console.ReadLine()))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("Please enter the total number of questions:");
if (!float.TryParse(Console.ReadLine(), out float totalQuestions))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("Please enter the number of correct answers:");
if (!float.TryParse(Console.ReadLine(), out float correctAnswers) && !string.IsNullOrEmpty(Console.ReadLine()))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("Please enter the number of incorrect answers:");
if (!float.TryParse(Console.ReadLine(), out float incorrectAnswers) && !string.IsNullOrEmpty(Console.ReadLine()))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("Please enter the number of unanswered questions:");
if (!float.TryParse(Console.ReadLine(), out float unansweredQuestions) && !string.IsNullOrEmpty(Console.ReadLine()))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

float totalAnswered = correctAnswers + incorrectAnswers + unansweredQuestions;

if (totalQuestions != totalAnswered)
{
    Console.WriteLine("Error, The number of questions don't match with your answers.");
    return;
}

float netPoints = correctAnswers - incorrectAnswers * points_removed_per_incorrect_answer;

// Calculating the net points
float ToSubtract = incorrectAnswers / 4;
float TotalNet = correctAnswers - ToSubtract;

Console.WriteLine($"Your Results:\n\nThere were `{totalQuestions}` questions with a punishment of {points_removed_per_incorrect_answer} per wrong answer.\nYou answered `{totalAnswered}`, and you got {correctAnswers} of them correct, {incorrectAnswers} of them wrong. and you skipped {unansweredQuestions} questions.\nYour total net point is: {TotalNet}");