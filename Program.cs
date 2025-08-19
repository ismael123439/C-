namespace curso
{
    class Program()
    {
        static void Main()
        {

            try
            {
                int data = Convert.ToInt32("k");
            }
            catch (Exception e)
            {
                string m = e.Message;
                throw;
            }
            finally
            {
                Console.WriteLine("buenas");
            }

        }
    }
}