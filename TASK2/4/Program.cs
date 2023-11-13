class Program
{
   enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };

    static void Main()
    {
        TestCaseStatus test1Status = TestCaseStatus.Pass;
        Console.WriteLine($"test1Status is {test1Status}");
    }
}