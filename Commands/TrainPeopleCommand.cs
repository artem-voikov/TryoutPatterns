namespace TryoutPatterns
{
    class TrainPeopleCommand : Command
    {
        protected Gym gym;
        public TrainPeopleCommand(Gym gym)
        {
            this.gym = gym;
        }

        protected override void InternalLogic()
        {
            gym.Train();
        }
    }

}
