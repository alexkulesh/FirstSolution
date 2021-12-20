namespace Part16Task2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Referee referee = new Referee("Pier");
            Ball ball = new Ball();
            FieldPlayer fieldPlayerA1 = new FieldPlayer("Nick");
            FieldPlayer fieldPlayerA2 = new FieldPlayer("Mike");
            GoalKeeper goalKeeperA = new GoalKeeper("Kasper");
            FieldPlayer fieldPlayerB1 = new FieldPlayer("Vasya");
            FieldPlayer fieldPlayerB2 = new FieldPlayer("Kolya");
            GoalKeeper goalKeeperB = new GoalKeeper("Petya");
            referee.Whistle();
            Simulator.Move(Position.Center(), ball);
            fieldPlayerA1.Pass(fieldPlayerA2);
            fieldPlayerA2.Pass(fieldPlayerA1);
            Simulator.Move(Position.PenaltyArea(), ball, fieldPlayerA1, fieldPlayerA2);
            fieldPlayerA1.KickOnGoal();
            goalKeeperB.CatchBall();
            goalKeeperB.Pass(fieldPlayerA1);
            Simulator.Move(Position.Center(), ball);
            Simulator.Move(Position.PenaltyArea(), fieldPlayerB1);
            referee.Whistle();
            fieldPlayerB1.PickBooking();
            fieldPlayerA2.Pass(fieldPlayerA1);
            referee.Whistle();
            fieldPlayerA2.PickBooking();
            fieldPlayerB1.Pass(fieldPlayerB2);
            fieldPlayerB2.Pass(fieldPlayerB1);
            Simulator.Move(Position.PenaltyArea(), fieldPlayerB1);
            fieldPlayerA2.CatchBall();
            referee.Whistle();
            fieldPlayerA2.PickBooking();
            fieldPlayerB1.KickOnGoal();
            goalKeeperA.MissBall();
        }
    }
}