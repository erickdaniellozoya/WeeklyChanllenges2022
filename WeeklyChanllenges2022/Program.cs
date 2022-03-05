Console.Write("Choose a challenge (0-8): ");
int option = int.Parse(Console.ReadLine() ?? "0");
WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(option).DoChallenge();
