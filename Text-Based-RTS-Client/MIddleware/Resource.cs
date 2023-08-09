namespace Text_Based_RTS_Client.Middleware
{
    internal abstract class Resource
    {
        private int income = 0; // Zero by default
        private int storage = 0;
        private int stored = 0;

        // Gets resource Type
        public abstract string getType();

        // Gets/Sets stored number of a resource
        public void setStored(int num)
        {
            // Gets starting stored resources
            if (num <= storage)
            {
                stored = num;
            }
            else
            {
                stored = storage;
            }
        }

        public int getStored()
        {
            return stored;
        }

        // Increased/Gets Income/time_interval
        public void addIncome(int num)
        {
            income += num;
        }

        public int getIncome() { return income; }

    }
}