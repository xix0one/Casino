namespace Casino
{
    class Player
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks!");
        }

        public int GiveCash(int amount)
        {
            Cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            Cash += amount;
        }
    }
}
