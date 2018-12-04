namespace Just_A_Test
{
    internal class BookCreator
    {
        public BookCreator()
        {
        }

        public BookCreator(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Seize { get; private set; }
        public string Color { get; private set; }
        public string Subject { get; private set; }


        public void BookSeize(int seize)
        {
            Seize = seize;
        }

        public void BookColor(string color)
        {
            Color = color;
        }

        public void BookSubject(string subject)
        {
            Subject = subject;
        }
    }
}