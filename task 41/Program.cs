int countOfPositive = 0;

while (true)
{
    string answer = Console.ReadLine();
    if (answer  == "stop") 
    {
        break;
    }
    else
    {
        double.TryParse(answer, out double answerNumber);
        if (answerNumber > 0)
        {
            countOfPositive++;
        }
    }
}
Console.WriteLine(countOfPositive);